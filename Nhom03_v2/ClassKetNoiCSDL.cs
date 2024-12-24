using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom03_v2
{
    internal class ClassKetNoiCSDL
    {
        /*
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306;username=root;password=;database=cskh";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Conection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;

        }*/

        private readonly string connectionString;

        // Constructor để nhận chuỗi kết nối
        public ClassKetNoiCSDL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Phương thức thực hiện truy vấn không trả về dữ liệu (Thêm, Sửa, Xóa)
        public bool ThucThiLenh(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thực hiện lệnh: " + ex.Message);
                    return false;
                }
            }

        }
    }
}
