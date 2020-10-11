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
    public partial class Order : Form
    {
        public Order(Admin ad)
        {
            InitializeComponent();
            frmAdmin = ad;
        }
        Admin frmAdmin;
        public void load_dh()
        {
            dtgvDH.DataSource = OrderDAO.Instance.load_DSDH();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            load_dh();
            lbMadh.Visible = false;
            txtMaDH.Visible = false;
            lbNgay.Visible = false;
            dtpNgay.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lbMadh.Visible = true;
                txtMaDH.Visible = true;
                lbNgay.Visible = false;
                dtpNgay.Visible = false;

            }
            else
            {
                lbMadh.Visible = false;
                txtMaDH.Visible = false;
                lbNgay.Visible = true;
                dtpNgay.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            while (dtgvDH.Rows.Count != 0)
            {
                dtgvDH.Rows.RemoveAt(0);
            }
            if (comboBox1.SelectedIndex == 0)
            {

                int ten = Convert.ToInt32(txtMaDH.Text);
                dt = OrderDAO.Instance.tkTheoMDH(ten);
                dtgvDH.DataSource = dt;

            }

            if (comboBox1.SelectedIndex == 1)
            {
                //MessageBox.Show(dtpNgay.Value.ToString("yyyy-MM-dd"));
                dt = OrderDAO.Instance.tkTheoNgay(dtpNgay.Value.ToString("yyyy-MM-dd"));
                dtgvDH.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "---------------Tìm kiếm đơn hàng----------";
            load_dh();
            lbMadh.Visible = false;
            txtMaDH.Visible = false;
            lbNgay.Visible = false;
            dtpNgay.Visible = false;
        }

        private void btnIndh_Click(object sender, EventArgs e)
        {
            BaoCaoDHrpt bc = new BaoCaoDHrpt(this);
            bc.ShowDialog();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
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
