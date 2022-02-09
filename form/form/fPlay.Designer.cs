
namespace Pikachu
{
    partial class fPlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlay));
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblMang = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblSoDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThoigianconlai = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnDao = new System.Windows.Forms.Button();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTamDung.Location = new System.Drawing.Point(762, 144);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(94, 29);
            this.btnTamDung.TabIndex = 1;
            this.btnTamDung.Text = "Tạm Dừng";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Lime;
            this.btnHome.Location = new System.Drawing.Point(762, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 29);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Gray;
            this.btnUndo.Location = new System.Drawing.Point(762, 84);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(94, 29);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRedo.Location = new System.Drawing.Point(895, 84);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(94, 29);
            this.btnRedo.TabIndex = 4;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Pikachu.Properties.Resources.backgroud;
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 519);
            this.panel1.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Yellow;
            this.btnNewGame.Location = new System.Drawing.Point(895, 13);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 29);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblMang
            // 
            this.lblMang.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblMang.Location = new System.Drawing.Point(927, 176);
            this.lblMang.Name = "lblMang";
            this.lblMang.Size = new System.Drawing.Size(32, 25);
            this.lblMang.TabIndex = 7;
            this.lblMang.Text = "10";
            this.lblMang.Click += new System.EventHandler(this.lblMang_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiem.Location = new System.Drawing.Point(762, 221);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(94, 47);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.Text = "Điểm:";
            // 
            // lblSoDiem
            // 
            this.lblSoDiem.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoDiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoDiem.Location = new System.Drawing.Point(896, 221);
            this.lblSoDiem.Name = "lblSoDiem";
            this.lblSoDiem.Size = new System.Drawing.Size(93, 47);
            this.lblSoDiem.TabIndex = 10;
            this.lblSoDiem.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "500";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblThoigianconlai
            // 
            this.lblThoigianconlai.AutoSize = true;
            this.lblThoigianconlai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThoigianconlai.Location = new System.Drawing.Point(11, 0);
            this.lblThoigianconlai.Name = "lblThoigianconlai";
            this.lblThoigianconlai.Size = new System.Drawing.Size(198, 31);
            this.lblThoigianconlai.TabIndex = 14;
            this.lblThoigianconlai.Text = "Thời gian còn lại:";
            this.lblThoigianconlai.Click += new System.EventHandler(this.lblThoigianconlai_Click);
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTime.BackgroundImage")));
            this.pnlTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlTime.Controls.Add(this.lblThoigianconlai);
            this.pnlTime.Controls.Add(this.label1);
            this.pnlTime.Location = new System.Drawing.Point(762, 365);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(229, 156);
            this.pnlTime.TabIndex = 15;
            // 
            // btnDao
            // 
            this.btnDao.BackColor = System.Drawing.Color.Olive;
            this.btnDao.Location = new System.Drawing.Point(896, 144);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(94, 29);
            this.btnDao.TabIndex = 16;
            this.btnDao.Text = "Đảo";
            this.btnDao.UseVisualStyleBackColor = false;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // fPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Pikachu.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(1009, 603);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.lblSoDiem);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblMang);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnTamDung);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPlay";
            this.Text = "GAME PIKACHU";
            this.Load += new System.EventHandler(this.fPlay_Load);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblMang;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblSoDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThoigianconlai;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Button btnDao;
    }
}