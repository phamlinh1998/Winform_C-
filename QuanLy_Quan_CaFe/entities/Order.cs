using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
    public class Order
    {
        public int iDOrder;
        public int IDOrder
        {
            get { return iDOrder; }
            set { iDOrder = value; }
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {   get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        public DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        public string usernameEmp;
        public string UsernameEmp
        {
            get { return usernameEmp; }
            set { usernameEmp = value; }
        }

        public int idTable;
        public int IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }
        public int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public Order(int id, DateTime? dateCheckInt, DateTime? dateCheckOut, string usernameEmp, int idTable, int status)
        {
            this.iDOrder = id;
            this.DateCheckIn = dateCheckInt;
            this.DateCheckOut = dateCheckOut;
            this.UsernameEmp = usernameEmp;
            this.IdTable = idTable;
            this.Status = status;
        }

        public Order(DataRow row)
        {
            this.IDOrder = (int)row["iDOrder"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var datecheck = row["dateCheckOut"];
            if (datecheck.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)datecheck;
            }
            
            
            this.UsernameEmp = (string)row["usernameEmp"];
            this.IdTable = (int)row["idTable"];
            this.Status = (int)row["status"];
        }
    }
}
