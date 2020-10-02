using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Quan_CaFe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin_form = new Admin();
            admin_form.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Admin admin_form = new Admin();
            admin_form.Show();
        }
    }
}
