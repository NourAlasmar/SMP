using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.EPL;

namespace SMP.PL
{
    public partial class FFRM_CAT_ADD : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        PL.pm_cat frm_cat = new PL.pm_cat();

        public int id;

        public FFRM_CAT_ADD()
        {
            InitializeComponent();
        }

        // Add Or Edit Item
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toats tosat = new Toats();
            Dialog dialog = new Dialog();

            if (edit_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
                
            }
            else
            {
                if(id == 0) //ADD
                {
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_NAME = edit_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم اضافة الصنف جديد";
                    tosat.Show();
                    db = new DB_SMEntities1();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_NAME = edit_name.Text;
                    tb_cat.ID= id;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم تعديل الصنف ";
                    tosat.Show();
                    db = new DB_SMEntities1();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
