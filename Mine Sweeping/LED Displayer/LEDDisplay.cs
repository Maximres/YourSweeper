using System;
using System.Drawing;
using System.Windows.Forms;


namespace Mine_Sweeping
{
    //Отображение клеток
    public class LEDDisplay
    {
        private Graphics myGraphics;

        private Brush brush = Brushes.Black;

        private bool whetherDrawShadow = true;

        private Color shadowColor = Color.FromArgb(60, Color.White);

        private Brush shadowBrush = null;

        private readonly Point[][] apt = new Point[7][];

        static byte[,] binaryDigital = {
         {1, 1, 1, 0, 1, 1, 1},       // 0
         {0, 0, 1, 0, 0, 1, 0},       // 1
         {1, 0, 1, 1, 1, 0, 1},       // 2
         {1, 0, 1, 1, 0, 1, 1},       // 3
         {0, 1, 1, 1, 0, 1, 0},       // 4
         {1, 1, 0, 1, 0, 1, 1},       // 5
         {1, 1, 0, 1, 1, 1, 1},       // 6
         {1, 0, 1, 0, 0, 1, 0},       // 7
         {1, 1, 1, 1, 1, 1, 1},       // 8
         {1, 1, 1, 1, 0, 1, 1}        // 9
           };


        public bool IsDrawShadow
        {
            get { return this.whetherDrawShadow; }
            set { this.whetherDrawShadow = value; }
        }

        public LEDDisplay(Graphics grfx)
        {
            this.myGraphics = grfx;

            apt[0] = new Point[] { new Point(3, 2), new Point(39, 2), new Point(31, 10), new Point(11, 10) };

            apt[1] = new Point[] { new Point(2, 3), new Point(10, 11), new Point(10, 31), new Point(2, 35) };

            apt[2] = new Point[] { new Point(40, 3), new Point(40, 35), new Point(32, 31), new Point(32, 11) };

            apt[3] = new Point[] { new Point(3, 36), new Point(11, 32), new Point(31, 32), new Point(39, 36), new Point(31, 40), new Point(11, 40) };

            apt[4] = new Point[] { new Point(2, 37), new Point(10, 41), new Point(10, 61), new Point(2, 69) };

            apt[5] = new Point[] { new Point(40, 37), new Point(40, 69), new Point(32, 61), new Point(32, 41) };

            apt[6] = new Point[] { new Point(11, 62), new Point(31, 62), new Point(39, 70), new Point(3, 70) };
        }

        public SizeF SizeDesign(string str, Font font)
        {
            SizeF sizef = new SizeF(0, myGraphics.DpiX * font.SizeInPoints / 72);

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    sizef.Width += 42 * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
                }
            }
            return sizef;
        }

        public void DrawString(string str, Font font, Brush brush, float x, float y)
        {
            this.brush = brush;

            this.shadowBrush = new SolidBrush(Color.FromArgb(40, ((SolidBrush)this.brush).Color));

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    x = Number(str[i] - '0', font, brush, x, y);
                }
            }
        }

        private float Number(int num, Font font, Brush brush, float x, float y)
        {
            for (int i = 0; i < apt.Length; i++)
            {
                if (whetherDrawShadow)
                {
                    Fill(apt[i], font, shadowBrush, x, y);
                }
                if (binaryDigital[num, i] == 1)
                {
                    Fill(apt[i], font, brush, x, y);
                }
            }
            return x + 42 * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
        }

        private float MinusSign(Font font, Brush brush, float x, float y)
        {
            Fill(apt[3], font, brush, x, y);

            return x + 42 * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
        }

        private float DrawSpace(Font font, Brush brush, float x, float y)
        {
            return x + 36 * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
        }

        private float Colon(Font font, Brush brush, float x, float y)
        {
            Point[][] apt = new Point[2][];

            apt[0] = new Point[] { new Point(4, 12), new Point(16, 12), new Point(16, 24), new Point(4, 24) };

            apt[1] = new Point[] { new Point(4, 50), new Point(16, 50), new Point(16, 62), new Point(4, 62) };

            for (int i = 0; i < apt.Length; i++)
            {
                Fill(apt[i], font, brush, x, y);
            }

            return x + 20 * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
        }

        private void Fill(Point[] apt, Font font, Brush brush, float x, float y)
        {
            PointF[] aptf = new PointF[apt.Length];

            for (int i = 0; i < apt.Length; i++)
            {
                aptf[i].X = x + apt[i].X * myGraphics.DpiX * font.SizeInPoints / 72 / 72;
                aptf[i].Y = y + apt[i].Y * myGraphics.DpiY * font.SizeInPoints / 72 / 72;
            }

            myGraphics.FillPolygon(brush, aptf);
        }
    }
}