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
    public partial class FormGiaoDienChinh : Form
    {
        public FormGiaoDienChinh()
        {
            InitializeComponent();
            customizeDesing();
        }

        #region ThietKeMenu
        private void customizeDesing()
        {
            panelDanhMuc.Visible = false;
            panelTuVanGiaiDap.Visible = false;
            panelDichVuHauMai.Visible = false;
            panelXuLyKhieuNai.Visible = false;
            panelBaoCaoThongKe.Visible = false;


        }
       
        //Ẩn các chức năng con
        private void anMenu()
        {
            if (panelDanhMuc.Visible == true)
            {
                panelDanhMuc.Visible = false;
            }

            if (panelTuVanGiaiDap.Visible == true)
            {
                panelTuVanGiaiDap.Visible = false;
            }

            if (panelDichVuHauMai.Visible == true)
            {
                panelDichVuHauMai.Visible = false;
            }

            if (panelXuLyKhieuNai.Visible == true)
            {
                panelXuLyKhieuNai.Visible = false;
            }

            if (panelBaoCaoThongKe.Visible == true)
            {
                panelBaoCaoThongKe.Visible = false;
            }


        }

        // Hiện Menu của các chức năng
        private void hienMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                anMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        #endregion ThietKeMenu
        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            hienMenu(panelDanhMuc);
        }

        #region DanhMuc

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            //

            //anMenu();
        }

        private void btnNhomKH_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinSP_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnCacUuDai_Click(object sender, EventArgs e)
        {

        }

        private void btnKHThanThiet_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {

        }

        private void btnLichSuTuVan_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinKhieuNai_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinDanhGiaKH_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {

        }
        #endregion DanhMuc

        private void btnTuVanGiaiDap_Click(object sender, EventArgs e)
        {
            hienMenu(panelTuVanGiaiDap);
        }
        #region TuVanGiaiDap
        private void btnTiepNhanYeuCau_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLyYeuCau_Click(object sender, EventArgs e)
        {

        }

        private void btnTheoDoiVaCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnChatbox_Click(object sender, EventArgs e)
        {

        }

        #endregion TuVanGiaiDap

        private void btnXuLyKhieuNai_Click(object sender, EventArgs e)
        {
            hienMenu(panelXuLyKhieuNai);
        }
        #region XuLyKhieuNai

        private void btnTiepNhanKhieuNai_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanHoiKhieuNai_Click(object sender, EventArgs e)
        {

        }

        private void btnTheoDoiTinhHinh_Click(object sender, EventArgs e)
        {

        }


        #endregion XuLyKhieuNai

        private void btnDichVuHauMai_Click(object sender, EventArgs e)
        {
            hienMenu(panelDichVuHauMai);
        }
        #region DichVuHauMai
        private void btnBaoHanhBaoTri_Click(object sender, EventArgs e)
        {

        }

        private void btnCTKHThanThiet_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhGiaCuaKH_Click(object sender, EventArgs e)
        {

        }

        #endregion DichVuHauMai

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            hienMenu(panelBaoCaoThongKe);
        }
        #region BaoCaoThongKe
        private void btnMucDoHaiLongKH_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanTichHVXHKH_Click(object sender, EventArgs e)
        {

        }

        private void btnKhieuNaiCuaKH_Click(object sender, EventArgs e)
        {

        }

        private void btnHieuQuaCTUuDai_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnHieuSuatNhanVien_Click(object sender, EventArgs e)
        {

        }
        #endregion BaoCaoThongKe

        private void lbNAN_Click(object sender, EventArgs e)
        {

        }
    }
}
