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
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return instance; }
            set { instance = value; }
        }
        private OrderDetailDAO() { }

        public List<OrderDetail> layDSOrderDetail(int id)
        {
            List<OrderDetail> listData = new List<OrderDetail>();

            DataTable data = ConnectionDB.Instance.ExcuteQuery("exec layDSChiTietHoaDon "+id+"");
            foreach  (DataRow item in data.Rows)
            {
                OrderDetail odd = new OrderDetail(item);
                listData.Add(odd);
            }
            return listData;
        }

        public void suaOrderDetail(string masp, int sl,int mdh)
        {
            ConnectionDB.Instance.ExcuteQuery("exec suaOrderDetail " + masp + "," + sl + ","+ mdh + "");
        }

        public void themOrderDetail(int madh, string masp, int sl, string kichco)
        {
            ConnectionDB.Instance.ExcuteQuery("exec themOrderDetail " + madh + "," + masp + "," + sl + ",N'" + kichco + "'");
        }
    }
}
