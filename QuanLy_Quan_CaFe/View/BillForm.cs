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

namespace QuanLy_Quan_CaFe.View
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            load_table();
            load_loaisp();
            
        }

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
        }
        private void BillForm_Load(object sender, EventArgs e)
        {

        }

        private void cbLsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbLsp.SelectedItem.ToString();
            load_tensp(ma);
        }

        private void cbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenlsp = cbLsp.SelectedItem.ToString();
            string tensp = cbTensp.SelectedItem.ToString();
            load_cbKichco(tenlsp, tensp);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
