
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Collision
{
    public class Ball
    {

        public int r;
        //Random rnd = new Random();
        public PointF p, v;
        public Color c;
        //public SolidBrush brush;


        public Ball(Random rnd, Size s)
        {
            p = new PointF(rnd.Next(150, s.Width-150), rnd.Next(150, s.Height-150));
            r = rnd.Next(50, 80);
            //p = new PointF(rnd.Next(s.Width - r), rnd.Next(s.Height - r));
            v = new PointF(rnd.Next(-20, 20), rnd.Next(-20, 20));
            c = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

            //brush = new SolidBrush(c);
        }
        public void CreateBall(Graphics g, PictureBox pct)
        {

            //g.FillEllipse(brush, p.X, p.Y, r, r);
            //pct.Invalidate();
        }

        public void MoveBall(PictureBox pct)
        {
            p.X += v.X;
            p.Y += v.Y;

            if (p.X < 0 || p.X + r > pct.Width) 
            {

                v.X = -v.X;
                
            }
            else if (p.Y < 0 || p.Y + r > pct.Height)
            {
                v.Y = -v.Y;
            }
        }
    }
}