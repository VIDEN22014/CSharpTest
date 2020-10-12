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
        static double leftBorder, rightBorder, step;
        static RadioButton[] functionChecker = new RadioButton[3];
        public Form1()
        {
            InitializeComponent();
            functionChecker[0] = func1;
            functionChecker[1] = func2;
            functionChecker[2] = func3;
        }
        static double getY(double x)
        {
            if (functionChecker[0].Checked == true)
            {
                return Math.Sin(x);
            }
            if (functionChecker[1].Checked == true)
            {
                return Math.Sqrt(x) - 1;
            }
            if (functionChecker[2].Checked == true)
            {
                return 2 * Math.Pow(x, 3);
            }
            return 0;
        }
        interface IIntegral
        {
            double Integrate();
        }
        class MidRectangleMethod : IIntegral
        {
            double area = 0;
            public MidRectangleMethod() { }
            public double Integrate()
            {
                for (double x = leftBorder + step / 2; x < rightBorder; x += step)
                {
                    area += step * getY(x);
                }
                return area;
            }
        }
        class TrapeziumMethod : IIntegral
        {
            double area = 0, numOfPartition = (rightBorder - leftBorder) / step, x = leftBorder + step;
            public TrapeziumMethod() { }
            public double Integrate()
            {
                area += (getY(leftBorder) + getY(rightBorder)) / 2.0;
                for (double i = 1; i < numOfPartition; i++)
                {
                    area += getY(x);
                    x += step;
                }
                area *= step;
                return area;
            }
        }
        class SimpsonMethod : IIntegral
        {
            double area = 0, numOfPartition = (rightBorder - leftBorder) / step, x = leftBorder + step;
            public SimpsonMethod() { }
            public double Integrate()
            {
                double sum = 0;
                area += getY(leftBorder) + getY(rightBorder);
                for (double x = leftBorder + step / 2; x < rightBorder; x += step)
                {
                    sum += getY(x);
                }
                sum *= 4.0;
                area += sum;
                sum = 0;
                x = leftBorder + step;
                for (double i = 1; i < numOfPartition; i++)
                {
                    sum += getY(x);
                    x += step;
                }
                sum *= 2.0;
                area += sum;
                area *= (step / 6);
                return area;
            }
        }
        double ethaloneIntegral()
        {
            if (functionChecker[0].Checked == true)
            {
                return (-1 * Math.Cos(rightBorder)) - (-1 * Math.Cos(leftBorder));
            }
            if (functionChecker[1].Checked == true)
            {
                return 2.0 / 3.0 * Math.Pow(rightBorder, 3.0 / 2.0) - 2.0 / 3.0 * Math.Pow(leftBorder, 3.0 / 2.0) - (rightBorder - leftBorder);
            }
            if (functionChecker[2].Checked == true)
            {
                return 1.0 / 2.0 * Math.Pow(rightBorder, 4) - 1.0 / 2.0 * Math.Pow(leftBorder, 4);
            }
            return 0;
        }
        double TextBoxToDouble(TextBox textBox)
        {
            if (textBox.Text == "") { return 0; }
            return Convert.ToDouble(textBox.Text);
        }
        void drawGraph(Chart functionGraph)
        {
            double graphStep = (rightBorder - leftBorder) / 1000;
            functionGraph.Series[0].Points.Clear();
            for (double i = leftBorder; i <= rightBorder; i += graphStep)
            {
                functionGraph.Series[0].Points.AddXY(i, getY(i));
            }
        }
        private void integrateButton(object sender, EventArgs e)
        {
            leftBorder = TextBoxToDouble(leftBorderIN);
            rightBorder = TextBoxToDouble(rightBorderIN);
            if (TextBoxToDouble(numOfPartitioinIN) > 0 && leftBorder < rightBorder)
            {
                step = (rightBorder - leftBorder) / TextBoxToDouble(numOfPartitioinIN);
                MidRectangleMethod methodRectangle = new MidRectangleMethod();
                TrapeziumMethod methodTrapezium = new TrapeziumMethod();
                SimpsonMethod methodSimpson = new SimpsonMethod();
                rectangeMethodArea.Text = "Площа Методом Середніх Прямокутників = " + Convert.ToString(methodRectangle.Integrate());
                trapeziumMethodArea.Text = "Площа Методом Трапецій = " + Convert.ToString(methodTrapezium.Integrate());
                simpsonMethodArea.Text = "Площа Методом Сімпсона = " + Convert.ToString(methodSimpson.Integrate());
                ethaloneIntegralArea.Text = "Еталонна Площа = " + ethaloneIntegral();
                drawGraph(functionGraph);
            }
        }
    }
}
