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
    public partial class FRM_Users : Form
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_USERS tb_users = new TB_USERS();
        int id;
        BL.Methods methods = new BL.Methods();

        public FRM_Users()
        {
            InitializeComponent();
            SMP.DB_SMEntities1 dbContext = new SMP.DB_SMEntities1();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_USERS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_USERS.Local.ToBindingList();
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
            PL.FFRM_Users_ADD frm_add = new PL.FFRM_Users_ADD();
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
                        tb_users = db.TB_USERS.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_users).State = EntityState.Deleted;
                        db.SaveChanges();
                        update_data();
                        dialog.Width = 50;
                        dialog.txt_caption.Text = "تمت حذف المستخدم";
                        dialog.Show();

                    }
                }
                catch
                {

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مستخدم  لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }




        }

        //لتحديث الداتا بالGrid
        private void update_data()
        {
            db = new DB_SMEntities1();
            gridControl1.DataSource = db.TB_USERS.ToList();
        }


        //تعديل
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FFRM_Users_ADD frm_add = new PL.FFRM_Users_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_users = db.TB_USERS.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edit_name.Text = tb_users.User_Name;
            frm_add.edit_pass.Text = tb_users.User_Pass;
            frm_add.edit_roll.Text = tb_users.User_State;
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
                gridControl1.DataSource = db.TB_USERS.Where(x => x.User_Name.Contains(_search) || x.User_State.Contains(_search)).ToList();
            }
            
        }
    }
}
