using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scanface.ManageUser
{
    public partial class FrmUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmUser()
        {
            InitializeComponent();
            display();
        }
        void display()
        {
            FrmStudent stu = new FrmStudent();
            stu.MdiParent = this;
            stu.Show();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmStudent stu = new FrmStudent();
            stu.MdiParent = this;
            stu.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facescan scan = new Facescan();
            this.Hide();
            scan.Show();
        }
    }
}