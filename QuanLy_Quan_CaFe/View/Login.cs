using QuanLy_Quan_CaFe.DAO;
using QuanLy_Quan_CaFe.Server;
using QuanLy_Quan_CaFe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Quan_CaFe
{
    public partial class Login : Form
    {
        private string chuoi_ket_noi = "server=DESKTOP-DP30IQA\\SQLEXPRESS;database=QLCaFe;uid=sa;pwd=19101998";
        public Login()
        {
            InitializeComponent();
        }
        public void isEmpty()
        {
            string userName = txtUser.Text;
            string pass = txtPass.Text;
            string admin = "Administrator";
            string emp = "Employee";
            if (cbRole.SelectedIndex==0)
            {
                if (AccountDAO.Instance.login(admin, userName, pass))
                {
                    Admin admin_form = new Admin(this);
                    this.Hide();
                    admin_form.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
            if (cbRole.SelectedIndex == 1)
            {
                if (AccountDAO.Instance.login(emp,userName, pass))
                {
                    BillForm Bill_Form = new BillForm(this);
                    this.Hide();
                    Bill_Form.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            isEmpty();           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel,     MessageBoxIcon.Question) == DialogResult.OK)
            {

                Application.Exit();
            }

        }
    }
}
