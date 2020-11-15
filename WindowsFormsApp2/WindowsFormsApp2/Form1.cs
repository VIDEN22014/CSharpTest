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
        class CTree
        {
            public CNode headRef { get; set; }
            public CTree() { }
            public CTree(CNode node)
            {
                Init(node);
            }
            public static CTree operator +(CTree c1, CTree c2)
            {
                CTree temp = new CTree(c1.headRef);
                AddToCTree(temp, c2);
                return temp;
            }
            public void Init(CNode node)
            {
                headRef = node;
            }
            public double Return()
            {
                return headRef.Return();
            }
            public string Print()
            {
                return headRef.Print();
            }

        }
        abstract class CNode
        {
            public CNode() { }
            virtual public CNode ReturnLeftRef()
            {
                return new CNodeDouble();
            }
            virtual public void SetLeftRef(CNode node)
            {
                return;
            }
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
            CNode leftRef = InitCTree();
            CNode rightRef = InitCTree();
            override public double Return()
            {
                return (rightRef.Return() * leftRef.Return());
            }
            public override string Print()
            {
                return "*" + leftRef.Print() + " " + rightRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodeDivide : CNode
        {
            CNode leftRef = InitCTree();
            CNode rightRef = InitCTree();
            override public double Return()
            {
                return (rightRef.Return() / leftRef.Return());
            }
            public override string Print()
            {
                return "/" + leftRef.Print() + " " + rightRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodePlus : CNode
        {
            CNode leftRef = InitCTree();
            CNode rightRef = InitCTree();
            override public double Return()
            {
                return (rightRef.Return() + leftRef.Return());
            }
            public override string Print()
            {
                return "+" + leftRef.Print() + " " + rightRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodeMinus : CNode
        {
            CNode leftRef = InitCTree();
            CNode rightRef = InitCTree();
            override public double Return()
            {
                return (rightRef.Return() - leftRef.Return());
            }
            public override string Print()
            {
                return "-" + leftRef.Print() + " " + rightRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodeSin : CNode
        {
            CNode leftRef = InitCTree();
            override public double Return()
            {
                return (Math.Sin(leftRef.Return()));
            }
            public override string Print()
            {
                return "sin " + leftRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodeCos : CNode
        {
            CNode leftRef = InitCTree();
            override public double Return()
            {
                return (Math.Cos(leftRef.Return()));
            }
            public override string Print()
            {
                return "cos " + leftRef.Print();
            }
            public override CNode ReturnLeftRef()
            {
                return leftRef;
            }
            public override void SetLeftRef(CNode node)
            {
                leftRef = node;
                return;
            }
        }
        class CNodeDouble : CNode
        {
            double num;
            public CNodeDouble()
            {
                num = stringToDouble();
            }
            override public double Return()
            {
                return num;
            }
            public override string Print()
            {
                return Convert.ToString(num);
            }
        }
        class CNodeVar : CNode
        {
            string varName = "";
            public CNodeVar()
            {
                foreach (char item in input)
                {
                    if (item >= 48 && item <= 57)
                    {
                        varName += item;
                    }
                    else if (item >= 64 && item <= 90)
                    {
                        varName += item;
                    }
                    else if (item >= 97 && item <= 122)
                    {
                        varName += item;
                    }
                    else { break; }
                }
                input = input.Remove(0, varName.Length);
                //Зчитування Назви Змінної
                bool isFind = false;
                foreach (var item in Vars)
                {
                    if (item.Key == varName)
                    {
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    Vars.Add(varName, 1);
                }
            }
            override public double Return()
            {
                foreach (var item in Vars)
                {
                    if (item.Key == varName)
                    {
                        return item.Value;
                    }
                }
                return 1;
            }
            public override string Print()
            {
                return varName;
            }
        }
        //Methods
        string textBoxToString(TextBox textBox)
        {
            return textBox.Text;
        }
        void AddVarToDictionary()
        {
            int varsSize = Vars.Count;
            for (int i = 0; i < varsSize; i++)
            {
                int j = 0;
                double x = stringToDouble();
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
            foreach (char item in input)
            {
                if (item == 32)
                {
                    input = input.Remove(0, 1);
                }
                else
                {
                    break;
                }
            }//Видаляє всі зайві пробіли
            foreach (char item in input)
            {
                if ((item >= 48 && item <= 57))
                {
                    temp += item;
                }
                else
                {
                    break;
                }
            }//Записує число в string
            if (temp.Length != 0)
            {
                temp = reverseString(temp);
                for (int i = 0; i < temp.Length; i++)
                {
                    x += (temp[i] - 48) * Math.Pow(10, i);
                }
                input = input.Remove(0, temp.Length);
            }//Перетворює string в double
            if (x == 0)
            {
                return 1;
            }
            return x;
        }
        static void AddToCTree(CTree c1, CTree c2)
        {
            CNode toAdd = c2.headRef;
            CNode tempPtr = c1.headRef;
            if (tempPtr.GetType().Name == "CNodeDouble" || tempPtr.GetType().Name == "CNodeVar")
            {
                headCtree.headRef = toAdd;
                return;
            }
            while (true)
            {
                if (tempPtr.ReturnLeftRef().GetType().Name == "CNodeDouble" || tempPtr.ReturnLeftRef().GetType().Name == "CNodeVar")
                {
                    tempPtr.SetLeftRef(toAdd);
                    return;
                }
                else
                {
                    tempPtr = tempPtr.ReturnLeftRef();
                }
            }
        }
        string ReturnCommandName()
        {
            input = textBoxToString(consoleIN);
            string temp = "";
            foreach (char item in input)
            {
                if (item >= 97 && item <= 122)
                {
                    temp += item;
                }
                else break;
            }
            input = input.Remove(0, temp.Length);
            return temp;
        }
        static CNode InitCTree()
        {
            if (input.Length == 0)
            {
                return new CNodeDouble();
            }
            else if (input[0] == '+')
            {
                input = input.Remove(0, 1);
                return new CNodePlus();
            }
            else if (input[0] == '-')
            {
                input = input.Remove(0, 1);
                return new CNodeMinus();
            }
            else if (input[0] == '*')
            {
                input = input.Remove(0, 1);
                return new CNodeMultiply();
            }
            else if (input[0] == '/')
            {
                input = input.Remove(0, 1);
                return new CNodeDivide();
            }
            if (input.Length < 3) { }
            else if (input[0] == 's')
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
            else if (input[0] == 'c')
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
            else
            {
                input = input.Remove(0, 1);
                return InitCTree();
            }
        }
        static CTree headCtree = new CTree();
        private void enterCommandButton_Click(object sender, EventArgs e)
        {
            string command = ReturnCommandName();
            string consoleText = "";
            if (command == "enter")
            {
                Vars.Clear();
                headCtree.Init(InitCTree());
            }
            else if (command == "vars")
            {
                foreach (var item in Vars)
                {
                    consoleText += item.Key + " ";
                }
            }
            else if (command == "print")
            {
                consoleText = headCtree.Print();
            }
            else if (command == "comp")
            {
                AddVarToDictionary();
                consoleText = Convert.ToString(headCtree.Return());
            }
            else if (command == "join")
            {
                CTree c1 = new CTree(InitCTree());
                headCtree = headCtree + c1;
                consoleText = headCtree.Print();
            }
            else
            {
                MessageBox.Show(
                "Wrong Command",
        "Error"
                );
            }
            if (input.Length != 0)
            {
                MessageBox.Show(
                "Too much args",
        "Error"
                );
            }
            consoleOut.Text = consoleText;
        }
    }
}