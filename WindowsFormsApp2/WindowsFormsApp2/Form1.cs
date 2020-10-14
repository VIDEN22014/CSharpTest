using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
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
            SortByType.Add("name", SortByName);
            SortByType.Add("age", SortByAge);
            SortByType.Add("mass", SortByMass);
            SortByType.Add("mark", SortByMark);
        }
        delegate void SortDel(StudentsGroup a);
        delegate bool IsHigher(int x);
        static Dictionary<string, SortDel> SortByType = new Dictionary<string, SortDel>();
        StudentsGroup group21 = new StudentsGroup("CS-21");
        class Student
        {
            public string name { get; }
            public int age { get; }
            public double mass { get; }
            public int markFromCsharp { get; }
            public Student()
            {
                name = "";
                age = 0;
                mass = 0;
                markFromCsharp = 0;
            }
            public Student(string name, int age, double mass, int markFromCsharp)
            {
                this.name = name;
                this.age = age;
                this.mass = mass;
                this.markFromCsharp = markFromCsharp;
            }
            public string Display(IsHigher func)
            {
                if (func(markFromCsharp))
                {
                    return "Name: " + name + '\t' + " Age: " + age + '\t' + " Mass: " + mass + '\t' + " Mark: " + markFromCsharp + "\n";
                }
                return "";
            }
        }

        class StudentsGroup
        {
            string nameOfGroup { get; set; }
            public Student[] group;
            public StudentsGroup()
            {
                group = new Student[0];
            }
            public StudentsGroup(string nameOfGroup)
            {
                group = new Student[0];
                this.nameOfGroup = nameOfGroup;
            }
            public static StudentsGroup operator +(StudentsGroup c1, Student c2)
            {
                Array.Resize(ref c1.group, c1.group.Length + 1);
                c1.group[c1.group.Length - 1] = c2;
                return c1;
            }
            public static StudentsGroup operator -(StudentsGroup gr, Student student)
            {
                bool isFind = false;
                for (int i = 0; i < gr.group.Length; i++)
                {
                    if (isFind)
                    {
                        Student temp = gr.group[i];
                        gr.group[i] = gr.group[i - 1];
                        gr.group[i - 1] = temp;
                    }
                    if (gr.group[i] == student)
                    {
                        isFind = true;
                    }
                }
                if (isFind)
                {
                    Array.Resize(ref gr.group, gr.group.Length - 1);
                }
                return gr;
            }
            public void Sort(string sortType)
            {
                foreach (var i in SortByType)
                {
                    if (i.Key == sortType.ToLower())
                    {
                        i.Value.Invoke(this);
                        return;
                    }
                }
            }

            public void Display(Label label)
            {
                string s = "";
                foreach (Student i in group)
                {
                    s += i.Display(x => x > -1);
                }
                label.Text = s;
            }
            public void Display(int mark, Label label)
            {
                string s = "";
                foreach (Student i in group)
                {
                    s += i.Display(x => x > mark);
                }
                label.Text = s;
            }
        }
        void SortByName(StudentsGroup gr)
        {
            Array.Sort(gr.group, delegate (Student a, Student b)
            {
                return String.Compare(a.name, b.name);
            });
        }
        void SortByAge(StudentsGroup gr)
        {
            Array.Sort(gr.group, delegate (Student a, Student b)
            {
                if (a.age < b.age) { return 1; }
                else if (a.age > b.age) { return -1; }
                return 0;
            });
        }
        void SortByMass(StudentsGroup gr)
        {
            Array.Sort(gr.group, delegate (Student a, Student b)
            {
                if (a.mass < b.mass) { return 1; }
                else if (a.mass > b.mass) { return -1; }
                return 0;
            });
        }
        void SortByMark(StudentsGroup gr)
        {
            Array.Sort(gr.group, delegate (Student a, Student b)
            {
                if (a.markFromCsharp < b.markFromCsharp) { return 1; }
                else if (a.markFromCsharp > b.markFromCsharp) { return -1; }
                return 0;
            });
        }

        int TextBoxToInt(TextBox textBox) {
            if (textBox.Text != "") {
                return Convert.ToInt32(textBox.Text);
            }
            return 0;
        }
        double TextBoxToDouble(TextBox textBox) {
            if (textBox.Text != "")
            {
                return Convert.ToDouble(textBox.Text);
            }
            return 0;
        }
        string TextBoxToString(TextBox textBox) {
            if (textBox.Text != "")
            {
                return Convert.ToString(textBox.Text);
            }
            return "";
        }

        private void addButton(object sender, EventArgs e)
        {
            string studentName = "";
            int studentAge = 0, studentMark = 0;
            double studentMass = 0;
            studentName = TextBoxToString(studentNameIN);
            studentAge = TextBoxToInt(studentAgeIN);
            studentMass = TextBoxToDouble(studentMassIN);
            studentMark = TextBoxToInt(studentMarkIN);
            Student student = new Student(studentName, studentAge, studentMass, studentMark);
            group21 += student;
            group21.Display(groupOutput);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void removeButton(object sender, EventArgs e)
        {
            if (group21.group.Length == 0) { return; }
            group21 -= group21.group[group21.group.Length - 1];
            group21.Display(groupOutput);
        }

        private void sortButton(object sender, EventArgs e)
        {
            group21.Sort(TextBoxToString(sortTypeIN));
            group21.Display(groupOutput);
        }

        private void filterButton(object sender, EventArgs e)
        {
            group21.Display(TextBoxToInt(filterTypeIN), groupOutput);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
