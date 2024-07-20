﻿using System;

namespace SMP.PL
{
    partial class FFRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_Login));
            this.edit_name = new DevExpress.XtraEditors.TextEdit();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.edit_pass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_titlepage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edit_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(31, 345);
            this.edit_name.Name = "edit_name";
            this.edit_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edit_name.Properties.Appearance.Options.UseFont = true;
            this.edit_name.Size = new System.Drawing.Size(280, 40);
            this.edit_name.TabIndex = 8;
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(149, 91);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(208, 194);
            this.pic_cover.TabIndex = 9;
            this.pic_cover.EditValueChanged += new System.EventHandler(this.pic_cover_EditValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(12, 519);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(498, 63);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "تسجيل الدخول";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // edit_pass
            // 
            this.edit_pass.Location = new System.Drawing.Point(31, 422);
            this.edit_pass.Name = "edit_pass";
            this.edit_pass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edit_pass.Properties.Appearance.Options.UseFont = true;
            this.edit_pass.Size = new System.Drawing.Size(280, 40);
            this.edit_pass.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(380, 424);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 35);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "كلمة المرور";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(184, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(153, 35);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "تسجيل الدخول";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(434, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 35);
            this.labelControl4.TabIndex = 20;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Appearance.Options.UseFont = true;
            this.lb_titlepage.Appearance.Options.UseForeColor = true;
            this.lb_titlepage.Location = new System.Drawing.Point(337, 347);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(162, 35);
            this.lb_titlepage.TabIndex = 7;
            this.lb_titlepage.Text = "اسم المستخدم";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // FFRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 594);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.edit_pass);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.lb_titlepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FFRM_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFRM_Users_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edit_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_pass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edit_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public DevExpress.XtraEditors.TextEdit edit_pass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_titlepage;
    }
}