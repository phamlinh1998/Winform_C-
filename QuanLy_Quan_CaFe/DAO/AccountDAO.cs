using QuanLy_Quan_CaFe.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set { instance = value; }
        }
        private AccountDAO() { }

        public bool login(string tableName,string userName,string pass)
        {
            string query = "select * from "+tableName+" where Username=N'"+ userName+"'  and Password=N'"+pass+"' ";
            DataTable result = ConnectionDB.Instance.ExcuteQuery(query);
            return result.Rows.Count>0;
        }
    }
}
