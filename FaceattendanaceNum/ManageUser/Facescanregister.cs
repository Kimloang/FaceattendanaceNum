using DevExpress.XtraEditors;
using Emgu.CV.Structure;
using Emgu.CV;

using Emgu.CV.CvEnum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using DevExpress.XtraSplashScreen;
using scanface.Splash;
using MySql.Data.MySqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Threading;
using Emgu.CV.Face;
using DevExpress.Utils;
using scanface.ManageUser;

namespace scanface
{
    public partial class Facescanregister : DevExpress.XtraEditors.XtraForm
    {
        VideoCapture VideoCapture;
        Image<Bgr, Byte> BgrImage = null;
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;database=face-scan;password=loang*001");
        MySqlCommand cmd = new MySqlCommand();
        Mat frame = new Mat();

        CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> Faceresult, gray = null;
        List<Image<Bgr, Byte>> TrainFaces = new List<Image<Bgr, Byte>>();
        List<Image<Gray, Byte>> ImagesTrained = new List<Image<Gray, Byte>>();
        List<Mat> images = new List<Mat>();
        List<int> personlabel = new List<int>();
        bool enablesave = false;
        //private Image<Bgr, Byte> cmd;


        bool check = false;
        private void ProcessFrame(object sender, EventArgs e)
        {
            VideoCapture.Read(frame);
            BgrImage = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
            //Faceresult = BgrImage;

            Mat grayimage = new Mat();
            CvInvoke.CvtColor(BgrImage, grayimage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayimage, grayimage);
            //Rectangle[] face = face_case.DetectMultiScale(grayimage, 3, 5, Size.Empty, Size.Empty);
            Rectangle[] face = face_case.DetectMultiScale(grayimage, 1.3, 10, Size.Empty, Size.Empty);

            if (face.Length > 0)
            {

                for (var i = 0; i < face.Length; i++)
                {

                    Faceresult = BgrImage.Convert<Bgr, Byte>();
                    Faceresult.ROI = face[i];
                    face[i].X += (int)(face[i].Height * 0.15);
                    face[i].Y += (int)(face[i].Width * 0.1);
                    face[i].Height -= (int)(face[i].Height * 0.1);
                    face[i].Width -= (int)(face[i].Width * 0.2);
                    CvInvoke.Rectangle(BgrImage, face[i], new Bgr(Color.Green).MCvScalar, 2);
                    if (enablesave)
                    {
                        string path = System.IO.Directory.GetCurrentDirectory() + @"\Imagetrain";
                        if (!Directory.Exists(path))

                            Directory.CreateDirectory(path);
                    }
                    enablesave = true;
                }
                //{
                    /*
                    //Draw ractangle like filiter

                    CvInvoke.Rectangle(BgrImage, i, new Bgr(Color.Green).MCvScalar, 2);

                    Faceresult = BgrImage.Convert<Bgr, Byte>();
                    Faceresult.ROI = i;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox1.Image = Faceresult.ToBitmap();
                    if (enablesave)
                    {
                        string path = System.IO.Directory.GetCurrentDirectory() + @"\Imagetrain";
                        if (!Directory.Exists(path))

                            Directory.CreateDirectory(path);
                    }
                    enablesave = true;

                    */

               // }
            }
            else
            {
                enablesave = false;
            }
            //CvInvoke.PutText(BgrImage, DateTime.Now.ToString(), new Point(50,50),FontFace.HersheyComplex,3,new Rgb(Color.Green).MCvScalar);
            //if(Faceresult.IsROISet) enablesave = true;else enablesave= false;
            pictureBox1.Image = BgrImage.ToBitmap();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (enablesave)
            {
                pictureBox2face.Image = Faceresult.ToBitmap();
                pictureBox2face.Visible = true;
                labelControl2.Visible = true;
                btn_saved.Visible = true;
                return;
            }
            XtraMessageBox.Show("មិនអាចចាប់ផ្ទៃមុខបានទេសូមព្យាយាមម្តងទៀត");
            pictureBox2face.Visible = !true;
            labelControl2.Visible = false;
            btn_saved.Visible = false;
        }
        public byte[] Imagetobyte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void insertdb(Image imgs)
        {
            try
            {
                /*var memoryStream = new MemoryStream();
                imgs.Save(memoryStream, imgs.RawFormat);
                byte[] check = memoryStream.ToArray();
                */
                Byte[] data = Imagetobyte(imgs);
                //string sql = $"update  usernum set FaceScan=@img where UserID=@id";
               // string sql = $"update  usernum set FaceScan=@img where UserID=@UserID";
                string sql = "INSERT INTO usface(UserID,Facescan,CreateAt) VALUES(@UserID,@img,@date ) ";
                
                con.Open();
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@img", data);
                cmd.Parameters.AddWithValue("@UserID", Modeluser.ID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("error" + ex);
            }
        }
        private void btn_saved_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));
            try
            {
                if (enablesave)
                {
                    
                    string path = System.IO.Directory.GetCurrentDirectory() + @"\Imagetrain";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    //Faceresult.Resize(200, 200, Inter.Cubic).Save(path + $@"\_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                    Task.Factory.StartNew(() =>
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            //resize the image then saving it
                            Faceresult.Resize(100, 100, Inter.Cubic).Save(path + $@"\_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpeg");
                            insertdb(Faceresult.ToBitmap());
                            Thread.Sleep(1000);
                            if (j == 9)
                            {
                                XtraMessageBox.Show($"រូបភាព{Modeluser.ID}-{Modeluser.Name}ត្រូវបានផ្ទុកទៅកាន់Database", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    });
                  





                   



                    //XtraMessageBox.Show($"រូបភាព{Modeluser.ID}-{Modeluser.Name}ត្រូវបានផ្ទុកទៅកាន់Database", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
               
                SplashScreenManager.CloseForm();
            }
        }

