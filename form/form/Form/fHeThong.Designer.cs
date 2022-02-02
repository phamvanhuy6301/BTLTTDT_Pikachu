
namespace Pikachu
{
    partial class fHeThong
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
            this.pnlButtonHeThong = new System.Windows.Forms.Panel();
            this.pnlDisplayHeThong = new System.Windows.Forms.Panel();
            this.btnHeThong_CapNhat = new System.Windows.Forms.Button();
            this.btnHeThong_DoiMk = new System.Windows.Forms.Button();
            this.btnHeThong_CaiDat = new System.Windows.Forms.Button();
            this.pnlButtonHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonHeThong
            // 
            this.pnlButtonHeThong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtonHeThong.Controls.Add(this.btnHeThong_CaiDat);
            this.pnlButtonHeThong.Controls.Add(this.btnHeThong_DoiMk);
            this.pnlButtonHeThong.Controls.Add(this.btnHeThong_CapNhat);
            this.pnlButtonHeThong.Location = new System.Drawing.Point(13, 13);
            this.pnlButtonHeThong.Name = "pnlButtonHeThong";
            this.pnlButtonHeThong.Size = new System.Drawing.Size(209, 425);
            this.pnlButtonHeThong.TabIndex = 0;
            // 
            // pnlDisplayHeThong
            // 
            this.pnlDisplayHeThong.Location = new System.Drawing.Point(229, 13);
            this.pnlDisplayHeThong.Name = "pnlDisplayHeThong";
            this.pnlDisplayHeThong.Size = new System.Drawing.Size(559, 425);
            this.pnlDisplayHeThong.TabIndex = 1;
            // 
            // btnHeThong_CapNhat
            // 
            this.btnHeThong_CapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeThong_CapNhat.Location = new System.Drawing.Point(29, 23);
            this.btnHeThong_CapNhat.Name = "btnHeThong_CapNhat";
            this.btnHeThong_CapNhat.Size = new System.Drawing.Size(157, 89);
            this.btnHeThong_CapNhat.TabIndex = 0;
            this.btnHeThong_CapNhat.Text = "Cập Nhật Thông Tin";
            this.btnHeThong_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btnHeThong_DoiMk
            // 
            this.btnHeThong_DoiMk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeThong_DoiMk.Location = new System.Drawing.Point(26, 168);
            this.btnHeThong_DoiMk.Name = "btnHeThong_DoiMk";
            this.btnHeThong_DoiMk.Size = new System.Drawing.Size(157, 89);
            this.btnHeThong_DoiMk.TabIndex = 1;
            this.btnHeThong_DoiMk.Text = "Đổi Mật Khẩu";
            this.btnHeThong_DoiMk.UseVisualStyleBackColor = true;
            this.btnHeThong_DoiMk.Click += new System.EventHandler(this.btnHeThong_DoiMk_Click);
            // 
            // btnHeThong_CaiDat
            // 
            this.btnHeThong_CaiDat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeThong_CaiDat.Location = new System.Drawing.Point(29, 305);
            this.btnHeThong_CaiDat.Name = "btnHeThong_CaiDat";
            this.btnHeThong_CaiDat.Size = new System.Drawing.Size(157, 89);
            this.btnHeThong_CaiDat.TabIndex = 2;
            this.btnHeThong_CaiDat.Text = "Cài Đặt";
            this.btnHeThong_CaiDat.UseVisualStyleBackColor = true;
            // 
            // fHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDisplayHeThong);
            this.Controls.Add(this.pnlButtonHeThong);
            this.Name = "fHeThong";
            this.Text = "fHeThong";
            this.pnlButtonHeThong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonHeThong;
        private System.Windows.Forms.Button btnHeThong_CaiDat;
        private System.Windows.Forms.Button btnHeThong_DoiMk;
        private System.Windows.Forms.Button btnHeThong_CapNhat;
        private System.Windows.Forms.Panel pnlDisplayHeThong;
    }
}