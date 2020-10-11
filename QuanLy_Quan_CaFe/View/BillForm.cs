using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Quan_CaFe.entities;
using QuanLy_Quan_CaFe.DAO;
using Menu = QuanLy_Quan_CaFe.entities.Menu;
using System.Globalization;
using QuanLy_Quan_CaFe.Server;

namespace QuanLy_Quan_CaFe.View
{
    public partial class BillForm : Form
    {
        public BillForm( Login lg)
        {
            InitializeComponent();
            load_table();
            load_loaisp();
            frmlogin= lg;
        }
        Login frmlogin;
        public void load_loaisp()
        {
            //List<ProductType> listproductType = productTypeDAO.Instance.layDSLoaiSP();
            //cbLsp.DataSource = listproductType;
            //cbLsp.DisplayMember = "TypeName";

            DataTable dt = new DataTable();
            dt = productTypeDAO.Instance.laytenLSP();
            foreach (DataRow item in dt.Rows)
            {
                string ten = item["TypeName"].ToString();
                cbLsp.Items.Add(ten);

            }
        }
        public void load_tensp(string ma)
        {
            //List<product> listProduct = productDAO.Instance.laySPTheoIDLSP(ma);

            //cbTensp.DataSource = listProduct;
            
            DataTable dt = new DataTable();
            dt = productDAO.Instance.laySPTheoIDLSP(ma);
            foreach (DataRow item in dt.Rows)
            {
                string ten = item["ProductName"].ToString();
                cbTensp.Items.Add(ten);
            }

        }
        public void load_cbKichco(string tenlsp, string tensp)
        {
            DataTable dt = new DataTable();
            dt = productDAO.Instance.layKichCoTheoTen(tenlsp,tensp);
            foreach (DataRow item in dt.Rows)
            {
                string ten = item["Size"].ToString();
                cbKichco.Items.Add(ten);
            }
        }

        public void load_table()
        {
            flTable.Controls.Clear();
            List<table> tableList = tableDAO.Instance.loadTable();
            foreach (table item in tableList)
            {
                
                Button btn = new Button() { Width = tableDAO.tableWidth ,Height = tableDAO.tableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.DeepPink;
                        break;
                }
                flTable.Controls.Add(btn);
            }
        }
        public void show_bill(int id)
        {
            lstOrder.Items.Clear();
            List<Menu> listOdd = MenuDAO.Instance.layDSMenuTheoBan(id);

            int total = 0;
            foreach (Menu item in listOdd)
            {
                ListViewItem lsvItem = new ListViewItem(item.IDOrder.ToString());
                lsvItem.SubItems.Add(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.Size.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotaPrice.ToString());

                total += item.TotaPrice;
                lstOrder.Items.Add(lsvItem);
            }
            CultureInfo cul = new CultureInfo("vi-VN"); 
            txtTotal.Text = total.ToString("c",cul);
        }
        private void btn_click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as table).ID;
            lstOrder.Tag = (sender as Button).Tag;
            show_bill(tableID);
            cbLsp.Text = "";
            cbTensp.Text = "";
            cbKichco.Text = "";
            
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cbLsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTensp.Items.Clear();
            cbTensp.Text = "";
            cbKichco.Text = "";
            string ma = cbLsp.SelectedItem.ToString();
            load_tensp(ma);

        }

        private void cbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKichco.Items.Clear();
            cbKichco.Text = "";
            string tenlsp = cbLsp.SelectedItem.ToString();
            string tensp = cbTensp.SelectedItem.ToString();
            load_cbKichco(tenlsp, tensp);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            table tb = lstOrder.Tag as table;
            DataTable dt = new DataTable();
            dt = productDAO.Instance.IDSPTheoTen(cbTensp.SelectedItem.ToString(),cbKichco.SelectedItem.ToString());
            string ma = dt.Rows[0]["IDProduct"].ToString();
            
            int idBill = OrderDAO.Instance.layHoaDonTheoTableID(tb.ID);

            int count = (int)nmSoLuong.Value;
            if (idBill == -1)
            {
                OrderDAO.Instance.themOrder(txtNV.Text, tb.ID);
                OrderDetailDAO.Instance.themOrderDetail(OrderDAO.Instance.MaxIDBill(), ma, count, cbKichco.SelectedItem.ToString());
            }
            else
            {
                OrderDetailDAO.Instance.themOrderDetail(idBill, ma, count, cbKichco.SelectedItem.ToString());
            }
            show_bill(tb.ID);
            load_table();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            table tb = lstOrder.Tag as table;

            int idOrder = OrderDAO.Instance.layHoaDonTheoTableID(tb.ID);
            if (idOrder != -1)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho bàn " + tb.Name, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OrderDAO.Instance.checkOut(idOrder);
                    show_bill(tb.ID);
                    load_table();
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        //    table tb = lstOrder.Tag as table;
        //    //int mdh =Convert.ToInt32(lstOrder.SelectedItems[0].SubItems[0].Text);
        //    int idOrder = OrderDAO.Instance.layHoaDonTheoTableID(tb.ID);
        //    int sl = Convert.ToInt32(nmSoLuong.Value.ToString());
        //    string tensp = cbTensp.SelectedItem.ToString();
        //    DataTable dt = ConnectionDB.Instance.ExcuteQuery("select IDProduct from Product where ProductName = N'" + tensp+"'");
        //    string masp = dt.Rows[0]["IDProduct"].ToString();
            
        //    //OrderDetailDAO.Instance.suaOrderDetail(masp,sl, idOrder);
        //    ConnectionDB.Instance.ExcuteQuery("update OrderDetails set IDProduct ="+ masp + " ,Quantity="+sl+" where IDOrder ="+idOrder+" ");

        //    //show_bill(tb.ID);
        }

        private void lstOrder_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            
            cbTensp.Text = lstOrder.SelectedItems[0].SubItems[1].Text;
            cbKichco.Text = lstOrder.SelectedItems[0].SubItems[2].Text;
            nmSoLuong.Value = Convert.ToDecimal(lstOrder.SelectedItems[0].SubItems[3].Text);
            dt = productTypeDAO.Instance.laytenLSPTheoSP(cbTensp.Text);
            cbLsp.Text = dt.Rows[0]["TypeName"].ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string tensp = cbTensp.SelectedItem.ToString();
            //DataTable dt = ConnectionDB.Instance.ExcuteQuery("select IDProduct from Product where ProductName = N'" + tensp + "'");
            //   string masp = dt.Rows[0]["IDProduct"].ToString();
            
            //ConnectionDB.Instance.ExcuteQuery("delete from OrderDetails where IDProduct =N'" + masp + "'");
            //table tb = lstOrder.Tag as table;
            //show_bill(tb.ID);
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.ShowDialog();
        }

        private void BillForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            frmlogin.Show();
            this.Dispose();
            this.Close();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin.Show();
            this.Dispose();
            this.Close();
        }
        //public void dongForm()
        //{
        //    if (MessageBox.Show("Bạn muốn đóng form?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //    {                
        //        this.Close();
        //        frmlogin.Show();
        //    }
        //}
    }
}
