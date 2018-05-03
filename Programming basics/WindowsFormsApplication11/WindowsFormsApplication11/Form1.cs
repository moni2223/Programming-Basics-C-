using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen p1 = new Pen(Color.Blue, 10);
            int x, y, w, h;
            x = y = 0;
            w = ClientSize.Width;
            h = ClientSize.Height;
            int eH = h / 5,eW = w / 5;

            for(int i=0; i<5; i++)
            {
                e.Graphics.DrawEllipse(Pens.Green, i * eW, 0, eW, eH);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
