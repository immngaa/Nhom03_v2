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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenNhomKH = new System.Windows.Forms.Label();
            this.labelMaNhomKH = new System.Windows.Forms.Label();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtgrvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblMoTa);
            this.groupBox1.Controls.Add(this.lblTenNhomKH);
            this.groupBox1.Controls.Add(this.labelMaNhomKH);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(925, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm khách hàng";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(494, 63);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(369, 162);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tiềm năng",
            "VIP",
            "Cá nhân",
            "Doanh nghiệp",
            "Thường xuyên"});
            this.comboBox2.Location = new System.Drawing.Point(213, 115);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 37);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NKH01",
            "NKH02",
            "NKH03",
            "NKH04",
            "NKH05"});
            this.comboBox1.Location = new System.Drawing.Point(213, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(422, 63);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(71, 25);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblTenNhomKH
            // 
            this.lblTenNhomKH.AutoSize = true;
            this.lblTenNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhomKH.Location = new System.Drawing.Point(32, 121);
            this.lblTenNhomKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhomKH.Name = "lblTenNhomKH";
            this.lblTenNhomKH.Size = new System.Drawing.Size(155, 25);
            this.lblTenNhomKH.TabIndex = 1;
            this.lblTenNhomKH.Text = "Tên nhóm KH";
            // 
            // labelMaNhomKH
            // 
            this.labelMaNhomKH.AutoSize = true;
            this.labelMaNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNhomKH.Location = new System.Drawing.Point(32, 63);
            this.labelMaNhomKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaNhomKH.Name = "labelMaNhomKH";
            this.labelMaNhomKH.Size = new System.Drawing.Size(147, 25);
            this.labelMaNhomKH.TabIndex = 0;
            this.labelMaNhomKH.Text = "Mã nhóm KH";
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.Transparent;
            this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChucNang.Controls.Add(this.btnXem);
            this.panelChucNang.Controls.Add(this.btnTimKiem);
            this.panelChucNang.Controls.Add(this.label1);
            this.panelChucNang.Controls.Add(this.guna2Button2);
            this.panelChucNang.Controls.Add(this.guna2Button3);
            this.panelChucNang.Controls.Add(this.guna2Button5);
            this.panelChucNang.Controls.Add(this.textBox2);
            this.panelChucNang.Location = new System.Drawing.Point(41, 269);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(925, 87);
            this.panelChucNang.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nhập mã KH";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.guna2Button2.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(768, 21);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(100, 38);
            this.guna2Button2.TabIndex = 68;
            this.guna2Button2.Text = "Xoá";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.guna2Button3.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(520, 21);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(100, 38);
            this.guna2Button3.TabIndex = 69;
            this.guna2Button3.Text = "Thêm";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 20;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.guna2Button5.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(642, 21);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(100, 38);
            this.guna2Button5.TabIndex = 70;
            this.guna2Button5.Text = "Sửa";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(186, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 32);
            this.textBox2.TabIndex = 64;
            // 
            // dtgrvThongTinNhanVien
            // 
            this.dtgrvThongTinNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvThongTinNhanVien.Location = new System.Drawing.Point(41, 362);
            this.dtgrvThongTinNhanVien.Name = "dtgrvThongTinNhanVien";
            this.dtgrvThongTinNhanVien.RowHeadersWidth = 62;
            this.dtgrvThongTinNhanVien.RowTemplate.Height = 28;
            this.dtgrvThongTinNhanVien.Size = new System.Drawing.Size(925, 191);
            this.dtgrvThongTinNhanVien.TabIndex = 93;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BorderColor = System.Drawing.Color.Transparent;
            this.btnXem.BorderRadius = 20;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnXem.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(414, 21);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 38);
            this.btnXem.TabIndex = 75;
            this.btnXem.Text = "Xem";
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
            this.btnTimKiem.FillColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::Nhom03_v2.Properties.Resources.TimKiem;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(362, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 32);
            this.btnTimKiem.TabIndex = 74;
            // 
            // FormNhomKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 780);
            this.Controls.Add(this.dtgrvThongTinNhanVien);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormNhomKH";
            this.Text = "FormNhomKH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTenNhomKH;
        private System.Windows.Forms.Label labelMaNhomKH;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dtgrvThongTinNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
    }
}