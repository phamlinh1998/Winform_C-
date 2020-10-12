using QuanLy_Quan_CaFe.DAO;
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
    public partial class infoEmp : Form
    {
        public infoEmp(string name)
        {
            InitializeComponent();
            ten = name;
        }
        string ten;
        private void infoEmp_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = EmployeeDAO.Instance.layEmpTheoID(ten);
            txtTen.Text = dt.Rows[0]["NameEmp"].ToString();
            txtGT.Text = dt.Rows[0]["Gender"].ToString();
            txtNS.Text = dt.Rows[0]["Birthday"].ToString(); ;
            txtSDT.Text = dt.Rows[0]["Phone"].ToString(); ;
            txtEmail.Text = dt.Rows[0]["Email"].ToString(); ;
            txtDiachi.Text = dt.Rows[0]["Address"].ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
