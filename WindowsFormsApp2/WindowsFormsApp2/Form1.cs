﻿using System;
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
        static double leftBorder, rightBorder, step;
        static RadioButton[] radio = new RadioButton[3];
        public Form1()
        {
            InitializeComponent();
            radio[0] = radioButton1;
            radio[1] = radioButton2;
            radio[2] = radioButton3;
        }
        static double getY(double x)
        {
            if (radio[0].Checked == true)
            {
                return Math.Sin(x);
            }
            if (radio[1].Checked == true)
            {
                return Math.Sqrt(x) - 1;
            }
            return 0;
        }
        struct point
        {
            public double posx { get; set; }
            public double posy { get; set; }
        }
        interface IIntegral
        {
            double Integrate();
        }
        class MidRectangleMethod : IIntegral
        {
            double s = 0, h = leftBorder + step / 2;
            public MidRectangleMethod() { }
            public double Integrate()
            {
                while (h < rightBorder)
                {
                    s += step * getY(h);
                    h += step;
                }
                return s;
            }
        }
        class TrapeziumMethod : IIntegral
        {
            double s = 0;
            point[] data;
            public TrapeziumMethod()
            {
                double x = leftBorder;
                data = new point[Convert.ToInt32(Math.Ceiling((rightBorder - leftBorder) / step) + 1)];
                for (int i = 0; x < rightBorder; i++)
                {
                    data[i].posx = x;
                    data[i].posy = getY(x);
                    x += step;
                }
                data[data.Length - 1].posx = rightBorder;
                data[data.Length - 1].posy = getY(rightBorder);
            }
            public double Integrate()
            {
                s = (data[data.Length - 1].posy + data[0].posy) / 2;
                for (int i = 1; i < data.Length - 1; i++)
                {
                    s += data[i].posy;
                }
                s *= step;
                return s;
            }
        }
        double TextBoxToDouble(TextBox textBox)
        {
            if (textBox.Text == "") { return 0; }
            return Convert.ToDouble(textBox.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leftBorder = TextBoxToDouble(textBox1);
            rightBorder = TextBoxToDouble(textBox2);
            step = TextBoxToDouble(textBox3);
            MidRectangleMethod method1 = new MidRectangleMethod();
            TrapeziumMethod method2 = new TrapeziumMethod();
            label4.Text = "Площа Методом середніх прямокутників=" + Convert.ToString(method1.Integrate());
            label5.Text = "Площа Методом трапецій=" + Convert.ToString(method2.Integrate());
        }
    }
}
