using SMP.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SMP
{
    public partial class Main : Form
    {
        PL.pn_home frm_home = new PL.pn_home();
        PL.pm_cat frm_cat = new PL.pm_cat();
        PL.FRM_SUPP frm_supp = new PL.FRM_SUPP();
        PL.FRM_Pur frm_pur = new PL.FRM_Pur();
        PL.FRM_Cust frm_cust = new PL.FRM_Cust();
        PL.FRM_SELL frm_sell = new PL.FRM_SELL();
        PL.FRM_Report frm_report = new PL.FRM_Report();
        PL.FRM_Users frm_users = new PL.FRM_Users();
        TB_USERS tb_users = new TB_USERS();
        DB_SMEntities1 db =new DB_SMEntities1();
        public Main()
        {
            InitializeComponent();
        }

        //load home page
        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home1);
            if (lb_roll22.Text == "Admin")
            {
                btn_users.Enabled = true;
            }
            else
            {
                btn_users.Enabled = false;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
        //close App
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 200;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 246;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home1);
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);

            db = new DB_SMEntities1();
            lb_titlepage.Text = "الاصناف";
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
        }


        //Load SUPP
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMEntities1();
            lb_titlepage.Text = "الموردين";
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMEntities1();
            lb_titlepage.Text = "المشتريات";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cust.pn_cat);
            db = new DB_SMEntities1();
            lb_titlepage.Text = "العملاء";
        }

        // Sell
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_cat);
            db = new DB_SMEntities1();
            lb_titlepage.Text = "المشتريات";
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_cat);
            lb_titlepage.Text = "التقارير";
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_users.pn_cat);
            lb_titlepage.Text = "المستخدمين";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            PL.FFRM_Login ffrm_login = new PL.FFRM_Login();
            tb_users = db.TB_USERS.Where(x => x.User_State =="True").FirstOrDefault();
            //tb_users.User_State = "False";
            //db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //MessageBox.Show("Faild Login");
            this.Enabled = false;
            ffrm_login.Show();
            this.Hide();
        }

        private void pn_topbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
