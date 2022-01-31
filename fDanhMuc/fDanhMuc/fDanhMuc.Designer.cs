
namespace fDanhMuc
{
    partial class fDanhMuc
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnDsPhienChoi = new System.Windows.Forms.Button();
            this.btnDsPokemon = new System.Windows.Forms.Button();
            this.btnDsLevel = new System.Windows.Forms.Button();
            this.btnDSNguoiChoi = new System.Windows.Forms.Button();
            this.pnlDisplayDsLevel = new System.Windows.Forms.Panel();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.Controls.Add(this.btnDsPhienChoi);
            this.pnlButton.Controls.Add(this.btnDsPokemon);
            this.pnlButton.Controls.Add(this.btnDsLevel);
            this.pnlButton.Controls.Add(this.btnDSNguoiChoi);
            this.pnlButton.Location = new System.Drawing.Point(13, 13);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(190, 497);
            this.pnlButton.TabIndex = 0;
            // 
            // btnDsPhienChoi
            // 
            this.btnDsPhienChoi.Location = new System.Drawing.Point(19, 393);
            this.btnDsPhienChoi.Name = "btnDsPhienChoi";
            this.btnDsPhienChoi.Size = new System.Drawing.Size(147, 75);
            this.btnDsPhienChoi.TabIndex = 3;
            this.btnDsPhienChoi.Text = "Danh Sách Phiên Chơi";
            this.btnDsPhienChoi.UseVisualStyleBackColor = true;
            // 
            // btnDsPokemon
            // 
            this.btnDsPokemon.Location = new System.Drawing.Point(19, 273);
            this.btnDsPokemon.Name = "btnDsPokemon";
            this.btnDsPokemon.Size = new System.Drawing.Size(147, 75);
            this.btnDsPokemon.TabIndex = 2;
            this.btnDsPokemon.Text = "Danh sách Pokemon";
            this.btnDsPokemon.UseVisualStyleBackColor = true;
            // 
            // btnDsLevel
            // 
            this.btnDsLevel.Location = new System.Drawing.Point(19, 152);
            this.btnDsLevel.Name = "btnDsLevel";
            this.btnDsLevel.Size = new System.Drawing.Size(147, 75);
            this.btnDsLevel.TabIndex = 1;
            this.btnDsLevel.Text = "Danh Sách Level";
            this.btnDsLevel.UseVisualStyleBackColor = true;
            this.btnDsLevel.Click += new System.EventHandler(this.btnDsLevel_Click);
            // 
            // btnDSNguoiChoi
            // 
            this.btnDSNguoiChoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDSNguoiChoi.Location = new System.Drawing.Point(19, 19);
            this.btnDSNguoiChoi.Name = "btnDSNguoiChoi";
            this.btnDSNguoiChoi.Size = new System.Drawing.Size(147, 75);
            this.btnDSNguoiChoi.TabIndex = 0;
            this.btnDSNguoiChoi.Text = "Danh sách người chơi";
            this.btnDSNguoiChoi.UseVisualStyleBackColor = false;
            // 
            // pnlDisplayDsLevel
            // 
            this.pnlDisplayDsLevel.Location = new System.Drawing.Point(224, 13);
            this.pnlDisplayDsLevel.Name = "pnlDisplayDsLevel";
            this.pnlDisplayDsLevel.Size = new System.Drawing.Size(781, 497);
            this.pnlDisplayDsLevel.TabIndex = 1;
            // 
            // fDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 522);
            this.Controls.Add(this.pnlDisplayDsLevel);
            this.Controls.Add(this.pnlButton);
            this.Name = "fDanhMuc";
            this.Text = "Form1";
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnDsPhienChoi;
        private System.Windows.Forms.Button btnDsPokemon;
        private System.Windows.Forms.Button btnDsLevel;
        private System.Windows.Forms.Button btnDSNguoiChoi;
        private System.Windows.Forms.Panel pnlDisplayDsLevel;
    }
}

