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
        private double textBoxToDouble(TextBox sender) {
            char[] temp = new char[10];
            int size;
            bool isNegative = false;
            if (sender.Text == "") { return 0; }
            temp = sender.Text.ToCharArray();
            if (sender.Text[0] == '-')
            {
                isNegative = true;
                size = sender.Text.Length;
                for (int i = 0; i < size; i++)
                {
                    if (i != size - 1) { temp[i] = temp[i + 1]; }
                    else { temp[i] = '\0'; }
                }
            }
            string s = new string(temp);
            if (isNegative) { return -(1)*Convert.ToDouble(s); }
            else { return Convert.ToDouble(s);}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grad = 0,amp1=0,amp2=0,freq1=0,freq2=0,min=0;
            grad = textBoxToDouble(textBox1);
            amp1 = textBoxToDouble(textBox2);
            amp2 = textBoxToDouble(textBox3);
            freq1 = textBoxToDouble(textBox4);
            freq2 = textBoxToDouble(textBox5);

            if (freq1 >= freq2) {
                min = freq2;
            }
            else { min = freq1; }

            for (double i = min; i > 0; i--)
            {
                if (freq1 % i == 0 && freq2 % i == 0) {
                    freq1 /= i;
                    freq2 /= i;
                    break;
                }
            }

            chart1.Series[0].Points.Clear();
            for (double i = 0; i < 10; i+=0.01)
            {
                chart1.Series[0].Points.AddXY(amp1*Math.Sin(freq1*i+grad*(Math.PI)/180),amp2*Math.Sin(freq2*i));
            }

        }
    }
}
