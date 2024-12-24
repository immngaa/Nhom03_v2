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
	public partial class FormThongTinSanPham : Form
	{
		public FormThongTinSanPham()
		{
			InitializeComponent();
		}

		private void dtgrvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FormThongTinSanPham_Load(object sender, EventArgs e)
		{
			LoadAllProducts();
		}
		private string connectionString = "Server=localhost;Database=QuanLydichvu;Uid=root;Pwd=12345;";
		private DataTable dtSanPham;

		private void LoadAllProducts()
		{
			try
			{
				using (MySqlConnection con = new MySqlConnection(connectionString))
				{
					string sql = "SELECT * FROM quanlydichvu.sanpham";
					MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
					dtSanPham = new DataTable();
					da.Fill(dtSanPham);
					dtgrvThongTinSanPham.DataSource = dtSanPham;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message);
			}
		}


		// Tìm kiếm theo Mã Sản Phẩm
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
		}
	}
}
