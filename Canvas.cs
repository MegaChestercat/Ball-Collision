
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
        List<Ball> balls;
        //Ball ball;

        public Canvas(PictureBox pct)
        {
            balls = new List<Ball>();
            this.pct = pct;
            bmp = new Bitmap(pct.Width, pct.Height);
            for (int i = 0; i < 5; i++)
            {
                balls.Add(new Ball(bmp.Size));
            }
            Init();
        }

        public void Init()
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            pct.Image = bmp;
            pct.Invalidate();

            foreach(Ball ball in balls)
            {
                ball.CreateBall(g, pct);
            }
            

        }

        public void MoveBall()
        {

            foreach(Ball ball in balls)
            {
                ball.MoveBall(g, pct);
            }
            
            
           
        }
 
    }
}