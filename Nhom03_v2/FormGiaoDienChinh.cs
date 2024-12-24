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
        private Form formCon;
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

        //Hàm mở form con trên form cha
        private void moFormCon(Form conForm)
        {
            
            if (formCon != null)
            {
                formCon.Close();    
            } 
            formCon = conForm;
            conForm.TopLevel = false;
            conForm.FormBorderStyle = FormBorderStyle.None;
            conForm.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(conForm);
            panelTrungTam.Tag = conForm;
            conForm.BringToFront();
            conForm.Show();

                
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
            moFormCon(new FormThongTinKH());
            lbThayDoiTheoMenu.Text = btnThongTinKH.Text;

            anMenu();
        }

        private void btnNhomKH_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhomKH());
            lbThayDoiTheoMenu.Text = btnNhomKH.Text;

            anMenu();
        }

        private void btnThongTinSP_Click(object sender, EventArgs e)
        {
            moFormCon(new FormThongTinSanPham());
            lbThayDoiTheoMenu.Text = btnThongTinSP.Text;

            anMenu();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            moFormCon(new FormLoaiSanPham());
            lbThayDoiTheoMenu.Text = btnLoaiSanPham.Text;

            anMenu();
        }

        private void btnThongTinDonHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormThongTinDonHang());
            lbThayDoiTheoMenu.Text = btnThongTinDonHang.Text;

            anMenu();
        }

        private void btnCacUuDai_Click(object sender, EventArgs e)
        {
            moFormCon(new FormCacUuDai());
            lbThayDoiTheoMenu.Text = btnCacUuDai.Text;

            anMenu();
        }

        private void btnKHThanThiet_Click(object sender, EventArgs e)
        {
            moFormCon(new FormCTKHThanThiet());
            lbThayDoiTheoMenu.Text = btnKHThanThiet.Text;

            anMenu();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            moFormCon(new FormBaoHanh());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;

            anMenu();
        }

        private void btnLichSuTuVan_Click(object sender, EventArgs e)
        {
            moFormCon(new FormLichSuTuVan());
            lbThayDoiTheoMenu.Text = btnLichSuTuVan.Text;

            anMenu();
        }

        private void btnThongTinKhieuNai_Click(object sender, EventArgs e)
        {
            moFormCon(new FormThongTinKhieuNai());
            lbThayDoiTheoMenu.Text = btnThongTinKhieuNai.Text;

            anMenu();
        }

        private void btnThongTinDanhGiaKH_Click(object sender, EventArgs e)
        {
            moFormCon(new FormThongTinDanhGiaKH());
            lbThayDoiTheoMenu.Text = btnThongTinDanhGiaKH.Text;

            anMenu();
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            moFormCon(new FormThongTinNhanVien());
            lbThayDoiTheoMenu.Text = btnThongTinNhanVien.Text;

            anMenu();
        }
        #endregion DanhMuc

        private void btnTuVanGiaiDap_Click(object sender, EventArgs e)
        {
            hienMenu(panelTuVanGiaiDap);
        }
        #region TuVanGiaiDap
        private void btnTiepNhanYeuCau_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnXuLyYeuCau_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnTheoDoiVaCapNhat_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnChatbox_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        #endregion TuVanGiaiDap

        private void btnXuLyKhieuNai_Click(object sender, EventArgs e)
        {
            hienMenu(panelXuLyKhieuNai);
        }
        #region XuLyKhieuNai

        private void btnTiepNhanKhieuNai_Click(object sender, EventArgs e)
        {
            moFormCon(new FormTiepNhanKhieuNai());
            lbThayDoiTheoMenu.Text = btnTiepNhanKhieuNai.Text;

            anMenu();

        }

        private void btnPhanHoiKhieuNai_Click(object sender, EventArgs e)
        {
            moFormCon(new FormPhanHoiKhieuNai());
            lbThayDoiTheoMenu.Text = btnPhanHoiKhieuNai.Text;

            anMenu();
        }

        private void btnTheoDoiTinhHinh_Click(object sender, EventArgs e)
        {
            moFormCon(new FormTheoDoiTinhHinh());
            lbThayDoiTheoMenu.Text = btnTheoDoiTinhHinh.Text;

            anMenu();
        }


        #endregion XuLyKhieuNai

        private void btnDichVuHauMai_Click(object sender, EventArgs e)
        {
            hienMenu(panelDichVuHauMai);
        }
        #region DichVuHauMai
        private void btnBaoHanhBaoTri_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnCTKHThanThiet_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnDanhGiaCuaKH_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        #endregion DichVuHauMai

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            hienMenu(panelBaoCaoThongKe);
        }
        #region BaoCaoThongKe
        private void btnMucDoHaiLongKH_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnPhanTichHVXHKH_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnKhieuNaiCuaKH_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnHieuQuaCTUuDai_Click(object sender, EventArgs e)
        {
            /*
            moFormCon(new FormTiepNhanYeuCau());
            lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
            */
            anMenu();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            
            moFormCon(new FormThongKeDoanhThu());
            lbThayDoiTheoMenu.Text = btnThongKeDoanhThu.Text;
            
            anMenu();
        }

        private void btnHieuSuatNhanVien_Click(object sender, EventArgs e)
        {
            
            moFormCon(new FormHieuSuatNhanVien());
            lbThayDoiTheoMenu.Text = btnHieuSuatNhanVien.Text;
            
            anMenu();
        }
        #endregion BaoCaoThongKe

        private void lbNAN_Click(object sender, EventArgs e)
        {

        }
    }
}
