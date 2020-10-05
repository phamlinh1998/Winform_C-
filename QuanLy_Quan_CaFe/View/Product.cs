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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            load_cbLSP();
            panelTK.Visible = false;
            btnDeleteSP.Enabled = false;
            btnUpdateSP.Enabled = false;
        }
        public void load_LoaiSP()
        {
            
            string query = "select IDType as[Mã],TypeName as [Tên loại],Size as [Kích cỡ] from ProductType ORDER BY IDType DESC";
            dtgvLoaiSP.DataSource = ConnectionDB.Instance.ExcuteQuery(query);
        }
        public void load_cbLSP()
        {
            DataTable dt = new DataTable();
            dt = productDAO.Instance.load_cbLSP();
            foreach (DataRow item in dt.Rows)
            {
                cbNameType.Items.Add(item["TypeName"].ToString());
            }
        }
        public void load_SP()
        {
            dtgvSP.DataSource = productDAO.Instance.hienthiSP();
        }
        
        private void Product_Load(object sender, EventArgs e)
        {
            load_LoaiSP();
            load_SP();
        }

        private void dtgvLoaiSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvLoaiSP.CurrentRow !=null)
            {
                var row = dtgvLoaiSP.CurrentRow;
                txtIDProductType.Text = row.Cells[0].Value.ToString();
                txtNameType.Text = row.Cells[1].Value.ToString();
                cbLSP.SelectedItem = row.Cells[2].Value.ToString();

                txtIDProductType.Enabled = false;
                btnThemLoaiSP.Enabled = false;
                btnXoaLoaiSP.Enabled = true;
                btnSuaLoaiSP.Enabled = true;
            }
        }

        private void btnResetLoaiSP_Click(object sender, EventArgs e)
        {
            txtIDProductType.Enabled = true;
            btnThemLoaiSP.Enabled = true;
            btnSuaLoaiSP.Enabled = false;
            btnXoaLoaiSP.Enabled = false;
            txtIDProductType.Text = "";
            txtNameType.Text = "";
            cbLSP.SelectedIndex = -1;
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            string ma = txtIDProductType.Text;
            string ten = txtNameType.Text;
            string kichco = cbLSP.SelectedItem.ToString();
            productDAO.Instance.themloaisp(ma, ten, kichco);
            load_LoaiSP();
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            string ma = txtIDProductType.Text;
            string ten = txtNameType.Text;
            string kichco = cbLSP.SelectedItem.ToString();
            productDAO.Instance.sualoaisp(ten, kichco, ma);
            load_LoaiSP();
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            string ma = txtIDProductType.Text;
            productDAO.Instance.xoaloaisp(ma);
            load_LoaiSP();
        }

        private void dtgvSP_SelectionChanged(object sender, EventArgs e)
        {
            //if (dtgvSP.CurrentRow != null)
            //{
            //    var row = dtgvSP.CurrentRow;
            //    txtIDProduct.Text = row.Cells[0].Value.ToString();
            //    txtNameproduct.Text = row.Cells[1].Value.ToString();
            //    txtPrice.Text = row.Cells[3].Value.ToString();
            //    cbKichCo.SelectedItem = row.Cells[4].Value.ToString();

            //    string ma = row.Cells[2].Value.ToString();
            //    DataTable dt = new DataTable();
            //    dt = productDAO.Instance.TenLoaiSPTheoID(ma);
                
            //    cbNameType.SelectedItem = dt.Rows[0]["TypeName"].ToString();
            //}
        }

        private void dtgvSP_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvSP.CurrentRow != null)
            {
                var row = dtgvSP.CurrentRow;
                txtIDProduct.Text = row.Cells[0].Value.ToString();
                txtNameproduct.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                cbKichCo.SelectedItem = row.Cells[4].Value.ToString();

                string ma = row.Cells[2].Value.ToString();
                DataTable dt = new DataTable();
                dt = productDAO.Instance.TenLoaiSPTheoID(ma);

                cbNameType.SelectedItem = dt.Rows[0]["TypeName"].ToString();

                btnAddSP.Enabled = false;
                btnDeleteSP.Enabled = true;
                btnUpdateSP.Enabled = true;

            }
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            string ma = txtIDProduct.Text;
            string ten = txtNameproduct.Text;
            string loaiSP = cbNameType.SelectedItem.ToString();
            string gia = txtPrice.Text;
            string kichco = cbKichCo.SelectedItem.ToString();

            DataTable dt = new DataTable();
            dt = productDAO.Instance.layIDLoaiSP(loaiSP,kichco);

            string id = dt.Rows[0]["IDType"].ToString();

            productDAO.Instance.themSP(ma, ten, id, gia);
            load_SP();

        }

    }
}