        void selectpictest()
        {
            MySqlDataReader reader;
            con.Open();
            reader = new MySqlCommand("SELECT *FROM usernum where UserID=96068", con).ExecuteReader();

            byte[] images;
            while (reader.Read())
            {
                byte[] img = (byte[])reader["FaceScan"];
                var memoryStream = new MemoryStream(img);
                var imgs = new Bitmap(Image.FromStream(memoryStream));
                pictureBox2face.Image = imgs;
            }
            con.Close();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            VideoCapture.Stop();
            VideoCapture.Dispose();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = Image.FromFile("NUM.jpg");
        }

        private void Facescan_Load(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));

            try
            {
                VideoCapture = new VideoCapture(0);

                VideoCapture.ImageGrabbed += ProcessFrame;
                VideoCapture.Start();
                //selectpictest();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SplashScreenManager.CloseForm();

            }
        }
        private void trainimage()
        {
            int image = 0;
            double Theresold = 7000;
            List<Mat> cmd = new List<Mat>();
            EigenFaceRecognizer recognier;
            string path = Directory.GetCurrentDirectory() + @"\Imagetrain";
            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            try
            {

                foreach (var i in files)
                {
                    Image<Gray, Byte> trainimages = new Image<Gray, byte>(i);

                    images.Add(trainimages.Mat);
                    personlabel.Add(++image);
                }
                //EigenFaceRecognizer recognizer = new EigenFaceRecognizer();
                recognier = new EigenFaceRecognizer(80, double.PositiveInfinity);
            }
            catch (Exception ex)
            {
                //recognier = new EigenFaceRecognizer(80, double.PositiveInfinity);
                //recognier.Train(images.ToArray(), personlabel.ToArray());

            }
        }

        private void Checkkey(object sender, PreviewKeyDownEventArgs e)
        {

        }
        StudentSource Modeluser;
        public void setmodel(StudentSource source)
        {
            Modeluser = source;
            lbl_user.Text = $"You Are Register User {Modeluser.ID}-{Modeluser.Name}";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VideoCapture.Dispose();
            Facescan model = new Facescan();
            this.Close();
            model.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VideoCapture.Dispose();
            this.Close();
            Facescan.frmuser.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public Facescanregister()
        {
            InitializeComponent();
            //insertdb();
            trainimage();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}