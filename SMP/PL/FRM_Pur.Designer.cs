namespace SMP.PL
{
    partial class FRM_Pur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Pur));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tbuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tsell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edit_search = new DevExpress.XtraEditors.TextEdit();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 720);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_Pur);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1030, 620);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_Tbuy,
            this.colPur_Tsell,
            this.colPur_TRev});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_Name
            // 
            this.colPur_Name.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Name.AppearanceCell.Options.UseFont = true;
            this.colPur_Name.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPur_Name.AppearanceHeader.Options.UseFont = true;
            this.colPur_Name.Caption = "اسم المادة";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.Visible = true;
            this.colPur_Name.VisibleIndex = 0;
            // 
            // colPur_Type
            // 
            this.colPur_Type.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Type.AppearanceCell.Options.UseFont = true;
            this.colPur_Type.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Type.AppearanceHeader.Options.UseFont = true;
            this.colPur_Type.Caption = "النوع";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.Visible = true;
            this.colPur_Type.VisibleIndex = 1;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Cat.AppearanceCell.Options.UseFont = true;
            this.colPur_Cat.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Cat.AppearanceHeader.Options.UseFont = true;
            this.colPur_Cat.Caption = "الصنف";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.Visible = true;
            this.colPur_Cat.VisibleIndex = 2;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Supp.AppearanceCell.Options.UseFont = true;
            this.colPur_Supp.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Supp.AppearanceHeader.Options.UseFont = true;
            this.colPur_Supp.Caption = "المورد";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.Visible = true;
            this.colPur_Supp.VisibleIndex = 3;
            // 
            // colPur_Det
            // 
            this.colPur_Det.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Det.AppearanceCell.Options.UseFont = true;
            this.colPur_Det.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Det.AppearanceHeader.Options.UseFont = true;
            this.colPur_Det.Caption = "تفاصيل";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.Visible = true;
            this.colPur_Det.VisibleIndex = 4;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Buy.AppearanceCell.Options.UseFont = true;
            this.colPur_Buy.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Buy.AppearanceHeader.Options.UseFont = true;
            this.colPur_Buy.Caption = "الشراء";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.Visible = true;
            this.colPur_Buy.VisibleIndex = 5;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Sell.AppearanceCell.Options.UseFont = true;
            this.colPur_Sell.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Sell.AppearanceHeader.Options.UseFont = true;
            this.colPur_Sell.Caption = "البيع";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.Visible = true;
            this.colPur_Sell.VisibleIndex = 6;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Qt.AppearanceCell.Options.UseFont = true;
            this.colPur_Qt.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Qt.AppearanceHeader.Options.UseFont = true;
            this.colPur_Qt.Caption = "الكمية";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.Visible = true;
            this.colPur_Qt.VisibleIndex = 7;
            // 
            // colPur_Tbuy
            // 
            this.colPur_Tbuy.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Tbuy.AppearanceCell.Options.UseFont = true;
            this.colPur_Tbuy.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Tbuy.AppearanceHeader.Options.UseFont = true;
            this.colPur_Tbuy.Caption = "البيع الكلي";
            this.colPur_Tbuy.FieldName = "Pur_Tbuy";
            this.colPur_Tbuy.Name = "colPur_Tbuy";
            this.colPur_Tbuy.Visible = true;
            this.colPur_Tbuy.VisibleIndex = 8;
            // 
            // colPur_Tsell
            // 
            this.colPur_Tsell.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F);
            this.colPur_Tsell.AppearanceCell.Options.UseFont = true;
            this.colPur_Tsell.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_Tsell.AppearanceHeader.Options.UseFont = true;
            this.colPur_Tsell.Caption = "الشراء الكلي";
            this.colPur_Tsell.FieldName = "Pur_Tsell";
            this.colPur_Tsell.Name = "colPur_Tsell";
            this.colPur_Tsell.Visible = true;
            this.colPur_Tsell.VisibleIndex = 9;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.AppearanceCell.Font = new System.Drawing.Font("LBC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPur_TRev.AppearanceCell.Options.UseFont = true;
            this.colPur_TRev.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.75F);
            this.colPur_TRev.AppearanceHeader.Options.UseFont = true;
            this.colPur_TRev.Caption = "الارباح";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.Visible = true;
            this.colPur_TRev.VisibleIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.edit_search);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(946, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(59, 56);
            this.btn_search.TabIndex = 6;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edit_search
            // 
            this.edit_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edit_search.Location = new System.Drawing.Point(501, 34);
            this.edit_search.Name = "edit_search";
            this.edit_search.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edit_search.Properties.Appearance.Options.UseFont = true;
            this.edit_search.Size = new System.Drawing.Size(439, 40);
            this.edit_search.TabIndex = 5;
            this.edit_search.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(251, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 63);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(131, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 63);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(11, 21);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 63);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(371, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 63);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_Pur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Pur";
            this.Text = "pm_cat";
            this.pn_cat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edit_search.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.TextEdit edit_search;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Supp;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Buy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Sell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tbuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tsell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TRev;
    }
}