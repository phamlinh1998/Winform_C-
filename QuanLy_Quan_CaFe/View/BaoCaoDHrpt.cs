
using QuanLy_Quan_CaFe.Report;
using QuanLy_Quan_CaFe.Server;
using QuanLy_Quan_CaFe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Quan_CaFe.View
{
    public partial class BaoCaoDHrpt : Form
    {
        public BaoCaoDHrpt(Order od)
        {
            InitializeComponent();
            frmOrder = od;
        }
        Order frmOrder;
        private void BaoCaoDHrpt_Load(object sender, EventArgs e)
        {
            BaoCaoDH rpt = new BaoCaoDH();

            
            var data = ConnectionDB.Instance.ExcuteQuery("select od.IDOrder ,p.IDProduct ,odd.Quantity ,od.DateCheckOut,od.UsernameEmp ,p.Price from Orders od join OrderDetails odd on od.IDOrder = odd.IDOrder join Product p on p.IDProduct = odd.IDProduct");

            rpt.SetDataSource(data);

            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.Show();
        }

        private void BaoCaoDHrpt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
            frmOrder.Show();
        }
    }
}
