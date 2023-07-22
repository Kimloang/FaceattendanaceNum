using DevExpress.Map.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.SyntaxEditor;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FaceattendanaceNum
{
    public partial class FaceAttendance : DevExpress.XtraEditors.XtraForm
    {
        Mat frame = new Mat();
        VideoCapture myvd;
        CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> BgrImage = null;
        //MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=loang*001;database=face-scan");
        //MySqlCommand cmd = new MySqlCommand();
        //Mat frame = new Mat();

        //CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> Faceresult, gray = null;
        List<Image<Bgr, Byte>> TrainFaces = new List<Image<Bgr, Byte>>();
        List<Image<Gray, Byte>> ImagesTrained = new List<Image<Gray, Byte>>();
        List<Mat> images = new List<Mat>();
        List<int> personlabel = new List<int>();
        List<string> personlabels = new List<string>();
        bool enablesave = false;
        //private Image<Bgr, Byte> cmd;
        public FaceAttendance()
        {
            InitializeComponent();
            //Emgu.CV.Face.Eigen eigenFaceRecognizer = new Emgu.CV.Face.EigenFaceRecognizer(0, 1.1);
            check();
        }
        void check()
        {
            EigenFaceRecognizer cmd = new EigenFaceRecognizer(0, 1.1);
        }
        private void FaceAttendance_Load(object sender, EventArgs e)
        {
            myvd = new VideoCapture(0);
            myvd.ImageGrabbed += ProcessImage;
            myvd.Start();
        }
        
        private void ProcessImage(object? sender, EventArgs e)
        {
            myvd.Read(frame);

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
    }
}