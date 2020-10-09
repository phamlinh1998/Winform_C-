using QuanLy_Quan_CaFe.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            set { instance = value; }
        }
        private EmployeeDAO() { }

        public DataTable load_Emp()
        {
            DataTable dt = new DataTable();
            string query = "exec load_Emp";
            dt = ConnectionDB.Instance.ExcuteQuery(query);
            return dt;
        }

        public void themNV(string user,string pass,string repass,string gioitinh,string ngaysinh,string sdt,string email,string diachi,string hinhanh)
        {
            string query = "exec them_Emp @Username , @Password , @NameEmp , @Gender , @Birthday , @Phone , @Email , @Address , @Hinh ";
            ConnectionDB.Instance.ExcuteQuery(query,new object[]{user , pass , repass , gioitinh , ngaysinh , sdt , email , diachi , hinhanh});
        }

        public void xoaNV(string ten)
        {
            string query = "exec Xoa_Emp @Username";
            ConnectionDB.Instance.ExcuteQuery(query,new object[] {ten });
        }

        public void suaNV(string pass,string phone,string email,string diachi,string ten)
        {
            string query = "exec sua_Emp @Password , @Phone , @Email , @Address , @Username ";
            ConnectionDB.Instance.ExcuteQuery(query, new object[] { pass,phone,email,diachi,ten });
        }
    }
}
