using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static PictureBox mainPictureBox = new PictureBox();
        static Bitmap bmp = new Bitmap(10000, 10000);
        static Graphics graph = Graphics.FromImage(bmp);
        static Pen pen = new Pen(Color.Black);
        static TextBox mainTextBox = new TextBox();
        static Dictionary<char, Symbols> symbolByChar=new Dictionary<char, Symbols>(100);
        static SymbolsGroup screen = new SymbolsGroup();

        public Form1()
        {
            InitializeComponent();
            mainPictureBox = pictureBox;
            int[] b = { 0, 127, 144, 144, 144, 144, 144, 255 };
            Symbols a = new Symbols(b);
            symbolByChar.Add('a',a);
            Symbols c = new Symbols('a');
            Symbols d = new Symbols('a');
            Symbols e = new Symbols('a');
            Symbols f = new Symbols('a');
            Symbols g = new Symbols('a');
            Symbols h = new Symbols('a');
            Symbols i = new Symbols('a');
            Symbols j = new Symbols('a');
            screen += c;
            screen += d;
            screen += e;
            screen += f;
            screen += g;
            screen += h;
            screen += i;
            screen += j;
        }
        class Symbols
        {
            public byte[] cell = new byte[8];
            public Symbols()
            {
                for (int i = 0; i < 8; i++)
                {
                    cell[i] = 0;
                }
            }
            public Symbols(int[] massive)
            {
                for (int i = 0; i < 8; i++)
                {
                    cell[i] = (byte)massive[i];
                }
            }
            public Symbols(char index)
            {

                foreach (var item in symbolByChar)
                {
                    if (index==item.Key)
                    {
                        Copy(item.Value);
                        return;
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    cell[i] = 0;
                }
            }
            public void Copy(Symbols temp) {
                for (int i = 0; i < 8; i++)
                {
                    cell[i] = temp.cell[i];
                }
            }
        }
        class SymbolsGroup
        {
            public Symbols[] group;
            public SymbolsGroup()
            {
                group = new Symbols[0];
            }
            public static SymbolsGroup operator +(SymbolsGroup gr, Symbols symbols)
            {
                Array.Resize(ref gr.group, gr.group.Length + 1);
                gr.group[gr.group.Length - 1] = symbols;
                return gr;
            }
            public static SymbolsGroup operator -(SymbolsGroup gr, Symbols symbols)
            {
                bool isFind = false;
                for (int i = 0; i < gr.group.Length; i++)
                {
                    if (isFind)
                    {
                        Symbols temp = gr.group[i];
                        gr.group[i] = gr.group[i - 1];
                        gr.group[i - 1] = temp;
                    }
                    if (gr.group[i] == symbols)
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
            public void Zsuv() {
                byte temp = group[0].cell[0];
                for (int i = 0; i < group.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j==7)
                        {
                            if (i != group.Length - 1)
                            {
                                group[i].cell[j] = group[i + 1].cell[0];
                            }
                        }
                        else
                        {
                            group[i].cell[j] = group[i].cell[j + 1];
                        }
                    }
                }
                group[group.Length - 1].cell[7] = temp;

            }
            public void Draw() {
                int size = 15;
                int startx = 15;
                int starty = 15*10;
                graph.Clear(Color.Transparent);
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            Rectangle rect = new Rectangle(startx + j * size + i * 8 * size, starty - k * size, size, size);
                            graph.DrawRectangle(pen, rect);
                            byte v = (byte)(group[i].cell[j] & (byte)Math.Pow(2,k));
                            byte zero = 0;
                            if (!v.Equals (zero)) 
                            {
                                graph.FillRectangle(Brushes.Black, rect);
                            }
                        }
                        Rectangle rectUp = new Rectangle(startx + j * size + i * 8 * size, starty + size, size, size);
                        Rectangle rectDown = new Rectangle(startx + j * size + i * 8 * size, starty - 8 * size, size, size);
                        graph.DrawRectangle(pen, rectUp);
                        graph.DrawRectangle(pen, startx + j * size + i * 8 * size, starty + size, size, size);
                        graph.DrawRectangle(pen, rectDown);
                        graph.DrawRectangle(pen, startx + j * size + i * 8 * size, starty - 8 * size, size, size);
                    }
                }
                mainPictureBox.Image = bmp;
            }
        }
        int textBoxToInt(TextBox textBox) {
            if (textBox.Text != "") {
                if (Convert.ToInt32(textBox.Text) > 0)
                {
                    return Convert.ToInt32(textBox.Text);
                }
            }
            return 1000;
        }

        private void moveButton(object sender, EventArgs e)
        {
            screen.Zsuv();
            screen.Draw();
        }

        private void timerStartButton(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timerStopButton(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = textBoxToInt(textBox1);
            checkedListBox1.Items[0].ToString();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
