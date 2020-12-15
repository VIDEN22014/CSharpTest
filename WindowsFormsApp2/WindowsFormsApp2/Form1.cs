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
            monthName.Add("jan", "January");
            monthName.Add("feb", "February");
            monthName.Add("mar", "March");
            monthName.Add("apr", "April");
            monthName.Add("may", "May");
            monthName.Add("jun", "June");
            monthName.Add("jul", "July");
            monthName.Add("aug", "August");
            monthName.Add("sep", "September");
            monthName.Add("oct", "October");
            monthName.Add("nov", "November");
            monthName.Add("dec", "December");
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
            while (isFind)
            {
                isFind = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 97 && str[i] <= 122)
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
            int day = 0;
            string month = "";
            input = textBoxToString(consoleIN);
            format(ref input);
            string numPattern = @"([1-2]\d)|(3[0-1])|([1-9])";
            Regex numRegex = new Regex(numPattern);
            Match numMatch = numRegex.Match(input);
            if (numMatch.Success)
            {
                day = Convert.ToInt32(numMatch.Value);
            }
            else
            {
                MessageBox.Show("Days is not found", "Error");
            }
            //Зчитує число
            deleteNumbers(ref input);
            string monthPattern = @"(jan)|(jun)|(jul)|(feb)|(mar)|(may)|(apr)|(aug)|(sep)|(oct)|(nov)|(dec)";
            Regex monthRegex = new Regex(monthPattern);
            Match monthMatch = monthRegex.Match(input);
            if (monthMatch.Success)
            {
                month = monthMatch.Value;
            }//Зчитує назву місяця
            else
            {
                switch (true)
                {
                    case bool _ when Regex.IsMatch(input, @"(f\wb|\web|fe\w)|(\w\wbr|\we\wr|f\w\wr|fe\w\w)|(f?e?bru|fe?b?ru|f?eb?ru|f?ebr?u|f?ebru?|fe?br?u|fe?bru?)"):
                        month = "February";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(\wun)|(\w?\w?ne|\w?un\w?|j\w?\w?e)"):
                        month = "June";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(\wul|j\wl)|(\w?\w?ly|\w?u\w?y|\w?ul\w?|j\w?\w?y|j\w?l\w?)"):
                        month = "July";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(\wan|ja\w)|(\w?\w?nu|\w?a\w?u|\w?an\w?|j\w?\w?u|ja\w?\w?)"):
                        month = "January";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(s\wp|\wep|se\w)|(\w\wpt|\we\wt|s\w\wt|se\w\w)|(s?e?pte|se?p?te|s?ep?te|s?ept?e|s?epte?|se?pt?e|se?pte?)"):
                        month = "September";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(o\wt|\wct|oc\w)|(\w\wto|\wc\wo|o\w\wo|oc\w\w)|(o?c?tob|oc?t?ob|o?ct?ob|o?cto?b|o?ctob?|oc?to?b|oc?tob?)"):
                        month = "October";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(n\wv|\wov|no\w)|(\w\wve|\wo\we|n\w\we)|(n?o?vem|no?v?em|n?ov?em|n?ove?m|n?ovem?|no?ve?m|no?vem?)"):
                        month = "November";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(d\wc|\wec|de\w)|(\w\wce|\we\we|d\w\we)|(d?e?cem|de?c?em|d?ec?em|d?ece?m|d?ecem?|de?ce?m|de?cem?)"):
                        month = "December";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(a\wr|\wpr|ap\w)|(\w\wri|\wp\wi|a\w\wi)|(a?p?ril|ap?r?il|a?pr?il|a?pri?l|a?pril?|ap?ri?l|ap?ril?)"):
                        month = "April";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(a\wg|\wug|au\w)|(\w\wgu|\wu\wu|a\w\wu)|(a?u?gus|au?g?us|a?ug?us|a?ugu?s|a?ugus?|au?gu?s|au?gus?)"):
                        month = "August";
                        break;
                    case bool _ when Regex.IsMatch(input, @"(m\wr|\war)|(\w\wrc|\wa\wc|m\w\wc|ma\w\w)|(m?a?rch|ma?r?ch|m?ar?ch|m?arc?h|m?arch?|ma?rc?h|ma?rch?)"):
                        month = "March";
                        break;
                    case bool _ when Regex.IsMatch(input, @"m\wy|\way|ma\w|m\w\w"):
                        month = "May";
                        break;
                    default:
                        MessageBox.Show("Month name is not found", "Error");
                        break;
                }
            }
            Repare(ref month);
            dayInMonthCheck(ref month, ref day);
            consoleOUT.Text = Convert.ToString(day) + " " + month;
        }
    }
}
