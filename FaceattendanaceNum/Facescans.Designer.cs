namespace scanface
{
    partial class Facescans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facescans));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2face = new System.Windows.Forms.PictureBox();
            this.btn_saved = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_stop = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox2face);
            this.panel1.Controls.Add(this.btn_saved);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 888);
            this.panel1.TabIndex = 8;
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // pictureBox2face
            // 
            this.pictureBox2face.Location = new System.Drawing.Point(970, 80);
            this.pictureBox2face.Name = "pictureBox2face";
            this.pictureBox2face.Size = new System.Drawing.Size(287, 289);
            this.pictureBox2face.TabIndex = 11;
            this.pictureBox2face.TabStop = false;
            this.pictureBox2face.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // btn_saved
            // 
            this.btn_saved.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_saved.ImageOptions.SvgImage")));
            this.btn_saved.Location = new System.Drawing.Point(1130, 376);
            this.btn_saved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_saved.Name = "btn_saved";
            this.btn_saved.Size = new System.Drawing.Size(127, 38);
            this.btn_saved.TabIndex = 10;
            this.btn_saved.Text = "Save Images";
            this.btn_saved.Visible = false;
            this.btn_saved.Click += new System.EventHandler(this.btn_saved_Click);
            this.btn_saved.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(970, 38);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Face Detected";
            this.labelControl2.Visible = false;
            this.labelControl2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // btn_stop
            // 
            this.btn_stop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.ImageOptions.Image")));
            this.btn_stop.Location = new System.Drawing.Point(1095, 474);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(198, 49);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Stop Deteted";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            this.btn_stop.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1095, 538);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(200, 49);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Deteced only Face";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            this.simpleButton1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 738);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Lime;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1327, 1062);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureBox3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1323, 170);
            this.panelControl2.TabIndex = 0;
            this.panelControl2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(98, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Khmer OS Content", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(381, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(349, 49);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "NUM FACE ATTENDANCE";
            this.labelControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Checkkey);
            // 
            // Facescan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 1062);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Facescan";
            this.Text = "Facescan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facescan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_stop;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_saved;
        private System.Windows.Forms.PictureBox pictureBox2face;
    }
}