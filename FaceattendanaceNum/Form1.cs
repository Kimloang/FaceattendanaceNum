using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace scanface
{
    public partial class Form1 : Form
    {
        VideoCapture VideoCapture;
        Image<Bgr, Byte> BgrImage = null;
        
        Mat frame = new Mat();
        
        CascadeClassifier face_case = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> Faceresult,gray = null;
        List<Image<Bgr, Byte>> TrainFaces = new List<Image<Bgr, Byte>>();
        List<int> personlabel = new List<int>();
        bool enablesave = false;
        private Image<Bgr, Byte> cmd;
        public Form1()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoCapture = new VideoCapture(0);
           
            VideoCapture.ImageGrabbed += ProcessFrame;
            VideoCapture.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        
        }
        
        private void ProcessFrame(object sender, EventArgs e)
        {
            VideoCapture.Retrieve(frame, 1);
            BgrImage = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
            
            
            Mat grayimage = new Mat();
            CvInvoke.CvtColor(BgrImage, grayimage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayimage, grayimage);
            Rectangle[] face = face_case.DetectMultiScale(grayimage, 3, 10, Size.Empty, Size.Empty);
           
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

                        Task.Factory.StartNew(() =>
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                //resize the image then saving it
                                Faceresult.Resize(200, 200, Inter.Cubic).Save(path + $@"\{textBox1.Text}_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                Thread.Sleep(1000);
                            }
                        });

                    }
                    enablesave = false;

                }
            }

            pictureBox1.Image = BgrImage.ToBitmap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enablesave = true;
        }
    }

       
        
    
}
