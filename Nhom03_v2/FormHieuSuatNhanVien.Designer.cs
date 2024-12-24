namespace Nhom03_v2
{
    partial class FormHieuSuatNhanVien
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
            this.grbTKTV = new System.Windows.Forms.GroupBox();
            this.grbTKKN = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grbTKTV
            // 
            this.grbTKTV.Location = new System.Drawing.Point(71, 87);
            this.grbTKTV.Name = "grbTKTV";
            this.grbTKTV.Size = new System.Drawing.Size(410, 338);
            this.grbTKTV.TabIndex = 0;
            this.grbTKTV.TabStop = false;
            this.grbTKTV.Text = "TK số lần tư vấn của nhân viên";
            // 
            // grbTKKN
            // 
            this.grbTKKN.Location = new System.Drawing.Point(548, 87);
            this.grbTKKN.Name = "grbTKKN";
            this.grbTKKN.Size = new System.Drawing.Size(509, 338);
            this.grbTKKN.TabIndex = 1;
            this.grbTKKN.TabStop = false;
            this.grbTKKN.Text = "TK số lần giải quyết khiếu nại của NV";
            // 
            // FormHieuSuatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 801);
            this.Controls.Add(this.grbTKKN);
            this.Controls.Add(this.grbTKTV);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormHieuSuatNhanVien";
            this.Text = "FormHieuSuatNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTKTV;
        private System.Windows.Forms.GroupBox grbTKKN;
    }
}