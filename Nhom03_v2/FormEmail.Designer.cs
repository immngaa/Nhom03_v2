namespace Nhom03_v2
{
	partial class FormEmail
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
			this.txtNgayTuVan = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.rtxtbNDPhanHoi = new System.Windows.Forms.RichTextBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbNgayTuVan = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbMaKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// txtNgayTuVan
			// 
			this.txtNgayTuVan.Location = new System.Drawing.Point(181, 107);
			this.txtNgayTuVan.Name = "txtNgayTuVan";
			this.txtNgayTuVan.Size = new System.Drawing.Size(401, 31);
			this.txtNgayTuVan.TabIndex = 87;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(181, 39);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(401, 31);
			this.txtMaKH.TabIndex = 89;
			// 
			// rtxtbNDPhanHoi
			// 
			this.rtxtbNDPhanHoi.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtbNDPhanHoi.Location = new System.Drawing.Point(25, 210);
			this.rtxtbNDPhanHoi.Name = "rtxtbNDPhanHoi";
			this.rtxtbNDPhanHoi.Size = new System.Drawing.Size(1025, 418);
			this.rtxtbNDPhanHoi.TabIndex = 85;
			this.rtxtbNDPhanHoi.Text = "";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 170);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(206, 34);
			this.guna2HtmlLabel1.TabIndex = 83;
			this.guna2HtmlLabel1.Text = "Nội dung email";
			// 
			// lbNgayTuVan
			// 
			this.lbNgayTuVan.BackColor = System.Drawing.Color.Transparent;
			this.lbNgayTuVan.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNgayTuVan.Location = new System.Drawing.Point(34, 108);
			this.lbNgayTuVan.Name = "lbNgayTuVan";
			this.lbNgayTuVan.Size = new System.Drawing.Size(111, 34);
			this.lbNgayTuVan.TabIndex = 80;
			this.lbNgayTuVan.Text = "Chủ đề: ";
			// 
			// lbMaKH
			// 
			this.lbMaKH.BackColor = System.Drawing.Color.Transparent;
			this.lbMaKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaKH.Location = new System.Drawing.Point(34, 40);
			this.lbMaKH.Name = "lbMaKH";
			this.lbMaKH.Size = new System.Drawing.Size(69, 34);
			this.lbMaKH.TabIndex = 79;
			this.lbMaKH.Text = "Đến:";
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
			this.guna2Button2.Location = new System.Drawing.Point(441, 634);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(158, 75);
			this.guna2Button2.TabIndex = 189;
			this.guna2Button2.Text = "Gửi";
			// 
			// FormEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 804);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.txtNgayTuVan);
			this.Controls.Add(this.txtMaKH);
			this.Controls.Add(this.rtxtbNDPhanHoi);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.lbNgayTuVan);
			this.Controls.Add(this.lbMaKH);
			this.Name = "FormEmail";
			this.Text = "FormEmail";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNgayTuVan;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.RichTextBox rtxtbNDPhanHoi;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbNgayTuVan;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbMaKH;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
	}
}