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
    class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            set { instance = value; }
        }
        private MenuDAO() { }

        public List<Menu> layDSMenuTheoBan(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            DataTable data = ConnectionDB.Instance.ExcuteQuery("exec layDSMenuTheoBan "+id+"");

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
