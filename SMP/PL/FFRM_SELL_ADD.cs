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
    public partial class FFRM_SELL_ADD : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        //TB_Supp tb_supp = new TB_Supp();
        TB_Pur tb_pur = new TB_Pur();
        TB_Supp tb_sup = new TB_Supp();
        TB_Sell tb_sell = new TB_Sell();
        BL.Methods methods = new BL.Methods();
        double qtp, qtn, qtr; //Previos , New , الناتجة من عملية البيع

        public int id;

        public FFRM_SELL_ADD()
        {
            InitializeComponent();
        }

        // Add Or Edit Item
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toats tosat = new Toats();
            Dialog dialog = new Dialog();

            qtp=Convert.ToDouble(txt_qt.Text);
            qtn = Convert.ToDouble(edit_qt.Text);
            qtr = qtp - qtn;


            if (edit_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المادة مطلوب";
                dialog.Show();
            }
            else
            {
                // Add

                if(id == 0) //ADD
                {
                    if(qtr >=0)
                    {
                        tb_sell.Sell_Name = edit_name.Text;
                        tb_sell.Sell_Cus = edit_cus.Text;
                        tb_sell.Sell_Price = Convert.ToDouble(edit_sell.Text);
                        tb_sell.Sell_Qut = Convert.ToDouble(edit_qt.Text);
                        tb_sell.Sell_TPrice = (Convert.ToDouble(edit_qt.Text)) * Convert.ToDouble(edit_sell.Text);
                        tb_sell.Sell_Date=DateTime.Now;
                        db.TB_Sell.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                        db.Entry(tb_pur).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        dialog.txt_caption.Text = "تم اجراء عملية الشراء";
                        dialog.Show();
                        this.Close();
                    }
                    else
                    {
                        Label1.Visible = true;
                    }
                    
                }
                else
                {
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

        private void edit_buy_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edit_sell_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edit_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void edit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_Pur.Where(X => X.Pur_Name == edit_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
        }

        private void txt_tbuy_Click(object sender, EventArgs e)
        {

        }

        private void txt_qt_Click(object sender, EventArgs e)
        {

        }

        private void FFRM_Pur_ADD_Load(object sender, EventArgs e)
        {
            var rs1 =db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_Cust.Select(X=> X.Cust_Name).ToList();
            edit_name.DataSource = rs1;
            edit_cus.DataSource = rs2;

            //AutoComplete
            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(rs1.ToArray());
            ACSC2.AddRange(rs2.ToArray());
            edit_name.AutoCompleteCustomSource = ACSC1;
            edit_cus.AutoCompleteCustomSource= ACSC2;


        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            PL.FFRM_Pur_ADD frm_add = new PL.FFRM_Pur_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            PL.FFRM_Cust_ADD frm_add = new PL.FFRM_Cust_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void pro_cal()
        {


        }
    }
}
