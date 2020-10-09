using QuanLy_Quan_CaFe.entities;
using QuanLy_Quan_CaFe.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.DAO
{
    class productTypeDAO
    {
        private static productTypeDAO instance;
        public static productTypeDAO Instance
        {
            get { if (instance == null) instance = new productTypeDAO(); return instance; }
            set { instance = value; }
        }
        private productTypeDAO() { }

        public List<ProductType> layDSLoaiSP()
        {
            List<ProductType> listLoaiSP = new List<ProductType>();

            DataTable data = ConnectionDB.Instance.ExcuteQuery("select * from ProductType");
            foreach (DataRow item in data.Rows)
            {
                ProductType pt = new ProductType(item);
                listLoaiSP.Add(pt);
            }

            return listLoaiSP;
        }

        public DataTable laytenLSP()
        {
            DataTable dt = new DataTable();
            string query = "exec LayTenLoaiSP ";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
    }
}
