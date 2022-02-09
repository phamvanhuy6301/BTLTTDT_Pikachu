using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu.DAO
{
    class GameModel
    {
        public int[,] table;
        private int width, height;
        
        public Point p1 = new Point();
        public Point p2 = new Point();

        public Point p1_undo = new Point();
        public Point p2_undo = new Point();

        public Point p1_redo = new Point();
        public Point p2_redo = new Point();

        public int cell_undo;

        public int status = 0;

        public int Width
        {
            get { return width; }
            set { width = value + 2; }
        }
        public int Height
        {
            get { return height; }
            set { height = value + 2; }
        }



        public int getCell(int i, int j)
        {
            return table[i, j];
        }
        public void setCell(int i, int j, int v)
        {
            table[i, j] = v;
        }
       
        
        
        public void resetCell(int T, int L) // khi ô được chọn thì chuyển giá trị ô đó thành số âm
        {
            int i = (T - 10) / 50;
            int j = (L - 10) / 40;

            int typeOfPokemon = getCell(i, j);
            table[i, j] = -typeOfPokemon;
        }
        public void setCellequal0p(int i, int j) // khi xóa thì ta đặt giá trị ô đó b
        {

            table[i, j] = 0;
        }
       

        
        public GameModel(int _width, int _height, int _numOfType)
        {
            width = _width + 2;
            height = _height + 2;

            table = new int[height, width];
            HashSet<int> cellIndex = new HashSet<int>();


            // su dung de luu cac o da sinh ra pokemon

            // su dung de sinh so ngau nhien
            Random random = new Random();
            
            for (int i = 0; i < width * height / 2; i++)
            {
                // sinh ngau nhien 1 loai pokemon, nam trong khoang tu 1 -> _numOfType
                int typeOfPokemon = random.Next(1, _numOfType + 1);
                //nsole.WriteLine(i);
                // sinh ra o thu 1 chua pokemon, yeu cau la khong dc nam trong cellIndex
                int cell1 = random.Next(random.Next(0, width * height + 1));
                while (cellIndex.Contains(cell1))
                    cell1 = random.Next(random.Next(0, width * height + 1));
                table[cell1 / width, cell1 % width] = typeOfPokemon;
                cellIndex.Add(cell1);

                // sinh ra o thu 2 chua pokemon, yeu cau la khong dc nam trong cellIndex
                int cell2 = random.Next(random.Next(0, width * height + 1));
                while (cellIndex.Contains(cell2))
                    cell2 = random.Next(random.Next(0, width * height + 1));
                table[cell2 / width, cell2 % width] = typeOfPokemon;
                cellIndex.Add(cell2);


            }
            for (int i = 0; i < width; i++)
            {
                table[0, i] = 0;
                cellIndex.Add(i);
                table[height - 1, i] = 0;
                cellIndex.Add(i + (height - 1) * width);

            }
            for (int i = 1; i < height - 1; i++)
            {
                table[i, 0] = 0;
                cellIndex.Add(width * i);
                table[i, width - 1] = 0;
                cellIndex.Add(width - 1 + width * i);
            }
        }
        private bool checkLineX(int y1, int y2, int x)
        {
            int max = Math.Max(y1, y2);
            int min = Math.Min(y1, y2);
            for (int y = min + 1; y < max; y++)
            {
                if (table[x, y] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool checkLineY(int x1, int x2, int y)
        {
            int max = Math.Max(x1, x2);
            int min = Math.Min(x1, x2);
            for (int x = min + 1; x < max; x++)
            {
                if (table[x, y] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        private int checkRectX(Point p1, Point p2)
        {
            Point pminY = p1, pmaxY = p2;
            if (p1.Y > p2.Y)
            {
                pminY = p2;
                pmaxY = p1;
            }
            for (int y = pminY.Y; y <= pmaxY.Y; y++)
            {
                if (y > pminY.Y && table[pminY.X, y] != 0)
                {
                    return -1;
                }
                if ((table[pmaxY.X, y] == 0|| y == pmaxY.Y)
                    && checkLineY(pminY.X, pmaxY.X, y)
                    && checkLineX(y, pmaxY.Y, pmaxY.X))
                {
                    return y;
                }

                
            }
            return -1;

        }
        private int checkRectY(Point p1, Point p2)
        {
            Point pminX = p1, pmaxX = p2;
            if (p1.X > p2.X)
            {
                pminX = p2;
                pmaxX = p1;
            }
            for (int x = pminX.X; x <= pmaxX.X; x++)
            {
                if (x > pminX.X && table[x, pminX.Y] != 0)
                {
                    return -1;
                }
                if ((table[x,pmaxX.Y] == 0)
                    && checkLineX(pminX.Y, pmaxX.Y,x )
                    && checkLineY(x, pmaxX.X, pmaxX.Y))
                {
                    return x;
                }


            }
            return -1;
        }
        private int checkMoreLineX(Point p1, Point p2, int type)
        {
            Point pMinY = p1, pMaxY = p2;
            if (p1.Y > p2.Y)
            {
                pMinY = p2;
                pMaxY = p1;
            }
            int y = pMaxY.Y + type;
            int row = pMinY.X;
            int colFinish = pMaxY.Y;
            if (type == -1)
            {
                colFinish = pMinY.Y;
                y = pMinY.Y + type;
                row = pMaxY.X;
            }
            if((table[row,colFinish] == 0 || pMinY.Y == pMaxY.Y)
                && checkLineX(pMinY.Y, pMaxY.Y, row))
            {
                while (table[pMinY.X, y] == 0 && table[pMaxY.X, y] == 0)
                {
                    if (checkLineY(pMinY.X, pMaxY.X, y))
                    {
                        return y;
                    }
                    y += type;
                }    
            }    
            return -1;
        }
        private int checkMoreLineY(Point p1, Point p2, int type)
        {
            
            Point pMinX = p1, pMaxX = p2;
            if (p1.X > p2.X)
            {
                pMinX = p2;
                pMaxX = p1;
            }
            int x = pMaxX.X + type;
            int col = pMinX.Y;
            int rowFinish = pMaxX.X;
            if (type == -1)
            {
                rowFinish = pMinX.X;
                x = pMinX.X + type;
                col = pMaxX.Y;
            }
            if ((table[rowFinish,col] == 0 || pMinX.X == pMaxX.X)
                    && checkLineY(pMinX.X, pMaxX.X, col))
            {
                while (table[x,pMinX.Y] == 0
                        && table[x,pMaxX.Y] == 0)
                {
                    if (checkLineX(pMinX.Y, pMaxX.Y, x))
                    {
                        return x;
                    }
                    x += type;
                }
            }
            return -1;
        }
        public bool checkTwoPoint(Point p1, Point p2)
        {

            if (p1.X == p2.X)
            {
                if (checkLineX(p1.Y, p2.Y, p1.X))
                {
                    return true;
                }
            }
            if (p1.Y == p2.Y)
            {
                if (checkLineY(p1.X, p2.X, p1.Y))
                {
                    return true;
                }
            }
            if (checkRectX(p1, p2) != -1)
            {
                return true;
            }
            if (checkRectY(p1, p2) != -1)
            {
                return true;
            }
            if (checkMoreLineX(p1, p2, 1) != -1)
            {
                return true;
            }
            if (checkMoreLineX(p1, p2, -1) != -1)
            {
                return true;
            }
            if (checkMoreLineY(p1, p2, 1) != -1)
            {
                return true;
            }
            if (checkMoreLineY(p1, p2, -1) != -1)
            {
                return true;
            }

            return false;

        }
    }
    
}
