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

        public DataTable IDLoaiSPTheoTen(string ma)
        {
            DataTable dt = new DataTable();
            string query = "exec IDLoaiSPTheoTen N'" + ma + "'";
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

        public void xoaSP(string id)
        {
            string query = "exec xoaSp "+id+"";
            ConnectionDB.Instance.ExcuteQuery(query);
        }

        public void suaSP(string ten, string maloai,string gia, string id)
        {
            
            string query = "exec suaSP N'"+ten+"',N'"+maloai+"', "+gia+","+id+" ";
            ConnectionDB.Instance.ExcuteQuery(query);
        }

        public DataTable tkTheoTen(string ten)
        {

            DataTable dt = new DataTable();
            string query = "exec timkiemSPtheoTen N'" + ten + "'";
            dt= ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable tkTheoGia(int giatu,int giaden)
        {

            DataTable dt = new DataTable();
            string query = "exec timkiemSPtheoGia "+ giatu + ","+giaden+"";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
        public DataTable tkTheoNhom(string tensp, string kichco)
        {

            DataTable dt = new DataTable();
            string query = "exec timkiemSPtheoNhom N'" + tensp + "',N'" + kichco + "'";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
        
        public DataTable laySPTheoIDLSP(string id)
        {
            //List<product> list = new List<product>();

            //DataTable data = ConnectionDB.Instance.ExcuteQuery("select * from Product where IDProduct = N'"+id+"'");

            //foreach (DataRow item in data.Rows)
            //{
            //    product p = new product(item);
            //    list.Add(p);
            //}
            //return list;
            DataTable dt = new DataTable();
            string query = "select DISTINCT ProductName from Product join ProductType ON Product.IDType = ProductType.IDType where TypeName = N'"+ id + "'";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable layKichCoTheoTen(string loaisp, string tensp)
        {
            DataTable dt = new DataTable();
            string query = "select Size from Product join ProductType ON Product.IDType = ProductType.IDType where TypeName = N'" + loaisp + "' and ProductName = N'"+ tensp + "'";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }
    }
}
