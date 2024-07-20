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
    public partial class FFRM_Users_ADD : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_USERS tb_users = new TB_USERS();
        BL.Methods methods = new BL.Methods();

        public int id;

        public FFRM_Users_ADD()
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
                dialog.txt_caption.Text = "اسم المستخدم مطلوب";
                dialog.Show();
                
            }
            else
            {
                if(id == 0) //ADD
                {
                    tb_users.User_Name = edit_name.Text;
                    tb_users.User_Pass = edit_pass.Text;
                    tb_users.User_Roll = edit_roll.Text;
                    tb_users.User_State = "False";
                    db.TB_USERS.Add(tb_users);
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم اضافة مستخدم جديد";
                    tosat.Show();
                    this.Close();
                }
                else
                { //Edit
                    tb_users.ID = id;
                    tb_users.User_Name = edit_name.Text;
                    tb_users.User_Pass = edit_pass.Text;
                    tb_users.User_Roll = edit_roll.Text;
                    tb_users.User_State = "False";
                    db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم تعديل المستخدم الحالي";
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

        private void FFRM_Users_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
