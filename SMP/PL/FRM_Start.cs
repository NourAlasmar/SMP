using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class FRM_Start : SplashScreen
    {
        DB_SMEntities1 db = new DB_SMEntities1();
        TB_USERS tb_users = new TB_USERS();
        Main main=new Main();
        PL.FFRM_Login login = new PL.FFRM_Login();

        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_users = db.TB_USERS.Where(x => x.User_State == "True").FirstOrDefault();
            if(tb_users != null)
            {
                main.lb_username22.Text = tb_users.User_Name;
                main.lb_roll22.Text = tb_users.User_Roll;
                main.Show();
            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled=false;
        }
    }
}