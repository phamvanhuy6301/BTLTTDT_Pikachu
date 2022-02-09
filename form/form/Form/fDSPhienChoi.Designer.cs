
namespace Pikachu
{
    partial class fDSPhienChoi
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
            this.dtgrvDsPhienChoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDsPhienChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrvDsPhienChoi
            // 
            this.dtgrvDsPhienChoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvDsPhienChoi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrvDsPhienChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvDsPhienChoi.Location = new System.Drawing.Point(12, 11);
            this.dtgrvDsPhienChoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvDsPhienChoi.Name = "dtgrvDsPhienChoi";
            this.dtgrvDsPhienChoi.ReadOnly = true;
            this.dtgrvDsPhienChoi.RowHeadersWidth = 51;
            this.dtgrvDsPhienChoi.RowTemplate.Height = 29;
            this.dtgrvDsPhienChoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvDsPhienChoi.Size = new System.Drawing.Size(450, 250);
            this.dtgrvDsPhienChoi.TabIndex = 0;
            this.dtgrvDsPhienChoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvDsPhienChoi_CellContentClick);
            // 
            // fDSPhienChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.dtgrvDsPhienChoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDSPhienChoi";
            this.Text = "fDSPhienChoi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDsPhienChoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvDsPhienChoi;
    }
}