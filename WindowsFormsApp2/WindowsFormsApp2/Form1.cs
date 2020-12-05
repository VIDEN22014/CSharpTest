using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        string textBoxToString(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return textBox.Text;
            }
            return "";
        }
        void format(ref string str)
        {
            bool isFind = true;
            str = str.ToLower();
            while (isFind)
            {
                isFind = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {

                    }
                    else if (str[i] >= 97 && str[i] <= 122)
                    {

                    }
                    else if (str[i] >= 48 && str[i] <= 57)
                    {

                    }
                    else
                    {
                        str = str.Remove(i, 1);
                        isFind = true;
                        break;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            int x = 1;
            s = textBoxToString(textBox1);
            format(ref s);
            string pattern = @"([0-2]\d)|(3[0-1])|(\d)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(s);
            if (match.Success)
            {
                x = Convert.ToInt32(match.Value);
            }
            else
            {
                label1.Text = "regex is failed";
            }
            label1.Text = Convert.ToString(x);



        }
    }
}
