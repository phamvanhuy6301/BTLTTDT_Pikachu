
namespace Pikachu
{
    partial class fDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pbxIconGamePikachu = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.lblPikachu = new System.Windows.Forms.Label();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconGamePikachu)).BeginInit();
            this.pnlTaiKhoan.SuspendLayout();
            this.pnlMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Yellow;
            this.pnlTop.Location = new System.Drawing.Point(1, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(533, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Yellow;
            this.pnlBottom.Location = new System.Drawing.Point(1, 225);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(533, 39);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblPikachu);
            this.pnlPicture.Controls.Add(this.pbxIconGamePikachu);
            this.pnlPicture.Location = new System.Drawing.Point(1, 45);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(123, 174);
            this.pnlPicture.TabIndex = 2;
            // 
            // pbxIconGamePikachu
            // 
            this.pbxIconGamePikachu.Location = new System.Drawing.Point(11, 33);
            this.pbxIconGamePikachu.Name = "pbxIconGamePikachu";
            this.pbxIconGamePikachu.Size = new System.Drawing.Size(102, 132);
            this.pbxIconGamePikachu.TabIndex = 0;
            this.pbxIconGamePikachu.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(257, 174);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(96, 26);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(409, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 26);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaiKhoan.Location = new System.Drawing.Point(16, 17);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(79, 21);
            this.lblTaiKhoan.TabIndex = 5;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(127, 15);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(262, 23);
            this.txtTenDangNhap.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(127, 14);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(262, 23);
            this.txtMatKhau.TabIndex = 8;
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.Controls.Add(this.txtTenDangNhap);
            this.pnlTaiKhoan.Controls.Add(this.lblTaiKhoan);
            this.pnlTaiKhoan.Location = new System.Drawing.Point(130, 48);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(392, 53);
            this.pnlTaiKhoan.TabIndex = 9;
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.Controls.Add(this.label2);
            this.pnlMatKhau.Controls.Add(this.txtMatKhau);
            this.pnlMatKhau.Location = new System.Drawing.Point(130, 107);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(392, 53);
            this.pnlMatKhau.TabIndex = 10;
            // 
            // lblPikachu
            // 
            this.lblPikachu.AutoSize = true;
            this.lblPikachu.Location = new System.Drawing.Point(9, 10);
            this.lblPikachu.Name = "lblPikachu";
            this.lblPikachu.Size = new System.Drawing.Size(106, 15);
            this.lblPikachu.TabIndex = 1;
            this.lblPikachu.Text = "PIKACHU CỔ ĐIỂN";
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.pnlTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "fDangNhap";
            this.Text = "Login";
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconGamePikachu)).EndInit();
            this.pnlTaiKhoan.ResumeLayout(false);
            this.pnlTaiKhoan.PerformLayout();
            this.pnlMatKhau.ResumeLayout(false);
            this.pnlMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel pnlTaiKhoan;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.PictureBox pbxIconGamePikachu;
        private System.Windows.Forms.Label lblPikachu;
    }
}

