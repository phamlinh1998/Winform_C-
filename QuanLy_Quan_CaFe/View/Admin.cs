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

namespace QuanLy_Quan_CaFe
{
    public partial class Admin : Form
    {
        public Admin(Login lg)
        {
            InitializeComponent();
            frmLogin = lg;
        }
        Login frmLogin;
        private void Admin_Load(object sender, EventArgs e)
        {
            ttPro.SetToolTip(btnProduct, "Quản Lý Sản Phẩm");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product pro_form = new Product(this);
            this.Hide();
            pro_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                frmLogin.Show();
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                frmLogin.Show();
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Employee emp_form = new Employee(this);
            this.Hide();
            emp_form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order od_form = new Order(this);
            this.Hide();
            od_form.Show();
        }
    }
    
}
