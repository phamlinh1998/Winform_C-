using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLy_Quan_CaFe.entities
{
    public class table
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public table(int id,string name,string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public table(DataRow row)
        {
            this.ID =(int) row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
