using DevExpress.XtraEditors;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using DevExpress.XtraSplashScreen;

using MySql.Data.MySqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Threading;

using Emgu.CV.Face;
using DevExpress.Utils;

namespace scanface
{
    public partial class Facescans : DevExpress.XtraEditors.XtraForm
    {
        VideoCapture VideoCapture;
        Image<Bgr, Byte> BgrImage = null;
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;database=face-scan");
        MySqlCommand cmd = new MySqlCommand();
        Mat frame = new Mat();
        EigenFaceRecognizer recognier;

        CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> Faceresult, gray = null;
        List<Image<Bgr, Byte>> TrainFaces = new List<Image<Bgr, Byte>>();
        List<Image<Gray, Byte>> ImagesTrained = new List<Image<Gray, Byte>>();
        List<Mat> images = new List<Mat>();
        List<int> personlabel = new List<int>();
        List<string> personame = new List<string>();
        bool enablesave = false;
        //private Image<Bgr, Byte> cmd;

       
        bool check=false;
        private void Facescan_Load(object sender, EventArgs e)
        {
            try
            {/*
                VideoCapture = new VideoCapture(0);

                VideoCapture.ImageGrabbed += ProcessFrame;
                VideoCapture.Start();
                //selectpictest();
            */
             }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        private  void ProcessFrame(object sender, EventArgs e)
        {
            VideoCapture.Read(frame);

            BgrImage = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
            Mat grayimage = new Mat();
            CvInvoke.CvtColor(BgrImage, grayimage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayimage, grayimage);
            //Rectangle[] face = face_case.DetectMultiScale(grayimage, 3, 5, Size.Empty, Size.Empty);
            Rectangle[] face = face_case.DetectMultiScale(grayimage, 1.2, 10, Size.Empty, Size.Empty);
            if (face.Length > 0)
            {

                foreach (var i in face)
                {
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

                        /* Task.Factory.StartNew(() =>
                         {
                             for (int j = 0; j < 10; j++)
                             {
                                 //resize the image then saving it
                                 Faceresult.Resize(200, 200, Inter.Cubic).Save(path + $@"\{textBox1.Text}_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                 Thread.Sleep(1000);
                             }
                         });
                        */

                        Image<Gray,byte> grayface = Faceresult.Convert<Gray,Byte>().Resize(200,200,Inter.Cubic);
                        var result = recognier.Predict(grayface);
                        if (result.Label > 0)
                        {
                            //CvInvoke(ProcessFrame, personlabel[result.Label],new)
                        }
                    }
                    enablesave = true;



                }
            }
            else
            {
                enablesave = false;
            }
            pictureBox1.Image = BgrImage.ToBitmap();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (enablesave)
            {
                pictureBox2face.Image = Faceresult.ToBitmap();
                pictureBox2face.Visible = true;
                labelControl2.Visible = true;
                btn_saved.Visible=true;
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
                    string sql = "update  usernum set FaceScan=@img where UserID=96069";
                    con.Open();
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@img", data);
                    
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
            //SplashScreenManager.ShowForm(typeof (SpalashLodingSchreen));
            try
            {
                if (enablesave)
                {
                    
                    string path = System.IO.Directory.GetCurrentDirectory() + @"\Imagetrain";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    Faceresult.Resize(200, 200, Inter.Cubic).Save(path + $@"\_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                    
                    insertdb(pictureBox2face.Image);



                    XtraMessageBox.Show("រូបភាពត្រូវបានផ្ទុកទៅកាន់Database","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }catch(Exception ex)
            {

            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
        
      
      

        private void btn_stop_Click(object sender, EventArgs e)
        {
            VideoCapture.Stop();
            VideoCapture.Dispose();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = Image.FromFile("NUM.jpg");
        }

       
        private void trainimage()
        {
            int image = 0;
            double Theresold = 7000;
            List<Mat> cmd = new List<Mat>();
            //EigenFaceRecognizer recognier;
            string path = Directory.GetCurrentDirectory() + @"\Imagetrain";
            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            try {
               
                foreach (var i in files)
                {
                    Image<Gray, Byte> trainimages = new Image<Gray, byte>(i);
                    pictureBox1.Image = trainimages.ToBitmap();
                    break;
                    images.Add(trainimages.Mat);
                    personlabel.Add(++image);
                }
                //EigenFaceRecognizer recognizer = new EigenFaceRecognizer();
                // recognier = new EigenFaceRecognizer(image, Theresold);
                 //recognier.Train(images.ToArray(),personlabel.ToArray());
                
            }
            catch(Exception ex)
            {
                //recognier = new EigenFaceRecognizer(80, double.PositiveInfinity);
                //recognier.Train(images.ToArray(), personlabel.ToArray());
                XtraMessageBox.Show("Not ");
            }
        }

        private void Checkkey(object sender, PreviewKeyDownEventArgs e)
        {
           /* if(e.KeyCode == Keys.F11)
            {
                FrmStudent cmd = new FrmStudent();
                cmd.Show();
            }
           */
        }

        public Facescans()
        {
            InitializeComponent();
            //insertdb();
            trainimage();


        }
    }
}