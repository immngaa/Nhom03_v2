namespace Nhom03_v2
{
    partial class FormThongKeDoanhThu
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
            this.grbThongKeDoanhThuTheoNgay = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // grbThongKeDoanhThuTheoNgay
            // 
            this.grbThongKeDoanhThuTheoNgay.Location = new System.Drawing.Point(33, 40);
            this.grbThongKeDoanhThuTheoNgay.Name = "grbThongKeDoanhThuTheoNgay";
            this.grbThongKeDoanhThuTheoNgay.Size = new System.Drawing.Size(496, 412);
            this.grbThongKeDoanhThuTheoNgay.TabIndex = 0;
            this.grbThongKeDoanhThuTheoNgay.TabStop = false;
            this.grbThongKeDoanhThuTheoNgay.Text = "Thống kê doanh thu theo ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(560, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu theo tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(33, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 412);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu theo sản phẩm";
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
            this.btnXem.Location = new System.Drawing.Point(688, 615);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(159, 49);
            this.btnXem.TabIndex = 76;
            this.btnXem.Text = "Xem";
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 906);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongKeDoanhThuTheoNgay);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongKeDoanhThuTheoNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnXem;
    }
}