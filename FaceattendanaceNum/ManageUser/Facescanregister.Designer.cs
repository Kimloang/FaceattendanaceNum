namespace scanface
{
    partial class Facescanregister
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facescanregister));
            panel1 = new Panel();
            pictureBox2face = new PictureBox();
            btn_saved = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new PictureBox();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            lbl_user = new DevExpress.XtraEditors.LabelControl();
            pictureBox3 = new PictureBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2face).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 240, 240);
            panel1.Controls.Add(pictureBox2face);
            panel1.Controls.Add(btn_saved);
            panel1.Controls.Add(labelControl2);
            panel1.Controls.Add(simpleButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 172);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 551);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            panel1.PreviewKeyDown += Checkkey;
            // 
            // pictureBox2face
            // 
            pictureBox2face.Location = new Point(740, 61);
            pictureBox2face.Name = "pictureBox2face";
            pictureBox2face.Size = new Size(287, 289);
            pictureBox2face.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2face.TabIndex = 11;
            pictureBox2face.TabStop = false;
            pictureBox2face.PreviewKeyDown += Checkkey;
            // 
            // btn_saved
            // 
            btn_saved.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_saved.ImageOptions.SvgImage");
            btn_saved.Location = new Point(916, 407);
            btn_saved.Margin = new Padding(3, 4, 3, 4);
            btn_saved.Name = "btn_saved";
            btn_saved.Size = new Size(131, 49);
            btn_saved.TabIndex = 10;
            btn_saved.Text = "Save Images";
            btn_saved.Visible = false;
            btn_saved.Click += btn_saved_Click;
            btn_saved.PreviewKeyDown += Checkkey;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(740, 19);
            labelControl2.Margin = new Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(81, 16);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "Face Detected";
            labelControl2.Visible = false;
            labelControl2.PreviewKeyDown += Checkkey;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(740, 407);
            simpleButton1.Margin = new Padding(3, 4, 3, 4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(170, 49);
            simpleButton1.TabIndex = 5;
            simpleButton1.Text = "Deteced only Face";
            simpleButton1.Click += simpleButton1_Click;
            simpleButton1.PreviewKeyDown += Checkkey;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(120, 53);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.PreviewKeyDown += Checkkey;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.Lime;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(panel1);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 30);
            panelControl1.Margin = new Padding(3, 4, 3, 4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1327, 725);
            panelControl1.TabIndex = 1;
            panelControl1.PreviewKeyDown += Checkkey;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(lbl_user);
            panelControl2.Controls.Add(pictureBox3);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Margin = new Padding(3, 4, 3, 4);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1323, 170);
            panelControl2.TabIndex = 0;
            panelControl2.PreviewKeyDown += Checkkey;
            // 
            // lbl_user
            // 
            lbl_user.Appearance.Font = new Font("Khmer OS Content", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_user.Appearance.Options.UseFont = true;
            lbl_user.Location = new Point(381, 98);
            lbl_user.Margin = new Padding(3, 4, 3, 4);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(110, 49);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "Register";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(98, 9);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(162, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.PreviewKeyDown += Checkkey;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Khmer OS Content", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(381, 28);
            labelControl1.Margin = new Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(349, 49);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "NUM FACE ATTENDANCE";
            labelControl1.PreviewKeyDown += Checkkey;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem2, barButtonItem3 });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 3;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Back To Facescan";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Back to Admin";
            barButtonItem2.Id = 1;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Exit";
            barButtonItem3.Id = 2;
            barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1327, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 755);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1327, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 725);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1327, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 725);
            // 
            // Facescanregister
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 775);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Khmer OS Content", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Facescanregister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facescan";
            Load += Facescan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2face).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_saved;
        private System.Windows.Forms.PictureBox pictureBox2face;
        private DevExpress.XtraEditors.LabelControl lbl_user;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}