namespace Nhom03_v2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.lblMoTa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTenPL = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaPhanLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgrvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.lbNhapMaSP = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhapMaSP = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinNhanVien)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.lblMoTa);
            this.groupBox2.Controls.Add(this.lblTen);
            this.groupBox2.Controls.Add(this.cbTenPL);
            this.groupBox2.Controls.Add(this.cbbPhanLoai);
            this.groupBox2.Controls.Add(this.lblMaPhanLoai);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại sản phẩm";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(521, 96);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(318, 245);
            this.txtMoTa.TabIndex = 76;
            this.txtMoTa.Text = "";
            // 
            // lblMoTa
            // 
            this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
            this.lblMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(436, 96);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(59, 27);
            this.lblMoTa.TabIndex = 75;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(18, 169);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(140, 27);
            this.lblTen.TabIndex = 69;
            this.lblTen.Text = "Tên phân loại";
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
            // lblMaPhanLoai
            // 
            this.lblMaPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPhanLoai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhanLoai.Location = new System.Drawing.Point(18, 96);
            this.lblMaPhanLoai.Name = "lblMaPhanLoai";
            this.lblMaPhanLoai.Size = new System.Drawing.Size(108, 27);
            this.lblMaPhanLoai.TabIndex = 68;
            this.lblMaPhanLoai.Text = "Mã  loại SP\r\n\r\n";
            // 
            // dtgrvThongTinNhanVien
            // 
            this.dtgrvThongTinNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvThongTinNhanVien.Location = new System.Drawing.Point(29, 589);
            this.dtgrvThongTinNhanVien.Name = "dtgrvThongTinNhanVien";
            this.dtgrvThongTinNhanVien.RowHeadersWidth = 62;
            this.dtgrvThongTinNhanVien.RowTemplate.Height = 28;
            this.dtgrvThongTinNhanVien.Size = new System.Drawing.Size(929, 191);
            this.dtgrvThongTinNhanVien.TabIndex = 97;
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
            this.panelChucNang.Controls.Add(this.txtNhapMaSP);
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
            this.lbNhapMaSP.Size = new System.Drawing.Size(186, 25);
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
            // txtNhapMaSP
            // 
            this.txtNhapMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaSP.Location = new System.Drawing.Point(204, 27);
            this.txtNhapMaSP.Name = "txtNhapMaSP";
            this.txtNhapMaSP.Size = new System.Drawing.Size(200, 32);
            this.txtNhapMaSP.TabIndex = 64;
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
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 780);
            this.Controls.Add(this.dtgrvThongTinNhanVien);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLoaiSanPham";
            this.Text = "FormLoaiSanPham";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinNhanVien)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTen;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenPL;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhanLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaPhanLoai;
        private System.Windows.Forms.DataGridView dtgrvThongTinNhanVien;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label lbNhapMaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapMaSP;
    }
}