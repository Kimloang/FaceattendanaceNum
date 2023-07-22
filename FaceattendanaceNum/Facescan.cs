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
using scanface.Splash;
using MySql.Data.MySqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Threading;
using Emgu.CV.Face;
using DevExpress.Utils;
using scanface.ManageUser;
using Dapper;
using FaceattendanaceNum.Model;
using System.Diagnostics;
using FaceattendanaceNum;
using DevExpress.XtraEditors.Design;

namespace scanface
{
    public partial class Facescan : DevExpress.XtraEditors.XtraForm
    {
        VideoCapture VideoCapture;
        Image<Bgr, Byte> BgrImage = null;
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;database=face-scan;password=loang*001");
        MySqlCommand cmd = new MySqlCommand();
        Mat frame = new Mat();

        CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Gray, Byte> Faceresult, gray = null;
        List<Image<Bgr, Byte>> TrainFaces = new List<Image<Bgr, Byte>>();
        List<Image<Gray, Byte>> ImagesTrained = new List<Image<Gray, Byte>>();
        List<Mat> images = new List<Mat>();
        List<string> personlabel = new List<string>();
        bool enablesave = false;
        //private Image<Bgr, Byte> cmd;
        EigenFaceRecognizer recognier;
        List<int> PersonsLabes = new List<int>();

        public Facescan()
        {
            InitializeComponent();
            //insertdb();



        }
        private void Facescan_Load_1(object sender, EventArgs e)
        {
            trainimage();
            SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));
            //recognier.Train(images.ToArray(), PersonsLabes.ToArray());
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

        bool check = false;
        private async void InsertTodbin(int id)
        {
            var checkifExist = "SELECT *FROM attendance where UserID=@id and Cast(checkin as Date)=@date";
            if (con.State == ConnectionState.Open)
                con.Close();


            if (con.State == ConnectionState.Closed)
                con.Open();
            var execute = await con.QueryAsync<UserModel>(checkifExist, new { id = id, date = DateTime.Now.Date });
            if (execute.ToList().Count > 0) return;

            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Insert Into attendance(UserID,checkin,ClassID) VALUES (@id,@checkin,1) ";
            var param = new
            {
                id = id,
                checkin = DateTime.Now
            };

            if (ConnectionState.Closed == con.State)
                await con.OpenAsync();
            try
            {
                var data = await con.ExecuteAsync(sql, param);
                Debug.WriteLine("Sucess");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error");
            }

        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            VideoCapture.Read(frame);
            //
            BgrImage = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
            Image<Gray, Byte> grayimage = BgrImage.Convert<Gray, Byte>();
            //Mat grayimage = new Mat();
            //CvInvoke.CvtColor(BgrImage, grayimage, ColorConversion.Bgr2Gray);
            //CvInvoke.EqualizeHist(grayimage, grayimage);
            // Rectangle[] face = face_case.DetectMultiScale(grayimage, 1.3, 5, Size.Empty, Size.Empty);
            Rectangle[] facesDetected = face_case.DetectMultiScale(grayimage, 1.3, 10, new Size(50, 50), Size.Empty);
            for (int i = 0; i < facesDetected.Length; i++)
            {
                // Optimizes scale to suppress background noises resulting in better face recognition

                facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
                facesDetected[i].Y += (int)(facesDetected[i].Width * 0.1);
                facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.1);
                facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.2);

