using QuanLy_Quan_CaFe.DAO;
using QuanLy_Quan_CaFe.Server;
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
    public partial class PassChangeEmpp : Form
    {
        public PassChangeEmpp(string name)
        {
            InitializeComponent();
            ten = name;
        }
        string ten;
        private void PassChangeEmpp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = txtPassCu.Text;
            string passMoi = txtPassMoi.Text;
            string rePassMoi = txtRePass.Text;
            
            if (pass == EmployeeDAO.Instance.layPassEmp(ten))
            {
                if (passMoi.Equals(rePassMoi))
                {
                    EmployeeDAO.Instance.updatePassEmp(passMoi, ten);
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ", "Thông báo");
            }
        }
    }
}
