
namespace Pikachu
{
    partial class fDSNguoiChoi
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
            this.dtgrvDsNguoiChoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDsNguoiChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrvDsNguoiChoi
            // 
            this.dtgrvDsNguoiChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvDsNguoiChoi.Location = new System.Drawing.Point(14, 16);
            this.dtgrvDsNguoiChoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrvDsNguoiChoi.Name = "dtgrvDsNguoiChoi";
            this.dtgrvDsNguoiChoi.RowHeadersWidth = 51;
            this.dtgrvDsNguoiChoi.RowTemplate.Height = 25;
            this.dtgrvDsNguoiChoi.Size = new System.Drawing.Size(511, 338);
            this.dtgrvDsNguoiChoi.TabIndex = 0;
            this.dtgrvDsNguoiChoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvDsNguoiChoi_CellContentClick);
            // 
            // fDSNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 358);
            this.Controls.Add(this.dtgrvDsNguoiChoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fDSNguoiChoi";
            this.Text = "Danh sách người chơi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDsNguoiChoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvDsNguoiChoi;
    }
}