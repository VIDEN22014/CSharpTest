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

        static string input;
        static Dictionary<string, double> Vars = new Dictionary<string, double>(0);
        static CNode returnCNodeByChar()
        {
            if (input.Length == 0)
            {
                return new CNodeDouble();
            }
            if (input[0] == ' ')
            {
                input = input.Remove(0, 1);
                return returnCNodeByChar();
            }
            if (input[0] == '+')
            {
                input = input.Remove(0, 1);
                return new CNodePlus();
            }
            if (input[0] == '-')
            {
                input = input.Remove(0, 1);
                return new CNodeMinus();
            }
            if (input[0] == '*')
            {
                input = input.Remove(0, 1);
                return new CNodeMultiply();
            }
            if (input[0] == '/')
            {
                input = input.Remove(0, 1);
                return new CNodeDivide();
            }
            if (input[0] == 's')
            {
                if (input.Length > 1)
                {
                    if (input[1] == 'i')
                    {
                        if (input.Length > 2)
                        {
                            if (input[2] == 'n')
                            {
                                input = input.Remove(0, 3);
                                return new CNodeSin();
                            }
                        }
                    }
                }
            }
            if (input[0] == 'c')
            {
                if (input.Length > 1)
                {
                    if (input[1] == 'o')
                    {
                        if (input.Length > 2)
                        {
                            if (input[2] == 's')
                            {
                                input = input.Remove(0, 3);
                                return new CNodeCos();
                            }
                        }
                    }
                }
            }
            if (input[0] >= 64 && input[0] <= 90)
            {
                return new CNodeVar();
            }
            else if (input[0] >= 97 && input[0] <= 122)
            {
                return new CNodeVar();
            }
            else if (input[0] >= 48 && input[0] <= 57)
            {
                return new CNodeDouble();
            }
            else { return new CNodeDouble(); }
        }
        class CTree
        {

        }
        abstract class CNode
        {
            public CNode() { }

            virtual public double Return()
            {
                return 0;
            }
            virtual public string Print()
            {
                return "";
            }
        }
        class CNodeMultiply : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() * leftRef.Return());
            }
            public override string Print()
            {
                return "*" + leftRef.Print() + " " + rightRef.Print();
            }
        }
        class CNodeDivide : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() / leftRef.Return());
            }
            public override string Print()
            {
                return "/" + leftRef.Print() + " " + rightRef.Print();
            }
        }
        class CNodePlus : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() + leftRef.Return());
            }
            public override string Print()
            {
                return "+" + leftRef.Print() + " " + rightRef.Print();
            }
        }
        class CNodeMinus : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() - leftRef.Return());
            }
            public override string Print()
            {
                return "-" + leftRef.Print() + " " + rightRef.Print();
            }
        }
        class CNodeSin : CNode
        {
            CNode leftRef = returnCNodeByChar();
            override public double Return()
            {
                return (Math.Sin(leftRef.Return()));
            }
            public override string Print()
            {
                return "sin " + leftRef.Print();
            }
        }
        class CNodeCos : CNode
        {
            CNode leftRef = returnCNodeByChar();
            override public double Return()
            {
                return (Math.Cos(leftRef.Return()));
            }
            public override string Print()
            {
                return "cos " + leftRef.Print();
            }
        }

        class CNodeDouble : CNode
        {
            double x;
            public CNodeDouble()
            {
                x = stringToDouble();
            }
            override public double Return()
            {
                return x;
            }
            public override string Print()
            {
                return Convert.ToString(x);
            }
        }
        class CNodeVar : CNode
        {
            string str = "";
            public CNodeVar()
            {
                foreach (char item in input)
                {
                    if (item >= 48 && item <= 57)
                    {
                        str += item;
                    }
                    else if (item >= 64 && item <= 90)
                    {
                        str += item;
                    }
                    else if (item >= 97 && item <= 122)
                    {
                        str += item;
                    }
                    else { break; }
                }
                input = input.Remove(0, str.Length);
                //Зчитування Змінної
                bool isFind = false;
                foreach (var item in Vars)
                {
                    if (item.Key == str)
                    {
                        isFind = true;
                    }
                }
                if (!isFind)
                {
                    Vars.Add(str, 1);
                }
            }
            override public double Return()
            {
                foreach (var item in Vars)
                {
                    if (item.Key == str)
                    {
                        return item.Value;
                    }
                }
                return 1;
            }
            public override string Print()
            {
                return str;
            }
        }

        string textBoxToString(TextBox textBox)
        {
            return textBox.Text;
        }

        void StringToVars()
        {
            int count = Vars.Count;
            for (int i = 0; i < count; i++)
            {
                int j = 0;
                double x = stringToDouble();
                //зчитує цифру
                foreach (var item in Vars)
                {
                    if (j == i)
                    {
                        string temp = item.Key;
                        Vars.Remove(temp);
                        Vars.Add(temp, x);
                        break;
                    }
                    j++;
                }
                //Додає в Словник
            }
        }
        static string reverseString(string originalString)
        {
            return new string(originalString.Reverse().ToArray());
        }
        static double stringToDouble()
        {
            double x = 0;
            string temp = "";
            bool isSpace = false;
            foreach (char item in input)
            {
                if ((item >= 48 && item <= 57))
                {
                    temp += item;
                }
                else if (item == 32) {
                    isSpace = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (temp.Length != 0)
            {
                temp = reverseString(temp);
                for (int k = 0; k < temp.Length; k++)
                {
                    x += (temp[k] - 48) * Math.Pow(10, k);
                }
                input = input.Remove(0, temp.Length+Convert.ToInt32(isSpace));
            }
            if (x == 0) { return 1; }
            return x;
        }
        CNode head;
        private void button1_Click(object sender, EventArgs e)
        {
            input = textBoxToString(textBox1);
            head = returnCNodeByChar();
            label1.Text = Convert.ToString(head.Return());
            label2.Text = head.Print();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input = textBoxToString(textBox1);
            StringToVars();
            label1.Text = Convert.ToString(head.Return());
            label2.Text = head.Print();
        }
    }
}
