namespace SMP.PL
{
    partial class FFRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_CAT_ADD));
            this.lb_titlepage = new DevExpress.XtraEditors.LabelControl();
            this.edit_name = new DevExpress.XtraEditors.TextEdit();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.edit_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Appearance.Options.UseFont = true;
            this.lb_titlepage.Appearance.Options.UseForeColor = true;
            this.lb_titlepage.Location = new System.Drawing.Point(256, 53);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(120, 35);
            this.lb_titlepage.TabIndex = 7;
            this.lb_titlepage.Text = "اسم الصنف";
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(97, 111);
            this.edit_name.Name = "edit_name";
            this.edit_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edit_name.Properties.Appearance.Options.UseFont = true;
            this.edit_name.Size = new System.Drawing.Size(439, 40);
            this.edit_name.TabIndex = 8;
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(173, 188);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(297, 235);
            this.pic_cover.TabIndex = 9;
            this.pic_cover.EditValueChanged += new System.EventHandler(this.pic_cover_EditValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(238, 472);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 63);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "إضافة الصنف";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FFRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 603);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.lb_titlepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FFRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFRM_CAT_ADD";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.edit_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lb_titlepage;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edit_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
    }
}