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
        static Dictionary<string, CSparseMatrix> MatrixDictionary = new Dictionary<string, CSparseMatrix>(0);
        static string input = "";
        class CSparseMatrix
        {
            public List<CSparseCell> data = new List<CSparseCell>(0);
            public int dim = 1;
            public int[] dimValues;
            public int value = 1;
            public string name = "SparseMatrix";
            public CSparseMatrix()
            {
                dimValues = new int[1] { 1 };
            }
            public CSparseMatrix(int dim, int[] dimValues, int value, string name, List<CSparseCell> data)
            {
                this.dim = dim;
                this.dimValues = dimValues;
                this.value = value;
                this.name = name;
                if (name == "")
                {
                    this.name = "SparseMatrix";
                }
                this.data = data;
            }
            ~CSparseMatrix() {}
        }
        class CSparseCell
        {
            public int[] dimValues;
            public int value = 1;
            public CSparseCell() { }
            public CSparseCell(int[] dimValues, int value)
            {
                this.dimValues = dimValues;
                this.value = value;
            }
        }
        string textBoxToString(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return "";
            }
            return textBox.Text;
        }
        string inputToString()
        {
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
                if (item >= 97 && item <= 122)
                {
                    temp += item;
                }
                else if (item >= 65 && item <= 90)
                {
                    temp += item;
                }
                else if (item >= 48 && item <= 57)
                {
                    temp += item;
                }
                else break;
            }
            input = input.Remove(0, temp.Length);
            return temp;
        }
        static int inputToInt()
        {
            int x = 1;
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
                x = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    x += (temp[i] - 48) * (int)Math.Pow(10, i);
                }
                input = input.Remove(0, temp.Length);
            }//Перетворює string в int
            return x;
        }
        static string reverseString(string originalString)
        {
            return new string(originalString.Reverse().ToArray());
        }

        void Addmat()
        {
            int dim = 1;
            int[] dimValues;
            int value = 1;
            string matrixName = "";
            dim = inputToInt();
            dimValues = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                dimValues[i] = inputToInt();
                if (dimValues[i] == 0)
                {
                    dimValues[i] = 1;
                }
            }
            value = inputToInt();
            matrixName = inputToString();

            CSparseMatrix matrix = new CSparseMatrix(dim, dimValues, value, matrixName,new List<CSparseCell>(0));
            bool isFind = false;
            foreach (var item in MatrixDictionary)
            {
                if (item.Key == matrix.name)
                {
                    isFind = true;
                    break;
                }
            }
            if (isFind)
            {
                MatrixDictionary.Remove(matrix.name);
            }
            MatrixDictionary.Add(matrix.name, matrix);
            consoleOut.Text = matrix.name + " succesfuly added";
        }

        void MatrixList()
        {
            string consoleText = "";
            consoleText += "Number of Matrixes : " + MatrixDictionary.Count + "\n";
            foreach (var item in MatrixDictionary)
            {
                consoleText += item.Key + ", size: ";
                foreach (var i in item.Value.dimValues)
                {
                    consoleText += i + " ";
                }
                consoleText += "\n";
            }
            consoleOut.Text = consoleText;
        }
        void Del()
        {
            string matrixName;
            matrixName = inputToString();
            if (MatrixDictionary.Remove(matrixName))
            {
                consoleOut.Text = matrixName + " Deleted";
            }
            else
            {
                consoleOut.Text = matrixName + " is not exist";
            }
        }
        void Def()
        {
            string matrixName;
            bool isFind = false;
            matrixName = inputToString();
            foreach (var item in MatrixDictionary)
            {
                if (item.Key == matrixName)
                {
                    isFind = true;
                    int[] dimValues = new int[item.Value.dim];
                    int value;
                    for (int i = 0; i < dimValues.Length; i++)
                    {
                        dimValues[i] = inputToInt();
                    }
                    value = inputToInt();
                    for (int i = 0; i < dimValues.Length; i++)
                    {
                        if (dimValues[i] >= item.Value.dimValues[i] && dimValues[i] >= 0)
                        {
                            consoleOut.Text = "Out of range";
                            return;
                        }
                    }
                    foreach (var i in item.Value.data)
                    {
                        int counter = 0;
                        for (int j = 0; j < dimValues.Length; j++)
                        {
                            if (dimValues[j] == i.dimValues[j])
                            {
                                counter++;
                            }
                        }
                        if (counter == dimValues.Length)
                        {
                            consoleOut.Text = "Value already exist";
                            return;
                        }
                    }//Перевірка чи такий запис вже існує
                    item.Value.data.Add(new CSparseCell(dimValues, value));
                    consoleOut.Text = "Value succesfuly added";
                    break;
                }
            }
            if (!isFind)
            {
                consoleOut.Text = matrixName + " is not exist";
            }
        }

        void Print()
        {
            string matrixName;
            bool isFind = false;
            matrixName = inputToString();
            consoleOut.Text = "";
            foreach (var item in MatrixDictionary)
            {
                if (item.Key == matrixName)
                {
                    isFind = true;
                    consoleOut.Text += "Name: " + matrixName + " Size: [";
                    foreach (var i in item.Value.dimValues)
                    {
                        consoleOut.Text += i + " ";
                    }
                    consoleOut.Text += "] Value: " + item.Value.value + "\nValues: ";
                    foreach (var i in item.Value.data)
                    {
                        consoleOut.Text += "[";
                        foreach (var j in i.dimValues)
                        {
                            consoleOut.Text += j + " ";
                        }
                        consoleOut.Text += "] : " + i.value + " ;";
                    }
                }
            }
            if (!isFind)
            {
                consoleOut.Text = matrixName + " is not exist";
            }
        }
        void Clone()
        {
            string matrixName;
            bool isFind = false;
            matrixName = inputToString();
            foreach (var item in MatrixDictionary)
            {
                if (item.Key == matrixName)
                {
                    isFind = true;
                    matrixName = item.Value.name + "Clone";
                    CSparseMatrix temp = new CSparseMatrix(item.Value.dim, item.Value.dimValues, item.Value.value, matrixName, item.Value.data);
                    MatrixDictionary.Add(temp.name, temp);
                    consoleOut.Text = matrixName + " Clone succesfuly created";
                    break;
                }
            }
            if (!isFind)
            {
                consoleOut.Text = matrixName + " is not exist";
            }
        }
        void Rename()
        {
            string matrixName1, matrixName2;
            bool isFind = false;
            matrixName1 = inputToString();
            matrixName2 = inputToString();
            foreach (var item in MatrixDictionary)
            {
                if (item.Key == matrixName1)
                {
                    isFind = true;
                    foreach (var i in MatrixDictionary)
                    {
                        if (i.Key == matrixName2)
                        {
                            consoleOut.Text = "Name " + matrixName2 + " is taken";
                            return;
                        }
                    }
                    CSparseMatrix temp = MatrixDictionary[matrixName1];
                    MatrixDictionary[matrixName1].name = matrixName2;
                    MatrixDictionary.Remove(matrixName1);
                    MatrixDictionary.Add(matrixName2, temp);
                    consoleOut.Text = matrixName1 + " renamed to " + matrixName2;
                    break;
                }
            }
            if (!isFind)
            {
                consoleOut.Text = matrixName1 + " is not exist";
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            input = textBoxToString(consoleIN);
            string command = inputToString();
            command = command.ToLower();
            if (command == "addmat")
            {
                Addmat();
            }
            else if (command == "list")
            {
                MatrixList();
            }
            else if (command == "del")
            {
                Del();
            }
            else if (command == "def")
            {
                Def();
            }
            else if (command == "print")
            {
                Print();
            }
            else if (command == "clone")
            {
                Clone();
            }
            else if (command == "rename")
            {
                Rename();
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
        }
    }
}
