﻿namespace Nhom03_v2
{
    partial class FormLoaiSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.grbLoaiSP = new System.Windows.Forms.GroupBox();
			this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
			this.lbMoTa = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbTenLoáiP = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cbTenPL = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbbPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbMaPhanLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dtgrvLoaiSP = new System.Windows.Forms.DataGridView();
			this.panelChucNang = new System.Windows.Forms.Panel();
			this.lbNhapMaSP = new System.Windows.Forms.Label();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.txtNhapMaphanLoai = new System.Windows.Forms.TextBox();
			this.grbLoaiSP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvLoaiSP)).BeginInit();
			this.panelChucNang.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbLoaiSP
			// 
			this.grbLoaiSP.Controls.Add(this.rtxtMoTa);
			this.grbLoaiSP.Controls.Add(this.lbMoTa);
			this.grbLoaiSP.Controls.Add(this.lbTenLoáiP);
			this.grbLoaiSP.Controls.Add(this.cbTenPL);
			this.grbLoaiSP.Controls.Add(this.cbbPhanLoai);
			this.grbLoaiSP.Controls.Add(this.lbMaPhanLoai);
			this.grbLoaiSP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbLoaiSP.Location = new System.Drawing.Point(29, 37);
			this.grbLoaiSP.Name = "grbLoaiSP";
			this.grbLoaiSP.Size = new System.Drawing.Size(929, 380);
			this.grbLoaiSP.TabIndex = 1;
			this.grbLoaiSP.TabStop = false;
			this.grbLoaiSP.Text = "Loại sản phẩm";
			// 
			// rtxtMoTa
			// 
			this.rtxtMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtMoTa.Location = new System.Drawing.Point(521, 96);
			this.rtxtMoTa.Name = "rtxtMoTa";
			this.rtxtMoTa.Size = new System.Drawing.Size(318, 245);
			this.rtxtMoTa.TabIndex = 76;
			this.rtxtMoTa.Text = "";
			// 
			// lbMoTa
			// 
			this.lbMoTa.BackColor = System.Drawing.Color.Transparent;
			this.lbMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(436, 96);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(79, 34);
			this.lbMoTa.TabIndex = 75;
			this.lbMoTa.Text = "Mô tả";
			// 
			// lbTenLoáiP
			// 
			this.lbTenLoáiP.BackColor = System.Drawing.Color.Transparent;
			this.lbTenLoáiP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenLoáiP.Location = new System.Drawing.Point(18, 169);
			this.lbTenLoáiP.Name = "lbTenLoáiP";
			this.lbTenLoáiP.Size = new System.Drawing.Size(186, 34);
			this.lbTenLoáiP.TabIndex = 69;
			this.lbTenLoáiP.Text = "Tên phân loại";
			// 
			// cbTenPL
			// 
			this.cbTenPL.BackColor = System.Drawing.Color.Transparent;
			this.cbTenPL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTenPL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTenPL.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTenPL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTenPL.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbTenPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.cbTenPL.ItemHeight = 30;
			this.cbTenPL.Items.AddRange(new object[] {
            "Laptop",
            "Điện thoại di động",
            "Máy tính bảng",
            "Máy tính để bàn",
            "Linh kiện máy tính (RAM, CPU, GPU,...)",
            " Phụ kiện công nghệ (chuột, bàn phím, tai nghe,...)",
            "Thiết bị mạng (Router, Switch, Modem,...)",
            "Máy ảnh & Thiết bị quay phim",
            "Thiết bị lưu trữ (Ổ cứng, USB, SSD,...)",
            "Màn hình & Máy chiếu",
            "Đồng hồ thông minh (Smartwatch)",
            "Đồ gia dụng"});
			this.cbTenPL.Location = new System.Drawing.Point(169, 169);
			this.cbTenPL.Name = "cbTenPL";
			this.cbTenPL.Size = new System.Drawing.Size(200, 36);
			this.cbTenPL.TabIndex = 72;
			// 
			// cbbPhanLoai
			// 
			this.cbbPhanLoai.BackColor = System.Drawing.Color.Transparent;
			this.cbbPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbPhanLoai.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.cbbPhanLoai.ItemHeight = 30;
			this.cbbPhanLoai.Items.AddRange(new object[] {
            "DM001 ",
            "DM002 ",
            "DM003 ",
            "DM004 ",
            "DM005 ",
            "DM006 ",
            "DM007 ",
            "DM008",
            "DM009 ",
            "DM010 ",
            "DM011 ",
            "DM012 "});
			this.cbbPhanLoai.Location = new System.Drawing.Point(169, 96);
			this.cbbPhanLoai.Name = "cbbPhanLoai";
			this.cbbPhanLoai.Size = new System.Drawing.Size(200, 36);
			this.cbbPhanLoai.TabIndex = 71;
			// 
			// lbMaPhanLoai
			// 
			this.lbMaPhanLoai.BackColor = System.Drawing.Color.Transparent;
			this.lbMaPhanLoai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaPhanLoai.Location = new System.Drawing.Point(18, 96);
			this.lbMaPhanLoai.Name = "lbMaPhanLoai";
			this.lbMaPhanLoai.Size = new System.Drawing.Size(142, 34);
			this.lbMaPhanLoai.TabIndex = 68;
			this.lbMaPhanLoai.Text = "Mã  loại SP\r\n\r\n";
			// 
			// dtgrvLoaiSP
			// 
			this.dtgrvLoaiSP.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvLoaiSP.Location = new System.Drawing.Point(29, 589);
			this.dtgrvLoaiSP.Name = "dtgrvLoaiSP";
			this.dtgrvLoaiSP.RowHeadersWidth = 62;
			this.dtgrvLoaiSP.RowTemplate.Height = 28;
			this.dtgrvLoaiSP.Size = new System.Drawing.Size(929, 191);
			this.dtgrvLoaiSP.TabIndex = 97;
			// 
			// panelChucNang
			// 
			this.panelChucNang.BackColor = System.Drawing.Color.Transparent;
			this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelChucNang.Controls.Add(this.lbNhapMaSP);
			this.panelChucNang.Controls.Add(this.btnXoa);
			this.panelChucNang.Controls.Add(this.btnThem);
			this.panelChucNang.Controls.Add(this.btnSua);
			this.panelChucNang.Controls.Add(this.btnTimKiem);
			this.panelChucNang.Controls.Add(this.txtNhapMaphanLoai);
			this.panelChucNang.Location = new System.Drawing.Point(29, 451);
			this.panelChucNang.Name = "panelChucNang";
			this.panelChucNang.Size = new System.Drawing.Size(929, 87);
			this.panelChucNang.TabIndex = 96;
			// 
			// lbNhapMaSP
			// 
			this.lbNhapMaSP.AutoSize = true;
			this.lbNhapMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhapMaSP.Location = new System.Drawing.Point(12, 31);
			this.lbNhapMaSP.Name = "lbNhapMaSP";
			this.lbNhapMaSP.Size = new System.Drawing.Size(236, 32);
			this.lbNhapMaSP.TabIndex = 71;
			this.lbNhapMaSP.Text = "Nhập mã loại SP";
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.BorderColor = System.Drawing.Color.Transparent;
			this.btnXoa.BorderRadius = 20;
			this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnXoa.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(768, 21);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(116, 45);
			this.btnXoa.TabIndex = 68;
			this.btnXoa.Text = "Xoá";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Transparent;
			this.btnThem.BorderColor = System.Drawing.Color.Transparent;
			this.btnThem.BorderRadius = 20;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnThem.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(520, 21);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(116, 45);
			this.btnThem.TabIndex = 69;
			this.btnThem.Text = "Thêm";
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Transparent;
			this.btnSua.BorderColor = System.Drawing.Color.Transparent;
			this.btnSua.BorderRadius = 20;
			this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnSua.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(642, 21);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(116, 45);
			this.btnSua.TabIndex = 70;
			this.btnSua.Text = "Sửa";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
			this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
			this.btnTimKiem.BorderRadius = 20;
			this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnTimKiem.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Image = global::Nhom03_v2.Properties.Resources.TimKiem;
			this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
			this.btnTimKiem.Location = new System.Drawing.Point(424, 21);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(76, 45);
			this.btnTimKiem.TabIndex = 67;
			// 
			// txtNhapMaphanLoai
			// 
			this.txtNhapMaphanLoai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNhapMaphanLoai.Location = new System.Drawing.Point(204, 27);
			this.txtNhapMaphanLoai.Name = "txtNhapMaphanLoai";
			this.txtNhapMaphanLoai.Size = new System.Drawing.Size(200, 40);
			this.txtNhapMaphanLoai.TabIndex = 64;
			// 
			// FormLoaiSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 780);
			this.Controls.Add(this.dtgrvLoaiSP);
			this.Controls.Add(this.panelChucNang);
			this.Controls.Add(this.grbLoaiSP);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FormLoaiSanPham";
			this.Text = "FormLoaiSanPham";
			this.grbLoaiSP.ResumeLayout(false);
			this.grbLoaiSP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvLoaiSP)).EndInit();
			this.panelChucNang.ResumeLayout(false);
			this.panelChucNang.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoaiSP;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTenLoáiP;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenPL;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhanLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMaPhanLoai;
        private System.Windows.Forms.DataGridView dtgrvLoaiSP;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label lbNhapMaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapMaphanLoai;
    }
}