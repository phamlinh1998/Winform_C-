using QuanLy_Quan_CaFe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Quan_CaFe.View
{
    public partial class Employee : Form
    {
        public Employee(Admin ad)
        {
            InitializeComponent();
            frmAdmin = ad;
        }
        Admin frmAdmin;
        public void load_emp()
        {

            dtgvEmp.DataSource = EmployeeDAO.Instance.load_Emp();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string repass = txtRePass.Text;
            string gioitinh = "";
            string ngaysinh = dateTP.Value.ToString("dd/mm/yyyy");
            string sdt = txtDT.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            string hinhanh = txtPath.Text;
            if (rdNam.Checked)
            {
                gioitinh = rdNam.Text;
                EmployeeDAO.Instance.themNV(user,pass,repass,gioitinh,ngaysinh,sdt,email,diachi,hinhanh);
            }
            if(rdNu.Checked)
            {
                gioitinh = rdNu.Text;
                EmployeeDAO.Instance.themNV(user, pass, repass, gioitinh, ngaysinh, sdt, email, diachi, hinhanh);
            }
            load_emp();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            load_emp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(dlgOpen.FileName);
                txtPath.Text = dlgOpen.SafeFileName;
                
                pictureNV.Image = img;
                //sr.Close();
            }
        }

        private void dtgvEmp_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvEmp.CurrentRow != null)
            {
                var row = dtgvEmp.CurrentRow;
                txtUser.Text = row.Cells[0].Value.ToString();
                txtPass.Text = row.Cells[1].Value.ToString();
                txtRePass.Text = row.Cells[1].Value.ToString();
                txtHoten.Text = row.Cells[2].Value.ToString();
                string date = row.Cells[4].Value.ToString();
                
                dateTP.Value = DateTime.Parse(date);
                txtDT.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
                txtPath.Text = row.Cells[8].Value.ToString();
                string gt = row.Cells[3].Value.ToString();
                if (gt.Equals("Nam"))
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                string anh = row.Cells[8].Value.ToString();
                pictureNV.Image = Image.FromFile("G:\\C#\\QuanLy_Quan_CaFe\\image\\"+anh);
                pictureNV.SizeMode = PictureBoxSizeMode.StretchImage;

                
                txtUser.Enabled = false;
                txtPath.Enabled = false;
                txtHoten.Enabled = false;
                rdNam.Enabled = false;
                rdNu.Enabled = false;
                dateTP.Enabled = false;
                button1.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtRePass.Text = "";
            txtPath.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtHoten.Text = "";
            txtDT.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            dateTP.Value = dateTP.MinDate;
            pictureNV.Image = null;

            txtUser.Enabled = true;
            txtPath.Enabled = true;
            txtHoten.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            dateTP.Enabled = true;
            button1.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = txtUser.Text;
            EmployeeDAO.Instance.xoaNV(ten);
            load_emp();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string pass = txtPass.Text;
            string phone = txtDT.Text;
            string email = txtEmail.Text;
            string address = txtDiaChi.Text;
            string ten = txtUser.Text;

            EmployeeDAO.Instance.suaNV(pass,phone,email,address,ten);
            load_emp();
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                frmAdmin.Show();
            }
        }
    }
}
