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
    class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            set { instance = value; }
        }
        private OrderDAO() { }

        public int layHoaDonTheoTableID(int id)
        {

            DataTable data = ConnectionDB.Instance.ExcuteQuery("exec layHoaDonTheoTableID "+id+"");
            if (data.Rows.Count >0)
            {
                Order od = new Order(data.Rows[0]);
                return od.IDOrder;
            }
            return -1;
        }

        public void themOrder(string ten,int ban)
        {
            ConnectionDB.Instance.ExcuteQuery("exec themOrder N'"+ten+"',"+ban+"");

        }

        public int MaxIDBill()
        {
            try
            {
                return (int)ConnectionDB.Instance.ExcuteScalar("select Max(IDOrder) from Orders");
            }
            catch (Exception)
            {

                return 1;
            }
        }

        public void checkOut(int id)
        {
           
            ConnectionDB.Instance.ExcuteNonQuery("exec updateSTTBill "+id+"");
        }

        public DataTable load_DSDH()
        {
            DataTable dt = new DataTable();
            string query = "exec load_DSDH";
            dt = ConnectionDB.Instance.ExcuteQuery(query);

            return dt;
        }
        public DataTable tkTheoMDH(int ma)
        {
            DataTable dt = new DataTable();
            string query = "exec tkTheoMDH "+ma+"";
            dt = ConnectionDB.Instance.ExcuteQuery(query);

            return dt;
        }

        public DataTable tkTheoNgay(string d)
        {
            DataTable dt = new DataTable();
            string query = "exec tkTheoNgay '"+d+"'";
            dt = ConnectionDB.Instance.ExcuteQuery(query);

            return dt;
        }
    }
}
