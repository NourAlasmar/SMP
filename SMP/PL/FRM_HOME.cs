using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class pn_home : Form

    {
        DB_SMEntities1 db=new DB_SMEntities1();
        public pn_home()
        {
            InitializeComponent();
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text=list_cat.Count.ToString();

            List<TB_Supp> list_supp = db.TB_Supp.ToList();
            lb_sup.Text = list_supp.Count.ToString();

            List<TB_Sell> list_sell = db.TB_Sell.ToList();
            lb_sell.Text = list_sell.Count.ToString();

            List<TB_Cust> list_cust = db.TB_Cust.ToList();
            lb_cust.Text = list_cust.Count.ToString();

            List<TB_Pur> list_Pur = db.TB_Pur.ToList();
            lb_pur.Text = list_Pur.Count.ToString();


        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            PL.FFRM_CAT_ADD frm_add = new PL.FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            PL.FFRM_SELL_ADD frm_add = new PL.FFRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            PL.FFRM_SUPP_ADD frm_add = new PL.FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            PL.FFRM_Pur_ADD frm_add = new PL.FFRM_Pur_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            PL.FFRM_Cust_ADD frm_add = new PL.FFRM_Cust_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_sell_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
