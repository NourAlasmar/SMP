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
    public partial class FFRM_Cust_ADD : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_Cust tb_cust = new TB_Cust();
        BL.Methods methods = new BL.Methods();

        public int id;

        public FFRM_Cust_ADD()
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
                dialog.txt_caption.Text = "اسم العميل مطلوب";
                dialog.Show();
                
            }
            else
            {
                if(id == 0) //ADD
                {
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    tb_cust.Cust_Name= edit_name.Text;
                    tb_cust.Cust_Phone = edit_phone.Text;
                    tb_cust.Cust_Email = edit_email.Text;
                    tb_cust.Cust_image = methods.convert_byte();
                    db.TB_Cust.Add(tb_cust);
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم اضافة عميل جديد";
                    tosat.Show();
                    this.Close();
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_cust.ID = id;
                    tb_cust.Cust_Name = edit_name.Text;
                    tb_cust.Cust_Phone = edit_phone.Text;
                    tb_cust.Cust_Email = edit_email.Text;
                    tb_cust.Cust_image = methods.convert_byte();
                    db.Entry(tb_cust).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم تعديل العميل";
                    tosat.Show();
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

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }

        private void FFRM_Cust_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
