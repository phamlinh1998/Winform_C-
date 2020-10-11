using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.entities
{
    class BaoCaoDH
    {
        public int IDOrder { get; set; }
        public string IDProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCheckOut { get; set; }
        public string UsernameEmp { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
    }
}
