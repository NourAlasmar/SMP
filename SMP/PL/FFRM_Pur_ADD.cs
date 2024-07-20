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
    public partial class FFRM_Pur_ADD : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        //TB_Supp tb_supp = new TB_Supp();
        TB_Pur tb_pur = new TB_Pur();
        BL.Methods methods = new BL.Methods();
        double buy, sell, qt, tbuy, tsell, trev;

        public int id;

        public FFRM_Pur_ADD()
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
                    tb_pur.Pur_Name = edit_name.Text;
                    tb_pur.Pur_Type = edit_type.Text;
                    tb_pur.Pur_Cat = edit_cat.Text;
                    tb_pur.Pur_Supp=edit_supp.Text;
                    tb_pur.Pur_Det=edit_det.Text;
                    tb_pur.Pur_Buy =Convert.ToDouble(edit_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edit_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edit_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edit_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edit_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edit_trev.Text);
                    db.TB_Pur.Add(tb_pur);
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم اجراء عملية الشراء";
                    tosat.Show();
                    this.Close();
                }
                else
                {
                    tb_pur.ID = id;
                    tb_pur.Pur_Name = edit_name.Text;
                    tb_pur.Pur_Type = edit_type.Text;
                    tb_pur.Pur_Cat = edit_cat.Text;
                    tb_pur.Pur_Supp = edit_supp.Text;
                    tb_pur.Pur_Det = edit_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edit_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edit_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edit_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edit_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edit_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edit_trev.Text);
                    db.Entry(tb_pur).State =System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    tosat.txt_caption.Text = "تم تعديل عملية الشراء";
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

        private void FFRM_Pur_ADD_Load(object sender, EventArgs e)
        {
            edit_cat.DataSource = db.TB_CAT.Select(x => x.CAT_NAME).ToList();
            edit_supp.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();
        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            PL.FFRM_CAT_ADD frm_add = new PL.FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            PL.FFRM_SUPP_ADD frm_add = new PL.FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
            frm_add.Show();
        }

        private void pro_cal()
        {
            sell=Convert.ToDouble(edit_sell.Text);
            buy = Convert.ToDouble(edit_buy.Text);
            qt = Convert.ToDouble(edit_qt.Text);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            edit_tsell.Text=tsell.ToString();
            edit_tbuy.Text=tbuy.ToString();
            edit_trev.Text=trev.ToString();

        }
    }
}
