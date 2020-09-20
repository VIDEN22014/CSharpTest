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
        bool isPlayerTurn = true;
        int[,] field = new int[3, 3];
        int difficulty = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Ваш Хід";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = 0;
                }
            }

        }
        int isGameOver()
        {
            int sumHorizontal = 0, sumVertical = 0, sumDiagonal1 = 0, sumDiagonal2 = 0, sumTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                sumHorizontal = 0;
                sumVertical = 0;
                sumDiagonal1 += field[i, i];
                sumDiagonal2 += field[2 - i, i];
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] != 0)
                    {
                        sumTotal++;
                    }
                    sumHorizontal += field[i, j];
                    sumVertical += field[j, i];
                }
                if (sumHorizontal == 3 || sumVertical == 3 || sumDiagonal1 == 3 || sumDiagonal2 == 3) { return 1; }
                else if (sumHorizontal == 30 || sumVertical == 30 || sumDiagonal1 == 30 || sumDiagonal2 == 30) { return 2; }
                else if (sumTotal == 9) { return 3; }
            }
            return 0;
        }
        bool isEmpty(int buttonIndex)
        {
            if (field[Convert.ToInt32(Math.Floor(buttonIndex / 3.0)), buttonIndex % 3] == 0)
            {
                return true;
            }
            else { return false; }
        }
        int level1Turn()
        {
            int sumHorizontal, sumVertical, sumDiagonal1 = 0, sumDiagonal2 = 0;
            for (int i = 0; i < 3; i++)
            {
                sumVertical = 0;
                sumHorizontal = 0;
                sumDiagonal1 += field[i, i];
                sumDiagonal2 += field[2 - i, i];
                sumHorizontal += field[i, 0] + field[i, 1] + field[i, 2];
                sumVertical += field[0, i] + field[1, i] + field[2, i];
                if (sumDiagonal1 == 20)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(j * 4)) { return j * 4; }
                    }
                }
                if (sumDiagonal2 == 20)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        if (isEmpty(j * 2)) { return j * 2; }
                    }
                }
                if (sumHorizontal == 20)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(3 * i + j)) { return 3 * i + j; }
                    }
                }
                if (sumVertical == 20)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(3 * j + i)) { return 3 * j + i; }
                    }
                }
                if (sumDiagonal1 == 2)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(j * 4)) { return j * 4; }
                    }
                }
                if (sumDiagonal2 == 2)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        if (isEmpty(j * 2)) { return j * 2; }
                    }
                }
                if (sumHorizontal == 2)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(3 * i + j)) { return 3 * i + j; }
                    }
                }
                if (sumVertical == 2)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (isEmpty(3 * j + i)) { return 3 * j + i; }
                    }
                }
            }
            return -1;
        }
        int RandomTurn()
        {
            int buttonIndex = 0;
            Random rnd = new Random();
            do
            {
                buttonIndex = rnd.Next(0, 9);
            } while (!isEmpty(buttonIndex));
            return buttonIndex;
        }
        async Task BotTurn()
        {
            int buttonIndex = 0;
            if (difficulty == 0)
            {
                buttonIndex = RandomTurn();
            }

            if (difficulty == 1)
            {
                buttonIndex = level1Turn();
                if (buttonIndex == -1) { buttonIndex = RandomTurn(); }
            }

            if (difficulty == 2)
            {
                buttonIndex = level1Turn();
                if (buttonIndex == -1)
                {
                    if (isEmpty(4)) { buttonIndex = 4; }
                    else
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (i != 4 && i % 2 == 0)
                            {
                                if (isEmpty(i))
                                {
                                    buttonIndex = i;
                                    break;
                                }
                            }
                            buttonIndex = RandomTurn();
                        }
                    }
                }
            }
            //
            await Task.Delay(1000);
            GetButton(buttonIndex).Text = "O";
            field[Convert.ToInt32(Math.Floor(buttonIndex / 3.0)), buttonIndex % 3] = 10;
            //
            if (isGameOver() == 2) { label2.Text = "Ви Програли!!!"; }
            else if (isGameOver() == 3) { label2.Text = "Нічия"; }
            else
            {
                isPlayerTurn = true;
                label2.Text = "Ваш Хід";
            }
        }
        void Turn(int buttonIndex)
        {
            if (isGameOver() == 0 && isPlayerTurn && isEmpty(buttonIndex))
            {
                GetButton(buttonIndex).Text = "X";
                field[Convert.ToInt32(Math.Floor(buttonIndex / 3.0)), buttonIndex % 3] = 1;
                //
                if (isGameOver() == 1) { label2.Text = "Ви Виграли!!!"; }
                else if (isGameOver() == 3) { label2.Text = "Нічия"; }
                else
                {
                    isPlayerTurn = false;
                    label2.Text = "Хід Комп'ютера";
                    BotTurn();
                }
            }
        }

        Button GetButton(int buttonIndex)
        {
            switch (buttonIndex)
            {
                case 0:
                    return button1;
                case 1:
                    return button2;
                case 2:
                    return button3;
                case 3:
                    return button4;
                case 4:
                    return button5;
                case 5:
                    return button6;
                case 6:
                    return button7;
                case 7:
                    return button8;
                case 8:
                    return button9;
            }
            return button1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Turn(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turn(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Turn(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Turn(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turn(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turn(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Turn(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Turn(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Turn(8);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
