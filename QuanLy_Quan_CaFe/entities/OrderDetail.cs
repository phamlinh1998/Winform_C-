using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
    public class OrderDetail
    {
        public int iDOrder;
        public int IDOrder
        {
            get { return iDOrder; }
            set { iDOrder = value; }
        }

        public string iDProduct;
        public string IDProduct
        {
            get { return iDProduct; }
            set { iDProduct = value; }
        }
        public int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public OrderDetail(int id,string maSp,int soLuong)
        {
            this.IDOrder = id;
            this.IDProduct = maSp;
            this.Quantity = soLuong;
        }

        public OrderDetail(DataRow row)
        {
            this.IDOrder = (int)row["IDOrder"];
            this.IDProduct = (string)row["IDProduct"];
            this.Quantity = (int)row["Quantity"];
        }
    }
}
