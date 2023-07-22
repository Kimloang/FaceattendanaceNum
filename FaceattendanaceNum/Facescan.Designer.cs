namespace scanface
{
    partial class Facescan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pic_detec = new PictureBox();
            pictureBox1 = new PictureBox();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            pictureBox3 = new PictureBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_detec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 240, 240);
            panel1.Controls.Add(labelControl2);
            panel1.Controls.Add(pic_detec);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 292);
            panel1.Margin = new Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1936, 768);
            panel1.TabIndex = 8;
            panel1.PreviewKeyDown += Checkkey;
            // 
            // pic_detec
            // 
            pic_detec.Location = new Point(55, 155);
            pic_detec.Margin = new Padding(5, 7, 5, 7);
            pic_detec.Name = "pic_detec";
            pic_detec.Size = new Size(263, 261);
            pic_detec.SizeMode = PictureBoxSizeMode.Zoom;
            pic_detec.TabIndex = 2;
            pic_detec.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(599, 7);
            pictureBox1.Margin = new Padding(5, 7, 5, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 733);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.PreviewKeyDown += Checkkey;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.Lime;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(panel1);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Margin = new Padding(5, 7, 5, 7);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1940, 1062);
            panelControl1.TabIndex = 1;
            panelControl1.PreviewKeyDown += Checkkey;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(pictureBox3);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Margin = new Padding(5, 7, 5, 7);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1936, 290);
            panelControl2.TabIndex = 0;
            panelControl2.PreviewKeyDown += Checkkey;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = FaceattendanaceNum.Properties.Resources.NUM;
            pictureBox3.Location = new Point(159, 15);
            pictureBox3.Margin = new Padding(5, 7, 5, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(263, 261);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.PreviewKeyDown += Checkkey;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Khmer OS Content", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(619, 48);
            labelControl1.Margin = new Padding(5, 7, 5, 7);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(349, 49);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "NUM FACE ATTENDANCE";
            labelControl1.PreviewKeyDown += Checkkey;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Khmer OS Content", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.Red;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(54, 435);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(264, 48);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "labelControl2";
            // 
            // Facescan
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1940, 1062);
            Controls.Add(panelControl1);
            Font = new Font("Khmer OS Content", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 7, 5, 7);
            Name = "Facescan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facescan";
            WindowState = FormWindowState.Maximized;
            Load += Facescan_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_detec).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private PictureBox pic_detec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}