
namespace fDanhMuc
{
    partial class fDsLevel
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
            this.dgvDsLevel = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPokemon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsLevel
            // 
            this.dgvDsLevel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDsLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.SoPokemon,
            this.DiemToiDa,
            this.ThoiGianToiDa,
            this.SoMang});
            this.dgvDsLevel.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDsLevel.Location = new System.Drawing.Point(13, 13);
            this.dgvDsLevel.Name = "dgvDsLevel";
            this.dgvDsLevel.RowHeadersWidth = 51;
            this.dgvDsLevel.RowTemplate.Height = 29;
            this.dgvDsLevel.Size = new System.Drawing.Size(680, 425);
            this.dgvDsLevel.TabIndex = 0;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // SoPokemon
            // 
            this.SoPokemon.HeaderText = "Số  Pokemon";
            this.SoPokemon.MinimumWidth = 6;
            this.SoPokemon.Name = "SoPokemon";
            this.SoPokemon.Width = 125;
            // 
            // DiemToiDa
            // 
            this.DiemToiDa.HeaderText = "Điểm Tối Đa";
            this.DiemToiDa.MinimumWidth = 6;
            this.DiemToiDa.Name = "DiemToiDa";
            this.DiemToiDa.Width = 125;
            // 
            // ThoiGianToiDa
            // 
            this.ThoiGianToiDa.HeaderText = "Thời Gian Tối Đa";
            this.ThoiGianToiDa.MinimumWidth = 6;
            this.ThoiGianToiDa.Name = "ThoiGianToiDa";
            this.ThoiGianToiDa.Width = 125;
            // 
            // SoMang
            // 
            this.SoMang.HeaderText = "Số Mạng";
            this.SoMang.MinimumWidth = 6;
            this.SoMang.Name = "SoMang";
            this.SoMang.Width = 125;
            // 
            // fDsLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.dgvDsLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDsLevel";
            this.Text = "fDsLevel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPokemon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMang;
    }
}