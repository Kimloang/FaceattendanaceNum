using DevExpress.XtraCharts.Native;
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
using System.Windows.Forms;

namespace FaceattendanaceNum
{
    public partial class Xtratest : Form
    {
        public Xtratest()
        {
            InitializeComponent();
            testConect();
        }
        private void testConect()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.Server = @"aws.connect.psdb.cloud";
                conn_string.UserID = "tgqyjv5vmegtqoyf18lz";
                conn_string.Password = "pscale_pw_2S12LB9drDh42NwmhLhxB3m8K4yqkPlLqhFUUiyQe3v";
                conn_string.Database = "mydb";
                //nn_string.SslMode(base=)

                using (MySqlConnection conn = new MySqlConnection(conn_string.ToString()))
                {
                    conn.Open();
                  
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error"+ex.Message);
            }

            }
    }
}
