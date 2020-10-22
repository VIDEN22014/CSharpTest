using System;
using System.Collections.Generic;
using System.Drawing;
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
            academicFailure += SendWarningMail;
            studentsDataGrid = dataGridView1;
        }
        static DeanOfficeEmployee employee1 = new DeanOfficeEmployee("Пилипів Володимир Михайлович", "pylypiv.v@gmail.com");
        static DeanOfficeEmployee employee2 = new DeanOfficeEmployee("Соломко Андрій Васильович", "solomko.a@pnu.edu.ua");
        static DeanOfficeEmployee employee3 = new DeanOfficeEmployee("Бондаренко Ірина Ігорівна", "bondarenko.i@pnu.edu.ua");
        DeanOfficeEmployee[] deansOffice = new DeanOfficeEmployee[3] { employee1, employee2, employee3 };
        StudentsGroup group21 = new StudentsGroup("CS-21");
        static DataGridView studentsDataGrid = new DataGridView();

        delegate void SendMessageDel(string groupName, string studentName);
        event SendMessageDel academicFailure;
        delegate void SortDel(StudentsGroup a);
        delegate bool IsHigher(int x);

        static Dictionary<string, SortDel> SortByType = new Dictionary<string, SortDel>();

        void SendWarningMail(string groupName, string studentName)
        {
            emailImitationOUT.Text = "Імітація Розсилки:\n";
            foreach (DeanOfficeEmployee i in deansOffice)
            {
                emailImitationOUT.Text += "To: " + i.emailAddress + "\nText: Шановний " + i.name + ", Судент Групи: " + groupName;
                emailImitationOUT.Text += " " + studentName + " отримав незадовільну оцінку з предмету С#, прошу прийняти міри\n\n";
            }
        }

        class DeanOfficeEmployee
        {
            public string name { get; }
            public string emailAddress { get; }
            public DeanOfficeEmployee(string name, string emailAddress)
            {
                this.name = name;
                this.emailAddress = emailAddress;
            }
        }
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
            public void Display(IsHigher func)
            {
                if (func(markFromCsharp))
                {
                    studentsDataGrid.Rows.Add(name, age, mass, markFromCsharp);
                }
            }
        }
        class StudentsGroup
        {
            public string nameOfGroup { get; }
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
            public static StudentsGroup operator +(StudentsGroup gr, Student student)
            {
                Array.Resize(ref gr.group, gr.group.Length + 1);
                gr.group[gr.group.Length - 1] = student;
                return gr;
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
            public void Display(int mark, Label label)
            {
                studentsDataGrid.Rows.Clear();
                foreach (Student i in group)
                {
                    i.Display(x => x > mark);
                }
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
        int TextBoxToInt(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return Convert.ToInt32(textBox.Text);
            }
            return 0;
        }
        double TextBoxToDouble(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return Convert.ToDouble(textBox.Text);
            }
            return 0;
        }
        string TextBoxToString(TextBox textBox)
        {
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
            if (student.markFromCsharp < 3 && academicFailure != null) academicFailure(group21.nameOfGroup, student.name);
            group21.Display(0, groupOutput);
        }
        private void removeButton(object sender, EventArgs e)
        {
            if (group21.group.Length == 0) { return; }
            group21 -= group21.group[group21.group.Length - 1];
            group21.Display(0, groupOutput);
        }
        private void sortButton(object sender, EventArgs e)
        {
            group21.Sort(TextBoxToString(sortTypeIN));
            group21.Display(0, groupOutput);
        }
        private void filterButton(object sender, EventArgs e)
        {
            group21.Display(TextBoxToInt(filterTypeIN), groupOutput);
        }
    }
}
