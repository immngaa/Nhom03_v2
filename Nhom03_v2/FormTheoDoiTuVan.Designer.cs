namespace Nhom03_v2
{
	partial class FormTheoDoiTuVan
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
			this.dtgrvTheoDoiYeuCau = new System.Windows.Forms.DataGridView();
			this.lbDaXuLy = new System.Windows.Forms.Label();
			this.numDaXuLy = new System.Windows.Forms.NumericUpDown();
			this.lbChuaXuLy = new System.Windows.Forms.Label();
			this.numChuaXuLy = new System.Windows.Forms.NumericUpDown();
			this.lbTong = new System.Windows.Forms.Label();
			this.numTong = new System.Windows.Forms.NumericUpDown();
			this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
			this.gbTheoDoiTuVan = new System.Windows.Forms.GroupBox();
			this.lbNgayTuVan = new System.Windows.Forms.Label();
			this.dtpNgayTuVan = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.rtxtNoiDungYeuCau = new System.Windows.Forms.RichTextBox();
			this.lbNoiDungYeuCau = new System.Windows.Forms.Label();
			this.lbTrangThai = new System.Windows.Forms.Label();
			this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbLoaiYeuCau = new System.Windows.Forms.Label();
			this.cbbLoaiYeuCau = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbMaNV = new System.Windows.Forms.Label();
			this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMaKH = new System.Windows.Forms.Label();
			this.lbMaYeuCau = new System.Windows.Forms.Label();
			this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMaYeuCau = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvTheoDoiYeuCau)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaXuLy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numChuaXuLy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTong)).BeginInit();
			this.gbTheoDoiTuVan.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgrvTheoDoiYeuCau
			// 
			this.dtgrvTheoDoiYeuCau.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvTheoDoiYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvTheoDoiYeuCau.Location = new System.Drawing.Point(9, 80);
			this.dtgrvTheoDoiYeuCau.Name = "dtgrvTheoDoiYeuCau";
			this.dtgrvTheoDoiYeuCau.RowHeadersWidth = 62;
			this.dtgrvTheoDoiYeuCau.RowTemplate.Height = 28;
			this.dtgrvTheoDoiYeuCau.Size = new System.Drawing.Size(1067, 350);
			this.dtgrvTheoDoiYeuCau.TabIndex = 174;
			// 
			// lbDaXuLy
			// 
			this.lbDaXuLy.AutoSize = true;
			this.lbDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDaXuLy.Location = new System.Drawing.Point(590, 25);
			this.lbDaXuLy.Name = "lbDaXuLy";
			this.lbDaXuLy.Size = new System.Drawing.Size(111, 31);
			this.lbDaXuLy.TabIndex = 173;
			this.lbDaXuLy.Text = "Đã xử lý";
			// 
			// numDaXuLy
			// 
			this.numDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numDaXuLy.Location = new System.Drawing.Point(716, 23);
			this.numDaXuLy.Name = "numDaXuLy";
			this.numDaXuLy.Size = new System.Drawing.Size(120, 38);
			this.numDaXuLy.TabIndex = 172;
			// 
			// lbChuaXuLy
			// 
			this.lbChuaXuLy.AutoSize = true;
			this.lbChuaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChuaXuLy.Location = new System.Drawing.Point(236, 30);
			this.lbChuaXuLy.Name = "lbChuaXuLy";
			this.lbChuaXuLy.Size = new System.Drawing.Size(141, 31);
			this.lbChuaXuLy.TabIndex = 171;
			this.lbChuaXuLy.Text = "Chưa xử lý";
			// 
			// numChuaXuLy
			// 
			this.numChuaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numChuaXuLy.Location = new System.Drawing.Point(383, 23);
			this.numChuaXuLy.Name = "numChuaXuLy";
			this.numChuaXuLy.Size = new System.Drawing.Size(120, 38);
			this.numChuaXuLy.TabIndex = 170;
			// 
			// lbTong
			// 
			this.lbTong.AutoSize = true;
			this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTong.Location = new System.Drawing.Point(11, 30);
			this.lbTong.Name = "lbTong";
			this.lbTong.Size = new System.Drawing.Size(76, 31);
			this.lbTong.TabIndex = 169;
			this.lbTong.Text = "Tổng";
			// 
			// numTong
			// 
			this.numTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numTong.Location = new System.Drawing.Point(93, 23);
			this.numTong.Name = "numTong";
			this.numTong.Size = new System.Drawing.Size(120, 38);
			this.numTong.TabIndex = 168;
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
			this.btnCapNhat.BorderColor = System.Drawing.Color.Transparent;
			this.btnCapNhat.BorderRadius = 20;
			this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnCapNhat.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnCapNhat.ForeColor = System.Drawing.Color.White;
			this.btnCapNhat.Location = new System.Drawing.Point(455, 264);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(243, 45);
			this.btnCapNhat.TabIndex = 175;
			this.btnCapNhat.Text = "Cập nhật";
			// 
			// gbTheoDoiTuVan
			// 
			this.gbTheoDoiTuVan.Controls.Add(this.btnCapNhat);
			this.gbTheoDoiTuVan.Controls.Add(this.lbNgayTuVan);
			this.gbTheoDoiTuVan.Controls.Add(this.dtpNgayTuVan);
			this.gbTheoDoiTuVan.Controls.Add(this.rtxtNoiDungYeuCau);
			this.gbTheoDoiTuVan.Controls.Add(this.lbNoiDungYeuCau);
			this.gbTheoDoiTuVan.Controls.Add(this.lbTrangThai);
			this.gbTheoDoiTuVan.Controls.Add(this.cbbTrangThai);
			this.gbTheoDoiTuVan.Controls.Add(this.lbLoaiYeuCau);
			this.gbTheoDoiTuVan.Controls.Add(this.cbbLoaiYeuCau);
			this.gbTheoDoiTuVan.Controls.Add(this.lbMaNV);
			this.gbTheoDoiTuVan.Controls.Add(this.txtMaNV);
			this.gbTheoDoiTuVan.Controls.Add(this.lbMaKH);
			this.gbTheoDoiTuVan.Controls.Add(this.lbMaYeuCau);
			this.gbTheoDoiTuVan.Controls.Add(this.txtMaKH);
			this.gbTheoDoiTuVan.Controls.Add(this.txtMaYeuCau);
			this.gbTheoDoiTuVan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTheoDoiTuVan.Location = new System.Drawing.Point(9, 446);
			this.gbTheoDoiTuVan.Name = "gbTheoDoiTuVan";
			this.gbTheoDoiTuVan.Size = new System.Drawing.Size(1047, 412);
			this.gbTheoDoiTuVan.TabIndex = 176;
			this.gbTheoDoiTuVan.TabStop = false;
			this.gbTheoDoiTuVan.Text = "Theo dõi tư vấn";
			// 
			// lbNgayTuVan
			// 
			this.lbNgayTuVan.AutoSize = true;
			this.lbNgayTuVan.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNgayTuVan.Location = new System.Drawing.Point(445, 195);
			this.lbNgayTuVan.Name = "lbNgayTuVan";
			this.lbNgayTuVan.Size = new System.Drawing.Size(181, 32);
			this.lbNgayTuVan.TabIndex = 198;
			this.lbNgayTuVan.Text = "Ngày tư vấn";
			// 
			// dtpNgayTuVan
			// 
			this.dtpNgayTuVan.BackColor = System.Drawing.Color.Transparent;
			this.dtpNgayTuVan.BorderColor = System.Drawing.Color.Transparent;
			this.dtpNgayTuVan.Checked = true;
			this.dtpNgayTuVan.FillColor = System.Drawing.Color.Transparent;
			this.dtpNgayTuVan.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.dtpNgayTuVan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpNgayTuVan.Location = new System.Drawing.Point(687, 184);
			this.dtpNgayTuVan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpNgayTuVan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpNgayTuVan.Name = "dtpNgayTuVan";
			this.dtpNgayTuVan.Size = new System.Drawing.Size(213, 32);
			this.dtpNgayTuVan.TabIndex = 197;
			this.dtpNgayTuVan.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
			// 
			// rtxtNoiDungYeuCau
			// 
			this.rtxtNoiDungYeuCau.Location = new System.Drawing.Point(259, 264);
			this.rtxtNoiDungYeuCau.Name = "rtxtNoiDungYeuCau";
			this.rtxtNoiDungYeuCau.Size = new System.Drawing.Size(171, 130);
			this.rtxtNoiDungYeuCau.TabIndex = 196;
			this.rtxtNoiDungYeuCau.Text = "";
			// 
			// lbNoiDungYeuCau
			// 
			this.lbNoiDungYeuCau.AutoSize = true;
			this.lbNoiDungYeuCau.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoiDungYeuCau.Location = new System.Drawing.Point(11, 264);
			this.lbNoiDungYeuCau.Name = "lbNoiDungYeuCau";
			this.lbNoiDungYeuCau.Size = new System.Drawing.Size(251, 32);
			this.lbNoiDungYeuCau.TabIndex = 195;
			this.lbNoiDungYeuCau.Text = "Nội dung yêu cầu";
			// 
			// lbTrangThai
			// 
			this.lbTrangThai.AutoSize = true;
			this.lbTrangThai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTrangThai.Location = new System.Drawing.Point(449, 123);
			this.lbTrangThai.Name = "lbTrangThai";
			this.lbTrangThai.Size = new System.Drawing.Size(151, 32);
			this.lbTrangThai.TabIndex = 194;
			this.lbTrangThai.Text = "Trạng thái";
			// 
			// cbbTrangThai
			// 
			this.cbbTrangThai.BackColor = System.Drawing.Color.Transparent;
			this.cbbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbTrangThai.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbTrangThai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbbTrangThai.ItemHeight = 30;
			this.cbbTrangThai.Items.AddRange(new object[] {
            "NKH01",
            "NKH02",
            "NKH03",
            "NKH04",
            "NKH05"});
			this.cbbTrangThai.Location = new System.Drawing.Point(687, 121);
			this.cbbTrangThai.Name = "cbbTrangThai";
			this.cbbTrangThai.Size = new System.Drawing.Size(140, 36);
			this.cbbTrangThai.TabIndex = 193;
			// 
			// lbLoaiYeuCau
			// 
			this.lbLoaiYeuCau.AutoSize = true;
			this.lbLoaiYeuCau.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLoaiYeuCau.Location = new System.Drawing.Point(449, 49);
			this.lbLoaiYeuCau.Name = "lbLoaiYeuCau";
			this.lbLoaiYeuCau.Size = new System.Drawing.Size(184, 32);
			this.lbLoaiYeuCau.TabIndex = 192;
			this.lbLoaiYeuCau.Text = "Loại yêu cầu";
			// 
			// cbbLoaiYeuCau
			// 
			this.cbbLoaiYeuCau.BackColor = System.Drawing.Color.Transparent;
			this.cbbLoaiYeuCau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbLoaiYeuCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbLoaiYeuCau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbLoaiYeuCau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbLoaiYeuCau.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbLoaiYeuCau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbbLoaiYeuCau.ItemHeight = 30;
			this.cbbLoaiYeuCau.Items.AddRange(new object[] {
            "NKH01",
            "NKH02",
            "NKH03",
            "NKH04",
            "NKH05"});
			this.cbbLoaiYeuCau.Location = new System.Drawing.Point(687, 37);
			this.cbbLoaiYeuCau.Name = "cbbLoaiYeuCau";
			this.cbbLoaiYeuCau.Size = new System.Drawing.Size(140, 36);
			this.cbbLoaiYeuCau.TabIndex = 191;
			// 
			// lbMaNV
			// 
			this.lbMaNV.AutoSize = true;
			this.lbMaNV.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNV.Location = new System.Drawing.Point(14, 192);
			this.lbMaNV.Name = "lbMaNV";
			this.lbMaNV.Size = new System.Drawing.Size(196, 32);
			this.lbMaNV.TabIndex = 190;
			this.lbMaNV.Text = "Mã nhân viên";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaNV.DefaultText = "";
			this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaNV.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaNV.Location = new System.Drawing.Point(259, 192);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(6);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.PasswordChar = '\0';
			this.txtMaNV.PlaceholderText = "";
			this.txtMaNV.SelectedText = "";
			this.txtMaNV.Size = new System.Drawing.Size(171, 32);
			this.txtMaNV.TabIndex = 189;
			this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbMaKH
			// 
			this.lbMaKH.AutoSize = true;
			this.lbMaKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaKH.Location = new System.Drawing.Point(14, 123);
			this.lbMaKH.Name = "lbMaKH";
			this.lbMaKH.Size = new System.Drawing.Size(220, 32);
			this.lbMaKH.TabIndex = 188;
			this.lbMaKH.Text = "Mã khách hàng";
			// 
			// lbMaYeuCau
			// 
			this.lbMaYeuCau.AutoSize = true;
			this.lbMaYeuCau.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaYeuCau.Location = new System.Drawing.Point(14, 49);
			this.lbMaYeuCau.Name = "lbMaYeuCau";
			this.lbMaYeuCau.Size = new System.Drawing.Size(169, 32);
			this.lbMaYeuCau.TabIndex = 187;
			this.lbMaYeuCau.Text = "Mã yêu cầu";
			// 
			// txtMaKH
			// 
			this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaKH.DefaultText = "";
			this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaKH.Location = new System.Drawing.Point(259, 123);
			this.txtMaKH.Margin = new System.Windows.Forms.Padding(6);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.PasswordChar = '\0';
			this.txtMaKH.PlaceholderText = "";
			this.txtMaKH.SelectedText = "";
			this.txtMaKH.Size = new System.Drawing.Size(171, 32);
			this.txtMaKH.TabIndex = 186;
			this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMaYeuCau
			// 
			this.txtMaYeuCau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaYeuCau.DefaultText = "";
			this.txtMaYeuCau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaYeuCau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaYeuCau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaYeuCau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaYeuCau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaYeuCau.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaYeuCau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMaYeuCau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaYeuCau.Location = new System.Drawing.Point(259, 49);
			this.txtMaYeuCau.Margin = new System.Windows.Forms.Padding(6);
			this.txtMaYeuCau.Name = "txtMaYeuCau";
			this.txtMaYeuCau.PasswordChar = '\0';
			this.txtMaYeuCau.PlaceholderText = "";
			this.txtMaYeuCau.SelectedText = "";
			this.txtMaYeuCau.Size = new System.Drawing.Size(171, 32);
			this.txtMaYeuCau.TabIndex = 185;
			// 
			// FormTheoDoiTuVan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 870);
			this.Controls.Add(this.gbTheoDoiTuVan);
			this.Controls.Add(this.dtgrvTheoDoiYeuCau);
			this.Controls.Add(this.lbDaXuLy);
			this.Controls.Add(this.numDaXuLy);
			this.Controls.Add(this.lbChuaXuLy);
			this.Controls.Add(this.numChuaXuLy);
			this.Controls.Add(this.lbTong);
			this.Controls.Add(this.numTong);
			this.Name = "FormTheoDoiTuVan";
			this.Text = "FormTheoDoiYeuCau";
			((System.ComponentModel.ISupportInitialize)(this.dtgrvTheoDoiYeuCau)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaXuLy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numChuaXuLy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTong)).EndInit();
			this.gbTheoDoiTuVan.ResumeLayout(false);
			this.gbTheoDoiTuVan.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgrvTheoDoiYeuCau;
		private System.Windows.Forms.Label lbDaXuLy;
		private System.Windows.Forms.NumericUpDown numDaXuLy;
		private System.Windows.Forms.Label lbChuaXuLy;
		private System.Windows.Forms.NumericUpDown numChuaXuLy;
		private System.Windows.Forms.Label lbTong;
		private System.Windows.Forms.NumericUpDown numTong;
		private Guna.UI2.WinForms.Guna2Button btnCapNhat;
		private System.Windows.Forms.GroupBox gbTheoDoiTuVan;
		private System.Windows.Forms.Label lbNgayTuVan;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTuVan;
		private System.Windows.Forms.RichTextBox rtxtNoiDungYeuCau;
		private System.Windows.Forms.Label lbNoiDungYeuCau;
		private System.Windows.Forms.Label lbTrangThai;
		private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
		private System.Windows.Forms.Label lbLoaiYeuCau;
		private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiYeuCau;
		private System.Windows.Forms.Label lbMaNV;
		private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
		private System.Windows.Forms.Label lbMaKH;
		private System.Windows.Forms.Label lbMaYeuCau;
		private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
		private Guna.UI2.WinForms.Guna2TextBox txtMaYeuCau;
	}
}