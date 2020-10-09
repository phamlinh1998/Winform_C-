
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLy_Quan_CaFe.entities;
using QuanLy_Quan_CaFe.Server;
namespace QuanLy_Quan_CaFe.DAO
{
    class tableDAO
    {
        private static tableDAO instance;
        public static tableDAO Instance
        {
            get { if (instance == null) instance = new tableDAO(); return instance; }
            set { instance = value; }
        }
        private tableDAO() { }

        public List<table> loadTable()
        {
            List<table> tableList = new List<table>();

            DataTable data = ConnectionDB.Instance.ExcuteQuery("exec LayDulieuBang");

            foreach (DataRow item in data.Rows)
            {
                table bang = new table(item);
                tableList.Add(bang);
            }

            return tableList;
        }

        public static int tableWidth = 100;
        public static int tableHeight = 90;
    }
}
