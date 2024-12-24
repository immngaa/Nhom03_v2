using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom03_v2
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void ptrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau form1 = new FormQuenMatKhau();
            form1.ShowDialog();
            this.Hide();
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy form1 = new FormDangKy();
            form1.ShowDialog();
            this.Hide();
        }
    }
}
