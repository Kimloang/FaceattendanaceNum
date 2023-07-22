namespace FaceattendanaceNum
{
    partial class FrmWelcome
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
            pictureBox1 = new PictureBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txt_student = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(405, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Khmer OS Content", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(405, 363);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(172, 41);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "សូមស្វាគម៏និស្សិត:";
            // 
            // txt_student
            // 
            txt_student.Appearance.Font = new Font("Khmer OS Content", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_student.Appearance.Options.UseFont = true;
            txt_student.Location = new Point(585, 363);
            txt_student.Name = "txt_student";
            txt_student.Size = new Size(63, 41);
            txt_student.TabIndex = 2;
            txt_student.Text = "និស្សិត";
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 520);
            Controls.Add(txt_student);
            Controls.Add(labelControl1);
            Controls.Add(pictureBox1);
            Name = "FrmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmWelcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txt_student;
    }
}