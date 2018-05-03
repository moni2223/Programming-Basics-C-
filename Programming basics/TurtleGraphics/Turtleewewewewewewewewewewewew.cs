using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;
namespace TurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            float a = 90*3;
            for (int i=1;i<=10;i++)
            {
                float h = (float)(a * Math.Sqrt(3) / 2);
                Turtle.PenUp();
                Turtle.Forward(h);
                Turtle.PenDown();

                Turtle.Rotate(90);
                Turtle.Forward(a / 2);

                Turtle.Rotate(60);
                Turtle.Forward(a);
                Turtle.Rotate(60);
                Turtle.Forward(a);
                Turtle.Rotate(60);
                Turtle.Forward(a);
                Turtle.Rotate(60);
                Turtle.Forward(a);
                Turtle.Rotate(60);
                Turtle.Forward(a);

                Turtle.Rotate(60);
                Turtle.Forward(a / 2);

                Turtle.Rotate(90);

                Turtle.PenUp();
                Turtle.Forward(h);
                Turtle.PenDown();
                Turtle.Rotate(180);
                a = a * 0.9F;
            }
        }
    }
}
