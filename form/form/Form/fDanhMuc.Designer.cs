
namespace Pikachu
{
    partial class fDanhMuc
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
            this.pnlButtonDanhMuc = new System.Windows.Forms.Panel();
            this.btnDsNguoiChoi = new System.Windows.Forms.Button();
            this.btnDsPokemon = new System.Windows.Forms.Button();
            this.btnDsLevel = new System.Windows.Forms.Button();
            this.DsPhienChoi = new System.Windows.Forms.Button();
            this.pnlDisplayDanhMuc = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnlButtonDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonDanhMuc
            // 
            this.pnlButtonDanhMuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtonDanhMuc.Controls.Add(this.btnDsNguoiChoi);
            this.pnlButtonDanhMuc.Controls.Add(this.btnDsPokemon);
            this.pnlButtonDanhMuc.Controls.Add(this.btnDsLevel);
            this.pnlButtonDanhMuc.Controls.Add(this.DsPhienChoi);
            this.pnlButtonDanhMuc.Location = new System.Drawing.Point(24, 17);
            this.pnlButtonDanhMuc.Name = "pnlButtonDanhMuc";
            this.pnlButtonDanhMuc.Size = new System.Drawing.Size(184, 405);
            this.pnlButtonDanhMuc.TabIndex = 0;
            // 
            // btnDsNguoiChoi
            // 
            this.btnDsNguoiChoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDsNguoiChoi.Location = new System.Drawing.Point(18, 316);
            this.btnDsNguoiChoi.Name = "btnDsNguoiChoi";
            this.btnDsNguoiChoi.Size = new System.Drawing.Size(148, 72);
            this.btnDsNguoiChoi.TabIndex = 3;
            this.btnDsNguoiChoi.Text = "Danh Sách Người Chơi";
            this.btnDsNguoiChoi.UseVisualStyleBackColor = true;
            this.btnDsNguoiChoi.Click += new System.EventHandler(this.btnDsNguoiChoi_Click);
            // 
            // btnDsPokemon
            // 
            this.btnDsPokemon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDsPokemon.Location = new System.Drawing.Point(18, 222);
            this.btnDsPokemon.Name = "btnDsPokemon";
            this.btnDsPokemon.Size = new System.Drawing.Size(148, 72);
            this.btnDsPokemon.TabIndex = 2;
            this.btnDsPokemon.Text = "Danh Sách Pokemon";
            this.btnDsPokemon.UseVisualStyleBackColor = true;
            this.btnDsPokemon.Click += new System.EventHandler(this.btnDsPokemon_Click);
            // 
            // btnDsLevel
            // 
            this.btnDsLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDsLevel.Location = new System.Drawing.Point(18, 127);
            this.btnDsLevel.Name = "btnDsLevel";
            this.btnDsLevel.Size = new System.Drawing.Size(148, 72);
            this.btnDsLevel.TabIndex = 1;
            this.btnDsLevel.Text = "Danh Sách Level";
            this.btnDsLevel.UseVisualStyleBackColor = true;
            this.btnDsLevel.Click += new System.EventHandler(this.btnDsLevel_Click);
            // 
            // DsPhienChoi
            // 
            this.DsPhienChoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DsPhienChoi.Location = new System.Drawing.Point(18, 34);
            this.DsPhienChoi.Name = "DsPhienChoi";
            this.DsPhienChoi.Size = new System.Drawing.Size(148, 72);
            this.DsPhienChoi.TabIndex = 0;
            this.DsPhienChoi.Text = "Danh Sách Phiên Chơi";
            this.DsPhienChoi.UseVisualStyleBackColor = true;
            this.DsPhienChoi.Click += new System.EventHandler(this.DsPhienChoi_Click);
            // 
            // pnlDisplayDanhMuc
            // 
            this.pnlDisplayDanhMuc.Location = new System.Drawing.Point(230, 17);
            this.pnlDisplayDanhMuc.Name = "pnlDisplayDanhMuc";
            this.pnlDisplayDanhMuc.Size = new System.Drawing.Size(545, 405);
            this.pnlDisplayDanhMuc.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Lime;
            this.btnQuayLai.Location = new System.Drawing.Point(42, 442);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 29);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.pnlDisplayDanhMuc);
            this.Controls.Add(this.pnlButtonDanhMuc);
            this.Name = "fDanhMuc";
            this.Text = "Danh Mục";
            this.pnlButtonDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonDanhMuc;
        private System.Windows.Forms.Button btnDsNguoiChoi;
        private System.Windows.Forms.Button btnDsPokemon;
        private System.Windows.Forms.Button btnDsLevel;
        private System.Windows.Forms.Button DsPhienChoi;
        private System.Windows.Forms.Panel pnlDisplayDanhMuc;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnQuay;
    }
}