using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
    class product
    {
        public string iDProduct;
        public string productName;
        public string iDType;
        public int price;

        public string IDProduct
        {
            get { return iDProduct; }
            set { iDProduct = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string   IDType
        {
            get { return iDType; }
            set { iDType = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public product(string iDProduct, string productName, string iDType, int price)
        {
            this.IDProduct = iDProduct;
            this.ProductName = productName;
            this.IDType = iDType;
            this.Price = price;
        }

        public product(DataRow row)
        {
            this.IDProduct = row["iDProduct"].ToString();
            this.ProductName = row["productName"].ToString();
            this.IDType = row["iDType"].ToString();
            this.Price = (int)row["price"];
        }
    }
}
