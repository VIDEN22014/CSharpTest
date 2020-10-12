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
        }
        class Student
        {
            string name { get; set; }
            int age { get; set; }
            double mass { get; set; }
            int markFromCsharp { get; set; }
            public Student()
            {
                name = "";
                age = 0;
                mass = 0;
                markFromCsharp = 0;
            }
            public Student(string name,int age,double mass,int markFromCsharp) {
                this.name = name;
                this.age = age;
                this.mass = mass;
                this.markFromCsharp = markFromCsharp;
            }
            public void Display()
            {

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
                Array.Resize(ref c1.group, c1.group.Length+1);
                c1.group[c1.group.Length-1] = c2;
                return c1;
            }
            public static StudentsGroup operator -(StudentsGroup c1, Student c2)
            {
                Array.Resize(ref c1.group, c1.group.Length - 1);
                c1.group[c1.group.Length - 1] = c2;
                return c1;
            }
            public void Display()
            {
                foreach (Student i in group)
                {
                    i.Display();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsGroup group21=new StudentsGroup("CS-21");
            Student student1=new Student("Petro",28,56,3);
            Student student2=new Student("Ivan",18,57,4);
            group21+= student1;
            group21+= student2;
        }
    }
}
