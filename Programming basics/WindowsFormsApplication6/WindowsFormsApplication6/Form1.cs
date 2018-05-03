using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox1.Text);
            int month = int.Parse(textBox2.Text);
            if(day<1 || day>31)
            {
                textBox3.Text = "Невалидни дни";
            }
            else
            if(month<1 || month>12)
            {
                textBox3.Text = "Невалидни месеци";
            }
            else
                if(month==2 && day>28)
            {
                textBox3.Text = "Феврурари има 28 дни";
            }
            else
                if(month==4 ||month==6 || month==9 || month==11 && day>30)
            {
                textBox3.Text = "Този месец има само 30 дни";
            }
            else
            {
                textBox3.Text = "Датата е валидна!";
            }
        }
    }
}
