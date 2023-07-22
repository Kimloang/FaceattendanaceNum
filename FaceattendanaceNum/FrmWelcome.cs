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

namespace FaceattendanaceNum
{
    public partial class FrmWelcome : DevExpress.XtraEditors.XtraForm
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }
        public Mat setImage { get => setImage; set { pictureBox1.Image = value.ToBitmap(); } }
    }
}