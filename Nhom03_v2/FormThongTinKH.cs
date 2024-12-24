using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nhom03_v2
{
    public partial class FormThongTinKH : Form
    {
        private string connectionString = "Server=localhost;Database=cskh;Uid=root;Pwd=01072004;";
        public FormThongTinKH()
        {
            InitializeComponent();
        }
        private MySqlConnection GetConnection()
        { 
            return new MySqlConnection(connectionString);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối đến MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //MessageBox.Show("Kết nối thành công!");

                    // Thực hiện truy vấn
                    string query = "SELECT * FROM khachhang";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Đổ dữ liệu vào DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu trong DataGridView
                    dtgrvThongTinKH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadData()
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM bang_khach_hang";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtgrvThongTinKH.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO bang_khach_hang (MaKhachHang, TenKhachHang, MaNhomKH, DiemTichLuy, CapDoThanhVien, GioiTinh, NgaySinh, Email, SoDienThoai, DiaChi) 
                             VALUES (@MaKH, @TenKH, @MaNhomKH, @Diem, @CapDo, @GioiTinh, @NgaySinh, @Email, @SDT, @DiaChi)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@MaNhomKH", cbMaNhomKH.SelectedItem);
                    cmd.Parameters.AddWithValue("@Diem", txtDiemTichLuy.Text);
                    cmd.Parameters.AddWithValue("@CapDo", cbCapDoThanhVien.SelectedItem);
                    cmd.Parameters.AddWithValue("@GioiTinh", rbtnNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
