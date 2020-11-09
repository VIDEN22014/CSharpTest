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
        static Dictionary<char, Symbols> symbolByChar = new Dictionary<char, Symbols>(100);
        static SymbolsGroup screen = new SymbolsGroup();
        static CheckedListBox[] symbolsRedactor = new CheckedListBox[8];

        public Form1()
        {
            InitializeComponent();
            mainPictureBox = pictureBox;
            symbolsRedactor[0] = symbolsReactorColumn0;
            symbolsRedactor[1] = symbolsReactorColumn1;
            symbolsRedactor[2] = symbolsReactorColumn2;
            symbolsRedactor[3] = symbolsReactorColumn3;
            symbolsRedactor[4] = symbolsReactorColumn4;
            symbolsRedactor[5] = symbolsReactorColumn5;
            symbolsRedactor[6] = symbolsReactorColumn6;
            symbolsRedactor[7] = symbolsReactorColumn7;
            InitializeSymbolsDictionary();
        }
        class Symbols
        {
            public byte[] screenRows = new byte[8];
            public Symbols()
            {
                for (int i = 0; i < 8; i++)
                {
                    screenRows[i] = 0;
                }
            }
            public Symbols(int[] massive)
            {
                for (int i = 0; i < 8; i++)
                {
                    screenRows[i] = (byte)massive[i];
                }
            }
            public Symbols(char index)
            {
                foreach (var item in symbolByChar)
                {
                    if (index == item.Key)
                    {
                        Copy(item.Value);
                        return;
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    screenRows[i] = 0;
                }
            }
            public void Copy(Symbols temp)
            {
                for (int i = 0; i < 8; i++)
                {
                    screenRows[i] = temp.screenRows[i];
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
            public void Shift()
            {
                byte temp = group[0].screenRows[0];
                for (int i = 0; i < group.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j == 7)
                        {
                            if (i != group.Length - 1)
                            {
                                group[i].screenRows[j] = group[i + 1].screenRows[0];
                            }
                        }
                        else
                        {
                            group[i].screenRows[j] = group[i].screenRows[j + 1];
                        }
                    }
                }
                group[group.Length - 1].screenRows[7] = temp;
            }
            public void Draw()
            {
                int size = 15;
                int startx = 15;
                int starty = 15 * 10;
                int numOfScreens = 8;
                graph.Clear(Color.Transparent);
                while (screen.group.Length < numOfScreens)
                {
                    Symbols temp = new Symbols(' ');
                    screen += temp;
                }//Дозаповення масиву символів пробілами
                for (int screenIndex = 0; screenIndex < numOfScreens; screenIndex++)
                {
                    for (int screenWidth = 0; screenWidth < 8; screenWidth++)
                    {
                        for (int screenHeight = 0; screenHeight < 8; screenHeight++)
                        {
                            Rectangle rect = new Rectangle(startx + screenWidth * size + screenIndex * 8 * size, starty - screenHeight * size, size, size);
                            graph.DrawRectangle(pen, rect);
                            byte mask = (byte)(group[screenIndex].screenRows[screenWidth] & (byte)Math.Pow(2, screenHeight));
                            if (!mask.Equals((byte)0))
                            {
                                graph.FillRectangle(Brushes.Black, rect);
                            }
                        }
                        Rectangle rectUp = new Rectangle(startx + screenWidth * size + screenIndex * 8 * size, starty + size, size, size);
                        Rectangle rectDown = new Rectangle(startx + screenWidth * size + screenIndex * 8 * size, starty - 8 * size, size, size);
                        graph.DrawRectangle(pen, rectUp);
                        graph.DrawRectangle(pen, startx + screenWidth * size + screenIndex * 8 * size, starty + size, size, size);
                        graph.DrawRectangle(pen, rectDown);
                        graph.DrawRectangle(pen, startx + screenWidth * size + screenIndex * 8 * size, starty - 8 * size, size, size);
                    }
                }
                mainPictureBox.Image = bmp;
            }
        }
        string textBoxToString(TextBox textBox) {
            return Convert.ToString(textBox.Text);
        }
        int setTimerInterval(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > 0)
                {
                    return Convert.ToInt32(textBox.Text);
                }
            }
            return 1000;
        }
        char getNewSymbolKey(TextBox textBox)
        {
            if (textBox.Text == "") { return '0'; }
            return Convert.ToChar(textBox.Text);
        }
        void InitializeSymbolsDictionary()
        {
            int[] symbolEncoding = new int[8];
            PutEncoding(symbolEncoding, 0, 127, 144, 144, 144, 144, 144, 255);
            symbolByChar.Add('a', new Symbols(symbolEncoding));
            PutEncoding(symbolEncoding, 0, 7, 28, 40, 200, 200, 60, 7);
            symbolByChar.Add('A', new Symbols(symbolEncoding));
            PutEncoding(symbolEncoding, 0, 255, 145, 145, 145, 145, 145, 110);
            symbolByChar.Add('B', new Symbols(symbolEncoding));
            PutEncoding(symbolEncoding, 0, 126, 129, 129, 129, 129, 129, 102);
            symbolByChar.Add('C', new Symbols(symbolEncoding));
            PutEncoding(symbolEncoding, 0, 255, 129, 129, 129, 129, 129, 126);
            symbolByChar.Add('D', new Symbols(symbolEncoding));
            PutEncoding(symbolEncoding, 0, 255, 145, 145, 145, 145, 145, 129);
            symbolByChar.Add('E', new Symbols(symbolEncoding));
        }
        void PutEncoding(int[] item, int s0, int s1, int s2, int s3, int s4, int s5, int s6, int s7)
        {
            item[0] = s0;
            item[1] = s1;
            item[2] = s2;
            item[3] = s3;
            item[4] = s4;
            item[5] = s5;
            item[6] = s6;
            item[7] = s7;
        }

        private void timerEventButton(object sender, EventArgs e)
        {
            screen.Draw();
            screen.Shift();
        }
        private void timerStartButton(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timerStopButton(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void intervalIN_textChanged(object sender, EventArgs e)
        {
            timer1.Interval = setTimerInterval(intervalIN);
        }
        private void AddToDictionaryButton(object sender, EventArgs e)
        {
            int[] mass= {0,0,0,0,0,0,0,0};
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (string item in symbolsRedactor[i].CheckedItems)
                    {
                        if (item==Convert.ToString(j)) { mass[i] += (int)Math.Pow(2, j); }
                    }
                }
            }
            Symbols temp = new Symbols(mass);
            symbolByChar.Remove(getNewSymbolKey(newSymbolKeyIN));
            symbolByChar.Add(getNewSymbolKey(newSymbolKeyIN),temp);
        }

        private void screenSymbolsIN_TextChanged(object sender, EventArgs e)
        {
            int lenght = screen.group.Length;
            for (int i = 0; i < lenght; i++)
            {
                screen -= screen.group[0];
            }
            foreach (char item in textBoxToString(screenSymbolsIN))
            {
                Symbols temp = new Symbols(item);
                screen += temp;
            }
        }
    }
}
