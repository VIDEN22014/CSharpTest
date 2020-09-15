using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public double textBoxToDouble(TextBox sender)
        {
            if (sender.Text == "") { return 0; }
            return Convert.ToDouble(sender.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double delta = 0, A = 0, B = 0, a = 0, b = 0, ratio = 0, x = 0, y = 0;
            delta = textBoxToDouble(textBox1);
            A = textBoxToDouble(textBox2);
            B = textBoxToDouble(textBox3);
            a = textBoxToDouble(textBox4);
            b = textBoxToDouble(textBox5);
            ratio = b / a;
            chart1.Series[0].Points.Clear();
            for (double t = 0; t < 50; t += 0.01)
            {
                x = A * Math.Sin(t * 10 + delta * Math.PI / 180.0);
                y = B * Math.Sin(t * 10 * ratio);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
