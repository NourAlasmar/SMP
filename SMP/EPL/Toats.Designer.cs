namespace SMP.EPL
{
    partial class Toats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toats));
            this.txt_caption = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_toast = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_caption
            // 
            this.txt_caption.Appearance.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caption.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_caption.Appearance.Options.UseFont = true;
            this.txt_caption.Appearance.Options.UseForeColor = true;
            this.txt_caption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txt_caption.Location = new System.Drawing.Point(124, 3);
            this.txt_caption.Name = "txt_caption";
            this.txt_caption.Size = new System.Drawing.Size(284, 96);
            this.txt_caption.TabIndex = 8;
            this.txt_caption.Text = "تمت اضافة الصنف";
            this.txt_caption.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(481, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 111);
            this.panel1.TabIndex = 1;
            // 
            // pic_toast
            // 
            this.pic_toast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_toast.EditValue = ((object)(resources.GetObject("pic_toast.EditValue")));
            this.pic_toast.Location = new System.Drawing.Point(0, 0);
            this.pic_toast.Name = "pic_toast";
            this.pic_toast.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_toast.Size = new System.Drawing.Size(100, 111);
            this.pic_toast.TabIndex = 0;
            this.pic_toast.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Toats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 111);
            this.Controls.Add(this.txt_caption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_toast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toats";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toats";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_toast.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.LabelControl txt_caption;
        public DevExpress.XtraEditors.PictureEdit pic_toast;
    }
}