using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(-b1 / a1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a2, b2, c2,x1,x2;
            a2 = Convert.ToDouble(textBox3.Text);
            b2 = Convert.ToDouble(textBox4.Text);
            c2 = Convert.ToDouble(textBox5.Text);
            x1 = (-b2 + Math.Sqrt(Math.Pow(b2, 2) - 4 * a2 * c2)) / (2 * a2);
            x2 = (-b2 - Math.Sqrt(Math.Pow(b2, 2) - 4 * a2 * c2)) / (2 * a2);
            label11.Text = Convert.ToString(x1);
            label12.Text = Convert.ToString(x2);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a3, b3, c3, d3, x, f1, f2;
            a3 = Convert.ToDouble(textBox6.Text);
            b3 = Convert.ToDouble(textBox7.Text);
            c3 = Convert.ToDouble(textBox8.Text);
            d3 = Convert.ToDouble(textBox9.Text);
            f1 =  -1*Math.Pow(b3, 3) / (27 * Math.Pow(a3, 3)) + b3 * c3 / (6 * Math.Pow(a3, 2)) - (d3 / (2 * a3));
            f2 = c3 / (3 * a3) - Math.Pow(b3, 2) / (9 * Math.Pow(a3, 2));
            x = Math.Pow(f1 + Math.Sqrt(Math.Pow(f1, 2) + Math.Pow(f2, 3)) , 0.333333) + Math.Pow(f1 - Math.Sqrt(Math.Pow(f1, 2) + Math.Pow(f2, 3)), 0.333333) - (b3/(3*a3));
            label23.Text = Convert.ToString(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
