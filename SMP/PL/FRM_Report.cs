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
using DevExpress.XtraReports.UI;

namespace SMP.PL
{
    public partial class FRM_Report : Form
    {


        public FRM_Report()
        {
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            PL.SuppReport report = new SuppReport();
            report.ShowPreview();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.SellRep report = new SellRep();
            report.ShowPreview();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.BuyReport report = new BuyReport();
            report.ShowPreview();
        }
    }
}
    

