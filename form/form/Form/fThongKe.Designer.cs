
namespace Pikachu
{
    partial class fThongKe
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
            this.pnlButtonThongKe = new System.Windows.Forms.Panel();
            this.btnThanhTichCaNhan = new System.Windows.Forms.Button();
            this.btnXepHang = new System.Windows.Forms.Button();
            this.pnlDisplayThongKe = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlButtonThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonThongKe
            // 
            this.pnlButtonThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtonThongKe.Controls.Add(this.btnThanhTichCaNhan);
            this.pnlButtonThongKe.Controls.Add(this.btnXepHang);
            this.pnlButtonThongKe.Location = new System.Drawing.Point(12, 13);
            this.pnlButtonThongKe.Name = "pnlButtonThongKe";
            this.pnlButtonThongKe.Size = new System.Drawing.Size(204, 418);
            this.pnlButtonThongKe.TabIndex = 0;
            // 
            // btnThanhTichCaNhan
            // 
            this.btnThanhTichCaNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhTichCaNhan.Location = new System.Drawing.Point(31, 223);
            this.btnThanhTichCaNhan.Name = "btnThanhTichCaNhan";
            this.btnThanhTichCaNhan.Size = new System.Drawing.Size(144, 103);
            this.btnThanhTichCaNhan.TabIndex = 2;
            this.btnThanhTichCaNhan.Text = "Thành Tích Cá Nhân";
            this.btnThanhTichCaNhan.UseVisualStyleBackColor = true;
            this.btnThanhTichCaNhan.Click += new System.EventHandler(this.btnThanhTichCaNhan_Click);
            // 
            // btnXepHang
            // 
            this.btnXepHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXepHang.Location = new System.Drawing.Point(31, 57);
            this.btnXepHang.Name = "btnXepHang";
            this.btnXepHang.Size = new System.Drawing.Size(144, 103);
            this.btnXepHang.TabIndex = 0;
            this.btnXepHang.Text = "Bảng Xếp Hạng";
            this.btnXepHang.UseVisualStyleBackColor = true;
            this.btnXepHang.Click += new System.EventHandler(this.btnXepHang_Click);
            // 
            // pnlDisplayThongKe
            // 
            this.pnlDisplayThongKe.Location = new System.Drawing.Point(243, 13);
            this.pnlDisplayThongKe.Name = "pnlDisplayThongKe";
            this.pnlDisplayThongKe.Size = new System.Drawing.Size(536, 418);
            this.pnlDisplayThongKe.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Lime;
            this.btnThoat.Location = new System.Drawing.Point(43, 448);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pnlDisplayThongKe);
            this.Controls.Add(this.pnlButtonThongKe);
            this.Name = "fThongKe";
            this.Text = "Thống Kê";
            this.pnlButtonThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonThongKe;
        private System.Windows.Forms.Button btnThanhTichCaNhan;
        private System.Windows.Forms.Button btnXepHang;
        private System.Windows.Forms.Panel pnlDisplayThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}