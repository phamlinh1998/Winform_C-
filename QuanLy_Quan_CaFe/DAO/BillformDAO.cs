using QuanLy_Quan_CaFe.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.DAO
{
    class BillformDAO
    {
        private static BillformDAO instance;
        public static BillformDAO Instance
        {
            get { if (instance == null) instance = new BillformDAO(); return instance; }
            set { instance = value; }
        }
        private BillformDAO() { }
        public void load_bill()
        {
            string query = "";
            ConnectionDB.Instance.ExcuteQuery(query);
        }
    }
}
