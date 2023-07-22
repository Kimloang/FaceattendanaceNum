using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;

namespace scanface.ManageUser
{
    public partial class FrmStudent : DevExpress.XtraEditors.XtraForm
    {
        private UserServices userservice = new UserServices();
        public FrmStudent()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {

            var data = userservice.Getall();
            gridView1.GridControl.DataSource = data;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var i = gridView1.FocusedRowHandle;
            if (i < 0) return;
            var model = gridView1.GetRow(i) as StudentSource;
            Facescanregister register = new Facescanregister();

           
            register.setmodel(model);
            register.Show();
            Facescan.frmuser.Hide();


        }
    }
}