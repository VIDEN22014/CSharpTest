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
        static CNode returnCNodeByChar()
        {
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
                if (input[1] == 'i')
                {
                    if (input[2] == 'n')
                    {
                        input = input.Remove(0, 3);
                        return new CNodeSin();
                    }
                }
            }
            if (input[0] == 'c')
            {
                if (input[1] == 'o')
                {
                    if (input[2] == 's')
                    {
                        input = input.Remove(0, 3);
                        return new CNodeCos();
                    }
                }
            }
            if (input[0] >= 48 && input[0] <= 57)
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
        }
        class CNodeMultiply : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() * leftRef.Return());
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
        }
        class CNodePlus : CNode
        {
            CNode leftRef = returnCNodeByChar();
            CNode rightRef = returnCNodeByChar();
            override public double Return()
            {
                return (rightRef.Return() + leftRef.Return());
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
        }
        class CNodeSin : CNode
        {
            CNode leftRef = returnCNodeByChar();
            override public double Return()
            {
                return (Math.Sin(leftRef.Return()));
            }
        }
        class CNodeCos : CNode
        {
            CNode leftRef = returnCNodeByChar();
            override public double Return()
            {
                return (Math.Cos(leftRef.Return()));
            }
        }

        class CNodeDouble : CNode
        {
            double x;
            public CNodeDouble()
            {
                int i = 0;
                string temp = "";
                if (input[0] == '|')
                {
                    x = 1;
                    return;
                }
                while ((input[i] >= 48 && input[i] <= 57))
                {
                    temp += input[i];
                    i++;
                }
                temp = reverseString(temp);
                i = 0;
                foreach (var item in temp)
                {
                    x += (item - 48) * Math.Pow(10, i);
                    i++;
                }
                input = input.Remove(0, temp.Length);
            }
            override public double Return()
            {
                return x;
            }
        }

        string textBoxToString(TextBox textBox)
        {
            return textBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = textBoxToString(textBox1) + "|";
            CNode head = returnCNodeByChar();
            label1.Text = Convert.ToString(head.Return());
        }
        static string reverseString(string originalString)
        {
            return new string(originalString.Reverse().ToArray());
        }
    }
}
