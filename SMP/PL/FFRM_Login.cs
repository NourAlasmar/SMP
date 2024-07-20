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
    public partial class FFRM_Login : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_USERS tb_users = new TB_USERS();
        Main main = new Main();

        public FFRM_Login()
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
                { // تسجيل الدخول

                    tb_users = db.TB_USERS.Where(x => x.User_Name == edit_name.Text && x.User_Pass == edit_pass.Text).FirstOrDefault();
                    if(tb_users != null)
                    {
                        tb_users.User_State = "True";
                        db.Entry(tb_users).State=System.Data.Entity.EntityState.Modified;
                        main.lb_username22.Text = tb_users.User_Name;
                        main.lb_roll22.Text = tb_users.User_Roll;
                        main.Enabled = true;
                        main.Show();
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Faild Login");
                    }


                }
            }
        }



        private void FFRM_Users_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
