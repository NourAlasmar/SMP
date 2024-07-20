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
    public partial class FRM_Cust : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_Cust tb_cust = new TB_Cust();
        int id;
        BL.Methods methods = new BL.Methods();

        public FRM_Cust()
        {

            InitializeComponent();
            SMP.DB_SMEntities1 dbContext = new SMP.DB_SMEntities1();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Cust.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Cust.Local.ToBindingList();
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
            PL.FFRM_Cust_ADD frm_add = new PL.FFRM_Cust_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = " اضافة";
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
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {

                    var result = MessageBox.Show("هل انت متاكد من هذه العملية؟", "عملية حذف", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        tb_cust = db.TB_Cust.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_cust).State = EntityState.Deleted;
                        db.SaveChanges();
                        update_data();
                        dialog.Width = 50;
                        dialog.txt_caption.Text = "تمت حذف العميل";
                        dialog.Show();

                    }
                }
                catch
                {

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد عميل لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }




        }

        //لتحديث الداتا بالGrid
        private void update_data()
        {
            db = new DB_SMEntities1();
            gridControl1.DataSource = db.TB_Cust.ToList();
        }


        //تعديل
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FFRM_Cust_ADD frm_add = new PL.FFRM_Cust_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            tb_cust = db.TB_Cust.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edit_name.Text = tb_cust.Cust_Name.ToString();
            frm_add.edit_phone.Text = tb_cust.Cust_Phone.ToString();
            frm_add.edit_email.Text = tb_cust.Cust_Email.ToString();
            methods.by = tb_cust.Cust_image;
            frm_add.pic_cover.Image = Image.FromStream(methods.convert_image());
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
                gridControl1.DataSource = db.TB_Cust.Where(x => x.Cust_Name.Contains(_search) || x.Cust_Phone.Contains(_search) || x.Cust_Email.Contains(_search)).ToList();
            }
            
        }
    }
}
