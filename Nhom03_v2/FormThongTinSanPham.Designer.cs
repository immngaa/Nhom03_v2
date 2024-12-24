namespace Nhom03_v2
{
    partial class FormThongTinSanPham
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
			this.grbThongTinSanPham = new System.Windows.Forms.GroupBox();
			this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.lbGia = new System.Windows.Forms.Label();
			this.lbMaLoaiSP = new System.Windows.Forms.Label();
			this.lbTenSP = new System.Windows.Forms.Label();
			this.lbMaSP = new System.Windows.Forms.Label();
			this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbbMaLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
			this.dtgrvThongTinSanPham = new System.Windows.Forms.DataGridView();
			this.panelChucNang = new System.Windows.Forms.Panel();
			this.lbNhapMaSP = new System.Windows.Forms.Label();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.txtNhapMaSP = new System.Windows.Forms.TextBox();
			this.lbThuongHieu = new System.Windows.Forms.Label();
			this.cbbThuongHieu = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.grbThongTinSanPham.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinSanPham)).BeginInit();
			this.panelChucNang.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbThongTinSanPham
			// 
			this.grbThongTinSanPham.Controls.Add(this.cbbThuongHieu);
			this.grbThongTinSanPham.Controls.Add(this.lbThuongHieu);
			this.grbThongTinSanPham.Controls.Add(this.rtxtMoTa);
			this.grbThongTinSanPham.Controls.Add(this.lbMoTa);
			this.grbThongTinSanPham.Controls.Add(this.lbGia);
			this.grbThongTinSanPham.Controls.Add(this.lbMaLoaiSP);
			this.grbThongTinSanPham.Controls.Add(this.lbTenSP);
			this.grbThongTinSanPham.Controls.Add(this.lbMaSP);
			this.grbThongTinSanPham.Controls.Add(this.txtGia);
			this.grbThongTinSanPham.Controls.Add(this.cbbMaLoaiSP);
			this.grbThongTinSanPham.Controls.Add(this.txtTenSP);
			this.grbThongTinSanPham.Controls.Add(this.txtMaSP);
			this.grbThongTinSanPham.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbThongTinSanPham.Location = new System.Drawing.Point(37, 30);
			this.grbThongTinSanPham.Margin = new System.Windows.Forms.Padding(2);
			this.grbThongTinSanPham.Name = "grbThongTinSanPham";
			this.grbThongTinSanPham.Padding = new System.Windows.Forms.Padding(2);
			this.grbThongTinSanPham.Size = new System.Drawing.Size(929, 374);
			this.grbThongTinSanPham.TabIndex = 1;
			this.grbThongTinSanPham.TabStop = false;
			this.grbThongTinSanPham.Text = "Thông tin sản phẩm";
			// 
			// rtxtMoTa
			// 
			this.rtxtMoTa.Location = new System.Drawing.Point(569, 157);
			this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(2);
			this.rtxtMoTa.Name = "rtxtMoTa";
			this.rtxtMoTa.Size = new System.Drawing.Size(280, 180);
			this.rtxtMoTa.TabIndex = 61;
			this.rtxtMoTa.Text = "";
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(435, 157);
			this.lbMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(90, 32);
			this.lbMoTa.TabIndex = 60;
			this.lbMoTa.Text = "Mô tả";
			// 
			// lbGia
			// 
			this.lbGia.AutoSize = true;
			this.lbGia.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGia.Location = new System.Drawing.Point(435, 84);
			this.lbGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbGia.Name = "lbGia";
			this.lbGia.Size = new System.Drawing.Size(161, 32);
			this.lbGia.TabIndex = 60;
			this.lbGia.Text = "Giá ( VNĐ)";
			// 
			// lbMaLoaiSP
			// 
			this.lbMaLoaiSP.AutoSize = true;
			this.lbMaLoaiSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaLoaiSP.Location = new System.Drawing.Point(5, 206);
			this.lbMaLoaiSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMaLoaiSP.Name = "lbMaLoaiSP";
			this.lbMaLoaiSP.Size = new System.Drawing.Size(153, 32);
			this.lbMaLoaiSP.TabIndex = 60;
			this.lbMaLoaiSP.Text = "Mã loại SP";
			// 
			// lbTenSP
			// 
			this.lbTenSP.AutoSize = true;
			this.lbTenSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenSP.Location = new System.Drawing.Point(4, 132);
			this.lbTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTenSP.Name = "lbTenSP";
			this.lbTenSP.Size = new System.Drawing.Size(207, 32);
			this.lbTenSP.TabIndex = 60;
			this.lbTenSP.Text = "Tên sản phẩm";
			// 
			// lbMaSP
			// 
			this.lbMaSP.AutoSize = true;
			this.lbMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaSP.Location = new System.Drawing.Point(5, 73);
			this.lbMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMaSP.Name = "lbMaSP";
			this.lbMaSP.Size = new System.Drawing.Size(196, 32);
			this.lbMaSP.TabIndex = 59;
			this.lbMaSP.Text = "Mã sản phẩm";
			// 
			// txtGia
			// 
			this.txtGia.BackColor = System.Drawing.Color.Transparent;
			this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGia.DefaultText = "";
			this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGia.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGia.Location = new System.Drawing.Point(569, 81);
			this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGia.Name = "txtGia";
			this.txtGia.PasswordChar = '\0';
			this.txtGia.PlaceholderText = "";
			this.txtGia.SelectedText = "";
			this.txtGia.Size = new System.Drawing.Size(280, 30);
			this.txtGia.TabIndex = 58;
			// 
			// cbbMaLoaiSP
			// 
			this.cbbMaLoaiSP.BackColor = System.Drawing.Color.Transparent;
			this.cbbMaLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbMaLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbMaLoaiSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbbMaLoaiSP.ItemHeight = 30;
			this.cbbMaLoaiSP.Items.AddRange(new object[] {
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
            "DM012 ",
            ""});
			this.cbbMaLoaiSP.Location = new System.Drawing.Point(196, 202);
			this.cbbMaLoaiSP.Margin = new System.Windows.Forms.Padding(2);
			this.cbbMaLoaiSP.Name = "cbbMaLoaiSP";
			this.cbbMaLoaiSP.Size = new System.Drawing.Size(186, 36);
			this.cbbMaLoaiSP.TabIndex = 57;
			// 
			// txtTenSP
			// 
			this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenSP.DefaultText = "";
			this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSP.Location = new System.Drawing.Point(196, 127);
			this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.PasswordChar = '\0';
			this.txtTenSP.PlaceholderText = "";
			this.txtTenSP.SelectedText = "";
			this.txtTenSP.Size = new System.Drawing.Size(184, 30);
			this.txtTenSP.TabIndex = 51;
			// 
			// txtMaSP
			// 
			this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaSP.DefaultText = "";
			this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaSP.Location = new System.Drawing.Point(196, 75);
			this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.PasswordChar = '\0';
			this.txtMaSP.PlaceholderText = "";
			this.txtMaSP.SelectedText = "";
			this.txtMaSP.Size = new System.Drawing.Size(184, 30);
			this.txtMaSP.TabIndex = 48;
			// 
			// dtgrvThongTinSanPham
			// 
			this.dtgrvThongTinSanPham.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvThongTinSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvThongTinSanPham.Location = new System.Drawing.Point(37, 573);
			this.dtgrvThongTinSanPham.Name = "dtgrvThongTinSanPham";
			this.dtgrvThongTinSanPham.RowHeadersWidth = 62;
			this.dtgrvThongTinSanPham.RowTemplate.Height = 28;
			this.dtgrvThongTinSanPham.Size = new System.Drawing.Size(929, 191);
			this.dtgrvThongTinSanPham.TabIndex = 95;

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
			this.panelChucNang.Location = new System.Drawing.Point(37, 435);
			this.panelChucNang.Name = "panelChucNang";
			this.panelChucNang.Size = new System.Drawing.Size(929, 87);
			this.panelChucNang.TabIndex = 94;
			// 
			// lbNhapMaSP
			// 
			this.lbNhapMaSP.AutoSize = true;
			this.lbNhapMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhapMaSP.Location = new System.Drawing.Point(12, 31);
			this.lbNhapMaSP.Name = "lbNhapMaSP";
			this.lbNhapMaSP.Size = new System.Drawing.Size(180, 32);
			this.lbNhapMaSP.TabIndex = 71;
			this.lbNhapMaSP.Text = "Nhập mã SP";
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
			this.txtNhapMaSP.Location = new System.Drawing.Point(186, 27);
			this.txtNhapMaSP.Name = "txtNhapMaSP";
			this.txtNhapMaSP.Size = new System.Drawing.Size(218, 40);
			this.txtNhapMaSP.TabIndex = 64;
			// 
			// lbThuongHieu
			// 
			this.lbThuongHieu.AutoSize = true;
			this.lbThuongHieu.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThuongHieu.Location = new System.Drawing.Point(5, 282);
			this.lbThuongHieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbThuongHieu.Name = "lbThuongHieu";
			this.lbThuongHieu.Size = new System.Drawing.Size(183, 32);
			this.lbThuongHieu.TabIndex = 63;
			this.lbThuongHieu.Text = "Thương hiệu";
			// 
			// cbbThuongHieu
			// 
			this.cbbThuongHieu.BackColor = System.Drawing.Color.Transparent;
			this.cbbThuongHieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbThuongHieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbThuongHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbThuongHieu.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbThuongHieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbbThuongHieu.ItemHeight = 30;
			this.cbbThuongHieu.Items.AddRange(new object[] {
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
            "DM012 ",
            ""});
			this.cbbThuongHieu.Location = new System.Drawing.Point(196, 282);
			this.cbbThuongHieu.Margin = new System.Windows.Forms.Padding(2);
			this.cbbThuongHieu.Name = "cbbThuongHieu";
			this.cbbThuongHieu.Size = new System.Drawing.Size(186, 36);
			this.cbbThuongHieu.TabIndex = 64;
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
			// FormThongTinSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 780);
			this.Controls.Add(this.dtgrvThongTinSanPham);
			this.Controls.Add(this.panelChucNang);
			this.Controls.Add(this.grbThongTinSanPham);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FormThongTinSanPham";
			this.Text = "FormThongTinSanPham";
			this.grbThongTinSanPham.ResumeLayout(false);
			this.grbThongTinSanPham.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinSanPham)).EndInit();
			this.panelChucNang.ResumeLayout(false);
			this.panelChucNang.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinSanPham;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaLoaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dtgrvThongTinSanPham;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label lbNhapMaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapMaSP;
		private Guna.UI2.WinForms.Guna2ComboBox cbbThuongHieu;
		private System.Windows.Forms.Label lbThuongHieu;
	}
}