namespace scanface.ManageUser
{
    partial class FrmStudent
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.studentSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroups = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMajorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Registerimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentSourceBindingSource
            // 
            this.studentSourceBindingSource.DataSource = typeof(scanface.ManageUser.StudentSource);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.studentSourceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1303, 762);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colGeneration,
            this.colGroups,
            this.colsex,
            this.colMajorName,
            this.colimage,
            this.Registerimage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 181;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 181;
            // 
            // colGeneration
            // 
            this.colGeneration.FieldName = "Generation";
            this.colGeneration.MinWidth = 25;
            this.colGeneration.Name = "colGeneration";
            this.colGeneration.Visible = true;
            this.colGeneration.VisibleIndex = 2;
            this.colGeneration.Width = 181;
            // 
            // colGroups
            // 
            this.colGroups.FieldName = "Groups";
            this.colGroups.MinWidth = 25;
            this.colGroups.Name = "colGroups";
            this.colGroups.Visible = true;
            this.colGroups.VisibleIndex = 3;
            this.colGroups.Width = 181;
            // 
            // colsex
            // 
            this.colsex.FieldName = "sex";
            this.colsex.MinWidth = 25;
            this.colsex.Name = "colsex";
            this.colsex.Visible = true;
            this.colsex.VisibleIndex = 4;
            this.colsex.Width = 181;
            // 
            // colMajorName
            // 
            this.colMajorName.FieldName = "MajorName";
            this.colMajorName.MinWidth = 25;
            this.colMajorName.Name = "colMajorName";
            this.colMajorName.Visible = true;
            this.colMajorName.VisibleIndex = 5;
            this.colMajorName.Width = 181;
            // 
            // colimage
            // 
            this.colimage.AppearanceCell.Font = new System.Drawing.Font("Khmer OS Content", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colimage.AppearanceCell.Options.UseFont = true;
            this.colimage.FieldName = "image";
            this.colimage.MinWidth = 200;
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 6;
            this.colimage.Width = 200;
            // 
            // Registerimage
            // 
            this.Registerimage.Caption = "Scan Face";
            this.Registerimage.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Registerimage.MinWidth = 25;
            this.Registerimage.Name = "Registerimage";
            this.Registerimage.Visible = true;
            this.Registerimage.VisibleIndex = 7;
            this.Registerimage.Width = 94;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 762);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            ((System.ComponentModel.ISupportInitialize)(this.studentSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentSourceBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneration;
        private DevExpress.XtraGrid.Columns.GridColumn colGroups;
        private DevExpress.XtraGrid.Columns.GridColumn colsex;
        private DevExpress.XtraGrid.Columns.GridColumn colMajorName;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private DevExpress.XtraGrid.Columns.GridColumn Registerimage;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}