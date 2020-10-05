using QuanLy_Quan_CaFe.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.DAO
{
    class productDAO
    {
        private static productDAO instance;
        public static productDAO Instance
        {
            get { if (instance == null) instance = new productDAO(); return instance; }
            set { instance = value; }
        }
        private productDAO() { }
        public void themloaisp(string ma, string ten, string kichco)
        {
            string query = "exec themLoaiSP " + ma + ",N'" + ten + "',N'" + kichco + "'";
            ConnectionDB.Instance.ExcuteQuery(query);

        }

        public void sualoaisp(string ten, string kichco, string ma)
        {
            string query = "exec suaLoaiSP N'" + ten + "',N'" + kichco + "'," + ma + "";
            ConnectionDB.Instance.ExcuteQuery(query);

        }

        public void xoaloaisp(string ma)
        {
            string query = "exec xoaLoaiSP " + ma + "";
            ConnectionDB.Instance.ExcuteQuery(query);

        }
        
        public DataTable load_cbLSP()
        {
            DataTable dt = new DataTable();
            string query = "exec LayTenLoaiSP ";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }

        //---------------------TRUY VẤN SẢN PHẨM----------------------------

        public DataTable hienthiSP()
        {
            DataTable dt = new DataTable();
            string query = "exec LayDanhSachProduct";
            dt=ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
        public DataTable TenLoaiSPTheoID(string ma)
        {
            DataTable dt = new DataTable();
            string query = "exec TenLoaiSPTheoID " + ma + "";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
        public DataTable layIDLoaiSP(string ten,string kichco)
        {
            DataTable dt = new DataTable();
            string query = "exec layIDLoaiSP N'"+ten+"',N'"+kichco+ "'";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }

        public void themSP(string ma,string ten,string id,string gia)
        {
            string query = "exec themSP N'"+ma+ "',N'" + ten + "',N'" + id + "'," + gia + "";
            ConnectionDB.Instance.ExcuteQuery(query);

        }
    }
}
