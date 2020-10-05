using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Quan_CaFe.Server
{
    public class ConnectionDB
    {
        private static ConnectionDB instance;
        public static ConnectionDB Instance
        {
            get {  if (instance == null) instance = new ConnectionDB(); return ConnectionDB.instance; }
            set { ConnectionDB.instance = value; }
        }
        private ConnectionDB() { }
        private string chuoi_ket_noi = "server=DESKTOP-DP30IQA\\SQLEXPRESS;database=QLCaFe_Winform;uid=sa;pwd=19101998";

        public DataTable ExcuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoi_ket_noi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                //truyền tham số cho câu lệnh query
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        // Kiểm tra dữ liệu trong sql có thành công hay không
        public int ExcuteNonQuery(string query, object[] para = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(chuoi_ket_noi))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                //truyền tham số cho câu lệnh query
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }
    }
}
