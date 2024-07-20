using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EPL;

namespace SMP.PL
{
    public partial class FRM_Pur : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_Supp tb_supp = new TB_Supp();
        TB_Pur tb_pur = new TB_Pur();
        int id;
        BL.Methods methods = new BL.Methods();

        public FRM_Pur()
        {
            InitializeComponent();
            SMP.DB_SMEntities1 dbContext = new SMP.DB_SMEntities1();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Pur.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Pur.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        //ADD
        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FFRM_Pur_ADD frm_add = new PL.FFRM_Pur_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        //Update
        private void btn_update_Click(object sender, EventArgs e)
        {
            
            update_data();

        }

        //delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toats tosat = new Toats();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {

                    var result = MessageBox.Show("هل انت متاكد من هذه العملية؟", "عملية حذف", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_pur).State = EntityState.Deleted;
                        db.SaveChanges();
                        update_data();
                        dialog.Width = 50;
                        dialog.txt_caption.Text = "تمت حذف الصنف";
                        dialog.Show();

                    }
                }
                catch
                {

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد صنف  لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }




        }

        //لتحديث الداتا بالGrid
        private void update_data()
        {
            db = new DB_SMEntities1();
            gridControl1.DataSource = db.TB_Pur.ToList();
        }


        //تعديل
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FFRM_Pur_ADD frm_add = new PL.FFRM_Pur_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edit_name.Text = tb_pur.Pur_Name;
            frm_add.edit_type.Text = tb_pur.Pur_Type;
            frm_add.edit_cat.Text = tb_pur.Pur_Cat;
            frm_add.edit_supp.Text = tb_pur.Pur_Supp;
            frm_add.edit_det.Text= tb_pur.Pur_Det;
            frm_add.edit_buy.Text=tb_pur.Pur_Buy.ToString();
            frm_add.edit_sell.Text=tb_pur.Pur_Sell.ToString();
            frm_add.edit_qt.Text=tb_pur.Pur_Qt.ToString();
            frm_add.edit_tsell.Text=tb_pur.Pur_Tsell.ToString();
            frm_add.edit_tbuy.Text=tb_pur.Pur_Tbuy.ToString();
            frm_add.edit_trev.Text=tb_pur.Pur_TRev.ToString();
            frm_add.id = id;
            frm_add.btn_add.Text = " تعديل";
            frm_add.Show();
        }

        //Search
        private void btn_search_Click(object sender, EventArgs e)
        {
            
            var _search = edit_search.Text;
            if (_search == null)
            {

            }
            else
            {
                gridControl1.DataSource = db.TB_Pur.Where(x => x.Pur_Name.Contains(_search) || x.Pur_Type.Contains(_search) || x.Pur_Cat.Contains(_search)).ToList();
            }
            
        }
    }
}
