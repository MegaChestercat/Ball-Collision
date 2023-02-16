using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collision
{
    public partial class Form1 : Form
    {

        Canvas canvas;
     
        
        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(PCT_CANVAS);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.MoveBall();
        }

        
    }
}

