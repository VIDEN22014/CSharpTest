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
            monthNameInitialize();
            dayInMonthInitialize();
        }
        static Dictionary<string, string> monthName = new Dictionary<string, string>();
        static Dictionary<string, int> dayInMonth = new Dictionary<string, int>();

        string textBoxToString(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return textBox.Text;
            }
            return "";
        }
        void monthNameInitialize()
        {
            monthName.Add("ja", "January");
            monthName.Add("fe", "February");
            monthName.Add("mar", "March");
            monthName.Add("ap", "April");
            monthName.Add("may", "May");
            monthName.Add("jun", "June");
            monthName.Add("jul", "July");
            monthName.Add("au", "August");
            monthName.Add("se", "September");
            monthName.Add("oc", "October");
            monthName.Add("no", "November");
            monthName.Add("de", "December");
        }

        void dayInMonthInitialize()
        {
            dayInMonth.Add("January", 31);
            dayInMonth.Add("February", 28);
            dayInMonth.Add("March", 31);
            dayInMonth.Add("April", 30);
            dayInMonth.Add("May", 31);
            dayInMonth.Add("June", 30);
            dayInMonth.Add("July", 31);
            dayInMonth.Add("August", 31);
            dayInMonth.Add("September", 30);
            dayInMonth.Add("October", 31);
            dayInMonth.Add("November", 30);
            dayInMonth.Add("December", 31);
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
        void deleteNumbers(ref string str)
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
                    else
                    {
                        str = str.Remove(i, 1);
                        isFind = true;
                        break;
                    }
                }
            }
        }
        void Repare(ref string str)
        {
            foreach (var item in monthName)
            {
                if (item.Key == str)
                {
                    str = item.Value;
                    break;
                }
            }
        }
        void dayInMonthCheck(ref string str, ref int day)
        {
            foreach (var item in dayInMonth)
            {
                if (item.Key == str)
                {
                    if (day >= item.Value)
                    {
                        day = item.Value;
                        MessageBox.Show("Too much days", "Error");
                    }
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            int day = 1;
            string month = "January";
            input = textBoxToString(consoleIN);
            format(ref input);
            string numPattern = @"([1-2]\d)|(3[0-1])|([1-9])";
            Regex numRegex = new Regex(numPattern);
            Match numMatch = numRegex.Match(input);
            if (numMatch.Success)
            {
                day = Convert.ToInt32(numMatch.Value);
            }
            //Зчитує число
            deleteNumbers(ref input);
            string monthPattern = @"(ja)|(jun)|(jul)|(fe)|(mar)|(may)|(ap)|(au)|(se)|(oc)|(no)|(de)";
            Regex monthRegex = new Regex(monthPattern);
            Match monthMatch = monthRegex.Match(input);
            if (monthMatch.Success)
            {
                month = monthMatch.Value;
            }
            Repare(ref month);
            dayInMonthCheck(ref month, ref day);
            //Зчитує назву місяця
            consoleOUT.Text = Convert.ToString(day) + " " + month;
        }
    }
}
