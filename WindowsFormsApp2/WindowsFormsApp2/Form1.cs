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
                data[dataSize - 1].posy = 0;
                for (int i = 0; i < interpolatedDataSize; i++)
                {
                    interpolatedData[i].posx = i * (Math.PI * 2 / (interpolatedDataSize - 1));
                }
            }

        }

        class LineInterpolation : СInterpolation
        {
            public LineInterpolation(int dataSize, int interpolatedDataSize) : base(dataSize, interpolatedDataSize) { }
            public point[] Interpolate()
            {
                double x, y;
                for (int i = 1; i < interpolatedDataSize; i++)
                {
                    for (int j = 0; j < dataSize - 1; j++)
                    {
                        if (interpolatedData[i].posx > data[j].posx && interpolatedData[i].posx <= data[j + 1].posx)
                        {
                            x = data[j + 1].posx - data[j].posx;
                            y = data[j + 1].posy - data[j].posy;
                            interpolatedData[i].posy = data[j].posy + ((interpolatedData[i].posx - data[j].posx) * y / x);
                        }
                    }
                }
                return interpolatedData;
            }
        }

        class HermiteInterpolation : СInterpolation
        {
            point[] dxData { get; set; }
            public HermiteInterpolation(int dataSize, int interpolatedHermiteDataSize) : base(dataSize, ((interpolatedHermiteDataSize+1) * (dataSize-1)) + 1)
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
                int interval = 0;
                int dataIndex = 0;
                double Ax, Bx, dxAx, dxBx, Ay, By, dxAy, dxBy, t = 0,i=0;
                while (interval < (dataSize - 1))
                {
                    Ax = data[interval].posx;
                    Ay = data[interval].posy;
                    Bx = data[interval + 1].posx;
                    By = data[interval + 1].posy;
                    dxAx = dxData[interval].posx;
                    dxAy = dxData[interval].posy;
                    dxBx = dxData[interval + 1].posx;
                    dxBy = dxData[interval + 1].posy;
                    interpolatedData[dataIndex].posx = Ax + dxAx * t + (-3 * Ax + 3 * Bx - 2 * dxAx - dxBx) * Math.Pow(t, 2) + (2 * Ax - 2 * Bx + dxAx + dxBx) * Math.Pow(t, 3);
                    interpolatedData[dataIndex].posy = Ay + dxAy * t + (-3 * Ay + 3 * By - 2 * dxAy - dxBy) * Math.Pow(t, 2) + (2 * Ay - 2 * By + dxAy + dxBy) * Math.Pow(t, 3);
                    dataIndex++;
                    t = t + 1 / (interpolatedHermiteDataSize + 1.0);
                    i++;
                    if (i > interpolatedHermiteDataSize)
                    {
                        t = 0;
                        i = 0;
                        interval++;
                    }
                }
                return interpolatedData;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public int textBoxToInt(TextBox sender)
        {
            if (sender.Text == "") { return 0; }
            return Convert.ToInt32(sender.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxToInt(textBox1) <= 1 || textBoxToInt(textBox2) <= 1||textBoxToInt(textBox3)<1)
            {
                return;
            }
            dataSize = textBoxToInt(textBox1);
            interpolatedDataSize = textBoxToInt(textBox2);
            interpolatedHermiteDataSize = textBoxToInt(textBox3);
            LineInterpolation interpolationLinear = new LineInterpolation(dataSize, interpolatedDataSize);
            HermiteInterpolation interpolationHermite = new HermiteInterpolation(dataSize, interpolatedHermiteDataSize);
            chart1.Series[0].Points.Clear();
            if (checkBox1.Checked)
            {
                double x, y;
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
                for (int i = 0; i < ((interpolatedHermiteDataSize+1) * (dataSize - 1)) + 1 ; i++)
                {
                    chart1.Series[2].Points.AddXY(hermite[i].posx, hermite[i].posy);
                }
            }
            chart1.Series[3].Points.Clear();
            if (checkBox4.Checked)
            {
                double x, y;
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
