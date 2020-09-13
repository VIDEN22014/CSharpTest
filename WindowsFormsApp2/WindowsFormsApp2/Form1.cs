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
        private double textBoxToDouble(TextBox sender)
        {
            if (sender.Text == "") { return 0; }
            return Convert.ToDouble(sender.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grad = 0, amp1 = 0, amp2 = 0, freq1 = 0, freq2 = 0, ratio = 0;
            grad = textBoxToDouble(textBox1);
            amp1 = textBoxToDouble(textBox2);
            amp2 = textBoxToDouble(textBox3);
            freq1 = textBoxToDouble(textBox4);
            freq2 = textBoxToDouble(textBox5);

            ratio = freq1 / freq2;

            chart1.Series[0].Points.Clear();
            for (double i = 0; i < 50; i += 0.01)
            {
                chart1.Series[0].Points.AddXY(amp1 * Math.Sin(i*10 + grad * (Math.PI) / 180.0), amp2 * Math.Sin(i *10* (1 / ratio)));
            }
        }
    }
}
