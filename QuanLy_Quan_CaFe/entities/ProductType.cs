using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
    class ProductType
    {
        public string iDType;
        public string IDType
        {
            get { return iDType; }
            set { iDType = value; }
        }
        public string typeName;
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        public string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public ProductType(string iDType,string typeName,string size)
        {
            this.IDType = iDType;
            this.TypeName = typeName;
            this.Size = size;
        }

        public ProductType(DataRow row)
        {
            this.IDType = row["iDType"].ToString();
            this.TypeName = row["typeName"].ToString();
            this.Size = row["size"].ToString();
        }
    }
}
