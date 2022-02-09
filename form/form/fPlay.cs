using Pikachu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pikachu
{
    public partial class fPlay : Form
    {
        GameModel gameModel = new GameModel(16,9,36);

        PictureBox[] px = new PictureBox[18*11];
        bool trangthai = true;
        int mang = 10;
        int diem = 0;
        int dem = 16 * 9;
        private int Thoigian = 500;
        List<Point> ListDaXoa = new List<Point>();

        private void fPlay_Load(object sender, EventArgs e)
        {
            
            this.timer1.Enabled = true;
        }


        public bool Ketthuc()
        {
            if (dem == 0)
            {
                return true;
            }
            return false;
        }
        public void pictureBoxClickEventhandle(object sender, EventArgs e)
        {
            if (Ketthuc() || Thoigian == 0)
            {
                MessageBox.Show("Kết thúc");
            }    
            else          
            {
                
                int T = (sender as PictureBox).Top;
                int L = (sender as PictureBox).Left;
                int i = (T - 10) / 50;
                int j = (L - 10) / 40;
                if (gameModel.getCell(i, j) != 0)
                {

                    if (gameModel.status == 0) // click lan 1
                    {
                        gameModel.p1.X = i;
                        gameModel.p1.Y = j;
                        gameModel.resetCell(T, L);
                        gameModel.status = 1; // da click 1 lan
                    }

                    else // click lan 2;
                    {

                        gameModel.resetCell(T, L);
                        gameModel.p2.X = i;
                        gameModel.p2.Y = j;
                        if (gameModel.getCell(gameModel.p1.X, gameModel.p1.Y) == gameModel.getCell(i, j) && gameModel.checkTwoPoint(gameModel.p1, gameModel.p2))
                        {

                            if (gameModel.p1.X != i || gameModel.p1.Y != j)
                            {

                                int idx2 = i * gameModel.Width + j;
                                int idx1 = gameModel.p1.X * gameModel.Width + gameModel.p1.Y;
                                px[idx1].Image = null;
                                px[idx2].Image = null;
                                ListDaXoa.Add(gameModel.p1);
                                ListDaXoa.Add(gameModel.p2);
                                dem -= 2;
                                diem += 20;
                                lblSoDiem.Text = diem.ToString();
                                gameModel.cell_undo = -gameModel.getCell(i, j);
                                gameModel.p1_undo = gameModel.p1;
                                gameModel.p2_undo = gameModel.p2;

                                gameModel.setCellequal0p(i, j);
                                gameModel.setCellequal0p(gameModel.p1.X, gameModel.p1.Y);
                            }
                        }


                        gameModel.status = 0;


                    }
                }
            }
            

        }
        public void pictureBoxMouseHoverEventhandle(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Red;
        }
        public void pictureBoxMouseLeaveEventhandle(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        public fPlay()
        {

            InitializeComponent();
            Taoban();
        }
        private void Taoban()
        {
            this.panel1.Controls.Clear();
            for (int i = 0; i < gameModel.Height; i++)
            {
                for (int j = 0; j < gameModel.Width; j++)
                {

                    int idx = i * gameModel.Width + j;
                    px[idx] = new PictureBox();

                    px[idx].Click += new EventHandler(pictureBoxClickEventhandle);
                    px[idx].MouseHover += new EventHandler(pictureBoxMouseHoverEventhandle);
                    px[idx].MouseLeave += new EventHandler(pictureBoxMouseLeaveEventhandle);
                    px[idx].Width = 44;
                    px[idx].Height = 54;
                    px[idx].Top = 10 + i * 50;
                    px[idx].Left = 10 + j * 40;
                    if (gameModel.getCell(i, j) != 0)
                    {
                        string name = "pieces" + gameModel.getCell(i, j).ToString() + ".png";
                        px[idx].SizeMode = PictureBoxSizeMode.CenterImage;
                        px[idx].Image = Image.FromFile(name);
                        this.panel1.Controls.Add(px[idx]);
                        //this.Controls.Add(px[idx]);
                    }
                    else
                    {
                        px[idx].Image = null;
                    }

                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Taoban();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            gameModel.table[gameModel.p1_undo.X, gameModel.p1_undo.Y] = gameModel.cell_undo;
            gameModel.table[gameModel.p2_undo.X, gameModel.p2_undo.Y] = gameModel.cell_undo;
            int idx1 = gameModel.p1_undo.X * gameModel.Width + gameModel.p1_undo.Y;
            int idx2 = gameModel.p2_undo.X * gameModel.Width + gameModel.p2_undo.Y;
            string name = "pieces" + gameModel.cell_undo.ToString() + ".png";
            px[idx1].SizeMode = PictureBoxSizeMode.CenterImage;
            px[idx1].Image = Image.FromFile(name);
            px[idx2].SizeMode = PictureBoxSizeMode.CenterImage;
            px[idx2].Image = Image.FromFile(name);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            int idx1 = gameModel.p1_undo.X * gameModel.Width + gameModel.p1_undo.Y;
            int idx2 = gameModel.p2_undo.X * gameModel.Width + gameModel.p2_undo.Y;
            px[idx1].Image = null;
            px[idx2].Image = null;

        }
        

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Thoigian > 0)
            {
                Thoigian--;
                this.label1.Text = Thoigian.ToString();
            }
            else
            {
                this.timer1.Stop();
                //MessageBox.Show("Hết giờ");
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblThoigianconlai_Click(object sender, EventArgs e)
        {

        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            
            if (trangthai)
            {
                Thoigian = 0;
                trangthai = false;
            }
            else
            {
                Thoigian = int.Parse(label1.Text);
                this.timer1.Start();
            }    
        }

        

        private void lblMang_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            diem = 0;
            lblSoDiem.Text = diem.ToString();
            
            Thoigian = 500;
            label1.Text = Thoigian.ToString();
            gameModel = new GameModel(16, 9, 36);
            Taoban();
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            if (mang != 0)
            {

                gameModel = new GameModel(16, 9, 36);
                Taoban();
                for(int k=0; k<ListDaXoa.Count; k++)
                {
                    int i = ListDaXoa[k].X;
                    int j = ListDaXoa[k].Y;
                    gameModel.setCellequal0p(i,j);
                    int idx = i * gameModel.Width + j;
                    px[idx].BackColor = Color.Transparent;
                    px[idx].Image = null;
;                }    
                mang--;
                lblMang.Text = mang.ToString();
            }
            else
            {
                MessageBox.Show("Đã hết lượt đổi");
            }

        }
    }
}
