
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Collision
{
    public class Canvas
    {
        static Bitmap bmp;
        static Graphics g;
        PictureBox pct;
        List<Ball> balls ;
        static Random rand = new Random();

        public Canvas(PictureBox pct)
        {
            balls = new List<Ball>();
            this.pct = pct;
            bmp = new Bitmap(pct.Width, pct.Height);
            g = Graphics.FromImage(bmp);
            pct.Image = bmp;

            for (int i = 0; i < 5; i++)
            {
                balls.Add(new Ball(rand, bmp.Size));
            }
        }

        public void CreateBall()
        {
            g.Clear(Color.Black);
            Ball b;
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].MoveBall(pct);
                b = balls[i];
                g.FillEllipse(new SolidBrush(balls[i].c), b.p.X, b.p.Y, b.r, b.r);
            }
            pct.Invalidate();
        }
 
    }
}