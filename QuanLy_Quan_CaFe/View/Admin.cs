using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Quan_CaFe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
                       
        }
       
        private void Admin_Load(object sender, EventArgs e)
        {
            ttPro.SetToolTip(btnProduct, "Quản Lý Sản Phẩm");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
