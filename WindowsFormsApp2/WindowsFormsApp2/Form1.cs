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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static int dataSize;
        static int interpolatedDataSize;
        static int interpolatedHermiteDataSize;
        public Form1()
        {
            InitializeComponent();
        }
        struct point
        {
            public double posx { get; set; }
            public double posy { get; set; }
        }
        abstract class СInterpolation
        {
            protected point[] data { get; set; }
            protected point[] interpolatedData { get; set; }
            public СInterpolation(int dataSize, int interpolatedDataSize)
            {
                data = new point[dataSize];
                interpolatedData = new point[interpolatedDataSize];
                for (int i = 0; i < dataSize; i++)
                {
                    data[i].posx = i * (Math.PI * 2 / (dataSize - 1));
                    data[i].posy = Math.Sin(data[i].posx);
                }
                for (int i = 0; i < interpolatedDataSize; i++)
                {
                    interpolatedData[i].posx = i * (Math.PI * 2 / (interpolatedDataSize - 1));
                }
            }
        }

        class LineInterpolation : СInterpolation
        {
            public LineInterpolation(int dataSize, int interpolatedDataSize) : base(dataSize, interpolatedDataSize){}
            public point[] Interpolate()
            {
                double vectX, vectY;
                for (int i = 0; i < interpolatedDataSize; i++)
                {
                    for (int j = 0; j < dataSize; j++)
                    {
                        if (interpolatedData[i].posx >= data[j].posx && interpolatedData[i].posx <= data[j + 1].posx)
                        {
                            vectX = data[j + 1].posx - data[j].posx;
                            vectY = data[j + 1].posy - data[j].posy;
                            interpolatedData[i].posy = data[j].posy + ((interpolatedData[i].posx - data[j].posx) * vectY / vectX);
                            break;
                        }
                    }
                }
                return interpolatedData;
            }
        }

        class HermiteInterpolation : СInterpolation
        {
            point[] dxData { get; set; }
            public HermiteInterpolation(int dataSize, int interpolatedHermiteDataSize) : base(dataSize, interpolatedHermiteDataSize)
            {
                dxData = new point[dataSize];
                for (int i = 0; i < dataSize; i++)
                {
                    dxData[i].posx = data[i].posx;
                    dxData[i].posy = Math.Cos(dxData[i].posx);
                }
            }
            public point[] Interpolate()
            {
                double x,x0, x1,u0,u1,u2,u3;
                for (int i = 0; i < interpolatedHermiteDataSize; i++)
                {
                    for (int j = 0; j < dataSize; j++)
                    {
                        if (interpolatedData[i].posx >= data[j].posx && interpolatedData[i].posx <= data[j + 1].posx)
                        {
                            x = interpolatedData[i].posx;
                            x0 = data[j].posx;
                            x1 = data[j+1].posx;
                            u0 =(1+2*((x-x0)/(x1-x0)))*Math.Pow(((x1-x)/(x1-x0)),2)*data[j].posy;
                            u1 = (x-x0)* Math.Pow(((x1 - x) / (x1 - x0)), 2) * dxData[j].posy;
                            u2 = (1 + 2 * ((x1 - x) / (x1 - x0))) * Math.Pow(((x0 - x) / (x0 - x1)), 2) * data[j+1].posy;
                            u3 = (x - x1) * Math.Pow(((x0 - x) / (x0 - x1)), 2) * dxData[j+1].posy;
                            interpolatedData[i].posy = u0 + u1 + u2 + u3;
                            break;
                        }
                    }
                }
                return interpolatedData;
            }
        }
        public int textBoxToInt(TextBox sender)
        {
            if (sender.Text == "") { return 0; }
            return Convert.ToInt32(sender.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxToInt(textBox1) <= 1 || textBoxToInt(textBox2) <= 1 || textBoxToInt(textBox3) < 1)
            {
                return;
            }
            //
            dataSize = textBoxToInt(textBox1);
            interpolatedDataSize = textBoxToInt(textBox2);
            interpolatedHermiteDataSize = textBoxToInt(textBox3);
            LineInterpolation interpolationLinear = new LineInterpolation(dataSize, interpolatedDataSize);
            HermiteInterpolation interpolationHermite = new HermiteInterpolation(dataSize, interpolatedHermiteDataSize);
            double x, y;
            //
            chart1.Series[0].Points.Clear();
            if (checkBox1.Checked)
            {
                for (int i = 0; i < 100; i++)
                {
                    x = i * (Math.PI * 2 / (99));
                    y = Math.Sin(x);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
            chart1.Series[1].Points.Clear();
            if (checkBox2.Checked)
            {
                point[] linear = interpolationLinear.Interpolate();
                for (int i = 0; i < interpolatedDataSize; i++)
                {
                    chart1.Series[1].Points.AddXY(linear[i].posx, linear[i].posy);
                }
            }
            chart1.Series[2].Points.Clear();
            if (checkBox3.Checked)
            {
                point[] hermite = interpolationHermite.Interpolate();
                for (int i = 0; i < interpolatedHermiteDataSize; i++)
                {
                    chart1.Series[2].Points.AddXY(hermite[i].posx, hermite[i].posy);
                }
            }
            chart1.Series[3].Points.Clear();
            if (checkBox4.Checked)
            {
                for (int i = 0; i < dataSize; i++)
                {
                    x = i * (Math.PI * 2 / (dataSize - 1));
                    y = Math.Sin(x);
                    chart1.Series[3].Points.AddXY(x, y);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsVisibleInLegend = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].IsVisibleInLegend = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[2].IsVisibleInLegend = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[3].IsVisibleInLegend = checkBox4.Checked;
        }
    }
}