                // Final optimization of the current capturing frame image
                Faceresult = BgrImage.Copy(facesDetected[i]).Convert<Gray, Byte>().Resize(100, 100, Inter.Cubic);
                Faceresult._EqualizeHist();
                FaceRecognizer.PredictionResult recog = Recognizer.Predict(Faceresult);
                if (recog.Label != -1  && recog.Distance<2000)
                {
                    BgrImage.Draw(facesDetected[i], new Bgr(Color.MediumSeaGreen), 2);
                    CvInvoke.PutText(BgrImage, personlabel[recog.Label], new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2),
                              FontFace.HersheyComplex, 1.2, new Bgr(Color.Orange).MCvScalar);
                    pictureBox3.Image = images[recog.Label].ToBitmap();
                    var db = (float)recog.Distance;
                    pic_detec.Image = images[recog.Label].ToBitmap();
                    Debug.WriteLine(recog.Label + $"-{personlabel[recog.Label]}-" + db);
                    //labelControl2.Text = $"Cambodia";
                    //InsertTodbin(userid[recog.Label]);
                }
                
                else
                {
                    
                    var db = (float)recog.Distance;
                    Debug.WriteLine(recog.Label + $"-" + db);
                    CvInvoke.Rectangle(BgrImage, facesDetected[i], new Bgr(Color.Green).MCvScalar, 2);
                    pictureBox3.Image = Image.FromFile(@"NUM.jpg");
                }
                
            }

            if (1 == 1)
            {
                /*  if (face.Length > 0)
                  {

                      foreach (var i in face)
                      {

                          CvInvoke.Rectangle(BgrImage, i, new Bgr(Color.Green).MCvScalar, 2);

                          Faceresult = BgrImage.Convert<Bgr, Byte>();
                          Faceresult.ROI = i;

                          i.X += (int)(i.Height * 0.15);
                          //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                          //pictureBox1.Image = Faceresult.ToBitmap();
                          Image<Gray, Byte> grayFaceResult = Faceresult.Convert<Gray, Byte>().Resize(100, 100, Inter.Cubic);
                          CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                          EigenFaceRecognizer.PredictionResult results = recognier.Predict(grayFaceResult);
                          Debug.WriteLine("Label : "+results.Label+"Label Distance"+results.Distance);
                          if (results.Label != -1 )
                          {
                              //pic_detec.Image = images[results.Label].ToBitmap();
                              //MessageBox.Show(results.Distance+"length"+images.ToArray().Length);
                              CvInvoke.PutText(BgrImage, personlabel[results.Label], new Point(i.X - 2, i.Y - 2),
                                  FontFace.HersheyComplex, 1.2, new Bgr(Color.Orange).MCvScalar);
                              CvInvoke.Rectangle(BgrImage, i, new Bgr(Color.Green).MCvScalar, 2);
                              /*
                              FrmWelcome newfrm = new FrmWelcome();
                              newfrm.setImage = images[results.Label];
                              //this.Hide();
                              newfrm.ShowDialog();

                              break;
                          }
                      }
                          enablesave = true;
                */



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
            /*  if (enablesave)
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
                 */
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
                    Faceresult.Resize(200, 200, Inter.Cubic).Save(path + $@"\_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");

                    //insertdb(pictureBox2face.Image);



                    XtraMessageBox.Show("រូបភាពត្រូវបានផ្ទុកទៅកាន់Database", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        /*void selectpictest()
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
        */

        private void btn_stop_Click(object sender, EventArgs e)
        {
            VideoCapture.Stop();
            VideoCapture.Dispose();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = Image.FromFile("NUM.jpg");
        }
        void load()
        {
            SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));

            try
            {
                VideoCapture = new VideoCapture(0);
                recognier.Train(images.ToArray(), PersonsLabes.ToArray());
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
        private void Facescan_Load(object sender, EventArgs e)
        {


        }
        FaceRecognizer Recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 90);
        List<Image<Gray, byte>> TrainingImages = new List<Image<Gray, byte>>();
        List<int> userid = new List<int>();

        private void trainimage()
        {
            int image = 0;
            double Threshold = 2000;

            List<Mat> cmd = new List<Mat>();
            //EigenFaceRecognizer recognier;
            string path = Directory.GetCurrentDirectory() + @"\Imagetrain";
            // string[] files = Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(path, "*.jpeg", SearchOption.AllDirectories);
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = @"SELECT u.UserID id,u.Username Name,fd.Facescan trainimages 
                        FROM   usernum u ,usface fd 
                        WHERE u.UserID=fd.UserID 
                        
                        
                        ";
            /*
            string sql = @"SELECT u.UserID id,u.Username Name,fd.Facescan trainimages 
                        FROM   usernum u ,usface fd 
                        WHERE u.UserID=fd.UserID";
            */
            /*
            string sql = @"SELECT u.UserID id,u.Username Name,u.Facescan trainimages 
                        FROM   usernum u ";
           
            */
            var data = con.Query<UserModel>(sql, "").ToList();

            try
            {

                foreach (var i in data)
                {
                    /*
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(i).Resize(100, 100, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    images.Add(trainedImage.Mat);
                    PersonsLabes.Add(image++);
                    personlabel.Add("face"+i);
                    pictureBox3.Image = trainedImage.Mat.ToBitmap();
                    */

                    byte[] img = i.trainimages;
                    var memoryStream = new MemoryStream(img);
                    var imgs = new Bitmap(Image.FromStream(memoryStream));
                    Image<Gray, byte> trainedImage = imgs.ToImage<Gray, byte>().Resize(100, 100, Inter.Cubic);
                    images.Add(trainedImage.Mat);
                    personlabel.Add(i.Name!);
                    PersonsLabes.Add(image++);
                    pictureBox3.Image = trainedImage.Mat.ToBitmap();
                    userid.Add(i.id);
                    Debug.WriteLine(i.Name);

                    //break;


                }


                // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                //recognier = new EigenFaceRecognizer(image, Threshold);

                Recognizer.Train(images.ToArray(), PersonsLabes.ToArray());




                // recognier = new EigenFaceRecognizer(0, 7000);
                //recognier.Train(images.ToArray(), PersonsLabes.ToArray());

            }
            catch (Exception ex)
            {
                //recognier = new EigenFaceRecognizer(80, double.PositiveInfinity);
                //recognier.Train(images.ToArray(), personlabel.ToArray());

            }
        }
        public static FrmUser frmuser;


        private void labelControl3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Checkkey(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));
                try
                {
                    frmuser = new FrmUser();
                    this.Hide();
                    frmuser.Show();
                    VideoCapture.Dispose();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    SplashScreenManager.CloseForm();
                }

            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {


            SplashScreenManager.ShowForm(typeof(SpalashLodingSchreen));
            try
            {
                frmuser = new FrmUser();
                this.Hide();
                frmuser.Show();
                VideoCapture.Dispose();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }


        }

    }
}