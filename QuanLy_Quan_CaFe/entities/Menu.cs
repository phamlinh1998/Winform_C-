using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
   public class Menu
    {
        public int iDOrder;
        public int IDOrder
        {
            get { return iDOrder; }
            set { iDOrder = value; }
        }
        public string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int totaPrice;
        public int TotaPrice
        {
            get { return totaPrice; }
            set { totaPrice = value; }
        }
        public Menu(int iDOrder, string productName, string size,int quantity, int price,int totalPrice =0)
        {
            this.IDOrder = iDOrder;
            this.ProductName = productName;
            this.Size = size;
            this.Quantity = quantity;
            this.Price = price;
            this.TotaPrice = totaPrice;
        }
        public Menu(DataRow row)
        {
            this.IDOrder = (int)row["iDOrder"];
            this.ProductName = (string)row["productName"].ToString();
            this.Size = (string)row["size"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = (int)row["price"];
            this.TotaPrice = (int)row["totaPrice"];
        }
    }
}
