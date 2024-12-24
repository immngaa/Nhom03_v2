namespace Nhom03_v2
{
    partial class FormNhomKH
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
			this.grbNhomKH = new System.Windows.Forms.GroupBox();
			this.rtbMoTa = new System.Windows.Forms.RichTextBox();
			this.cbbTenNhomKH = new System.Windows.Forms.ComboBox();
			this.cbbMaNhomKH = new System.Windows.Forms.ComboBox();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.lbTenNhomKH = new System.Windows.Forms.Label();
			this.lbMaNhomKH = new System.Windows.Forms.Label();
			this.panelChucNang = new System.Windows.Forms.Panel();
			this.lbNhapMaNhomKH = new System.Windows.Forms.Label();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnTim = new Guna.UI2.WinForms.Guna2Button();
			this.txtNhapMaNhomKH = new System.Windows.Forms.TextBox();
			this.dtgrvNhomKH = new System.Windows.Forms.DataGridView();
			this.grbNhomKH.SuspendLayout();
			this.panelChucNang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvNhomKH)).BeginInit();
			this.SuspendLayout();
			// 
			// grbNhomKH
			// 
			this.grbNhomKH.Controls.Add(this.rtbMoTa);
			this.grbNhomKH.Controls.Add(this.cbbTenNhomKH);
			this.grbNhomKH.Controls.Add(this.cbbMaNhomKH);
			this.grbNhomKH.Controls.Add(this.lbMoTa);
			this.grbNhomKH.Controls.Add(this.lbTenNhomKH);
			this.grbNhomKH.Controls.Add(this.lbMaNhomKH);
			this.grbNhomKH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbNhomKH.Location = new System.Drawing.Point(41, 36);
			this.grbNhomKH.Margin = new System.Windows.Forms.Padding(2);
			this.grbNhomKH.Name = "grbNhomKH";
			this.grbNhomKH.Padding = new System.Windows.Forms.Padding(2);
			this.grbNhomKH.Size = new System.Drawing.Size(925, 289);
			this.grbNhomKH.TabIndex = 1;
			this.grbNhomKH.TabStop = false;
			this.grbNhomKH.Text = "Nhóm khách hàng";
			// 
			// rtbMoTa
			// 
			this.rtbMoTa.Location = new System.Drawing.Point(494, 63);
			this.rtbMoTa.Margin = new System.Windows.Forms.Padding(2);
			this.rtbMoTa.Name = "rtbMoTa";
			this.rtbMoTa.Size = new System.Drawing.Size(221, 126);
			this.rtbMoTa.TabIndex = 5;
			this.rtbMoTa.Text = "";
			// 
			// cbbTenNhomKH
			// 
			this.cbbTenNhomKH.FormattingEnabled = true;
			this.cbbTenNhomKH.Items.AddRange(new object[] {
            "Tiềm năng",
            "VIP",
            "Cá nhân",
            "Doanh nghiệp",
            "Thường xuyên"});
			this.cbbTenNhomKH.Location = new System.Drawing.Point(213, 115);
			this.cbbTenNhomKH.Margin = new System.Windows.Forms.Padding(2);
			this.cbbTenNhomKH.Name = "cbbTenNhomKH";
			this.cbbTenNhomKH.Size = new System.Drawing.Size(158, 46);
			this.cbbTenNhomKH.TabIndex = 4;
			// 
			// cbbMaNhomKH
			// 
			this.cbbMaNhomKH.FormattingEnabled = true;
			this.cbbMaNhomKH.Items.AddRange(new object[] {
            "NKH01",
            "NKH02",
            "NKH03",
            "NKH04",
            "NKH05"});
			this.cbbMaNhomKH.Location = new System.Drawing.Point(213, 57);
			this.cbbMaNhomKH.Margin = new System.Windows.Forms.Padding(2);
			this.cbbMaNhomKH.Name = "cbbMaNhomKH";
			this.cbbMaNhomKH.Size = new System.Drawing.Size(158, 46);
			this.cbbMaNhomKH.TabIndex = 3;
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(422, 63);
			this.lbMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(90, 32);
			this.lbMoTa.TabIndex = 2;
			this.lbMoTa.Text = "Mô tả";
			// 
			// lbTenNhomKH
			// 
			this.lbTenNhomKH.AutoSize = true;
			this.lbTenNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenNhomKH.Location = new System.Drawing.Point(32, 121);
			this.lbTenNhomKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTenNhomKH.Name = "lbTenNhomKH";
			this.lbTenNhomKH.Size = new System.Drawing.Size(199, 32);
			this.lbTenNhomKH.TabIndex = 1;
			this.lbTenNhomKH.Text = "Tên nhóm KH";
			// 
			// lbMaNhomKH
			// 
			this.lbMaNhomKH.AutoSize = true;
			this.lbMaNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNhomKH.Location = new System.Drawing.Point(32, 63);
			this.lbMaNhomKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMaNhomKH.Name = "lbMaNhomKH";
			this.lbMaNhomKH.Size = new System.Drawing.Size(188, 32);
			this.lbMaNhomKH.TabIndex = 0;
			this.lbMaNhomKH.Text = "Mã nhóm KH";
			// 
			// panelChucNang
			// 
			this.panelChucNang.BackColor = System.Drawing.Color.Transparent;
			this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelChucNang.Controls.Add(this.lbNhapMaNhomKH);
			this.panelChucNang.Controls.Add(this.btnXoa);
			this.panelChucNang.Controls.Add(this.btnThem);
			this.panelChucNang.Controls.Add(this.btnSua);
			this.panelChucNang.Controls.Add(this.btnTim);
			this.panelChucNang.Controls.Add(this.txtNhapMaNhomKH);
			this.panelChucNang.Location = new System.Drawing.Point(37, 347);
			this.panelChucNang.Name = "panelChucNang";
			this.panelChucNang.Size = new System.Drawing.Size(929, 87);
			this.panelChucNang.TabIndex = 92;
			// 
			// lbNhapMaNhomKH
			// 
			this.lbNhapMaNhomKH.AutoSize = true;
			this.lbNhapMaNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhapMaNhomKH.Location = new System.Drawing.Point(12, 31);
			this.lbNhapMaNhomKH.Name = "lbNhapMaNhomKH";
			this.lbNhapMaNhomKH.Size = new System.Drawing.Size(271, 32);
			this.lbNhapMaNhomKH.TabIndex = 71;
			this.lbNhapMaNhomKH.Text = "Nhập mã nhóm KH";
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
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.Transparent;
			this.btnTim.BorderColor = System.Drawing.Color.Transparent;
			this.btnTim.BorderRadius = 20;
			this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnTim.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.btnTim.ForeColor = System.Drawing.Color.White;
			this.btnTim.Image = global::Nhom03_v2.Properties.Resources.TimKiem;
			this.btnTim.ImageSize = new System.Drawing.Size(30, 30);
			this.btnTim.Location = new System.Drawing.Point(424, 21);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(76, 45);
			this.btnTim.TabIndex = 67;
			// 
			// txtNhapMaNhomKH
			// 
			this.txtNhapMaNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNhapMaNhomKH.Location = new System.Drawing.Point(186, 27);
			this.txtNhapMaNhomKH.Name = "txtNhapMaNhomKH";
			this.txtNhapMaNhomKH.Size = new System.Drawing.Size(218, 40);
			this.txtNhapMaNhomKH.TabIndex = 64;
			// 
			// dtgrvNhomKH
			// 
			this.dtgrvNhomKH.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvNhomKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvNhomKH.Location = new System.Drawing.Point(37, 485);
			this.dtgrvNhomKH.Name = "dtgrvNhomKH";
			this.dtgrvNhomKH.RowHeadersWidth = 62;
			this.dtgrvNhomKH.RowTemplate.Height = 28;
			this.dtgrvNhomKH.Size = new System.Drawing.Size(929, 191);
			this.dtgrvNhomKH.TabIndex = 93;
			// 
			// FormNhomKH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 780);
			this.Controls.Add(this.dtgrvNhomKH);
			this.Controls.Add(this.panelChucNang);
			this.Controls.Add(this.grbNhomKH);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FormNhomKH";
			this.Text = "FormNhomKH";
			this.grbNhomKH.ResumeLayout(false);
			this.grbNhomKH.PerformLayout();
			this.panelChucNang.ResumeLayout(false);
			this.panelChucNang.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvNhomKH)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhomKH;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.ComboBox cbbTenNhomKH;
        private System.Windows.Forms.ComboBox cbbMaNhomKH;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbTenNhomKH;
        private System.Windows.Forms.Label lbMaNhomKH;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label lbNhapMaNhomKH;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnTim;
        private System.Windows.Forms.TextBox txtNhapMaNhomKH;
        private System.Windows.Forms.DataGridView dtgrvNhomKH;
    }
}