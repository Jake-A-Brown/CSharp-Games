using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*********************************
    * Class: CIST 2341 C#
    * Term: Spring 2023
    * Instructor: Ronald, Enz
    * Description: Solution Craps
    * Author: -Jake, Brown

*********************************/

namespace Craps
{
    public partial class Craps : Form
    {
        private int point = 0;
        private bool gameEnded = true;

        public Craps()
        {
            InitializeComponent();
        }


        private void RollBtn_Click(object sender, EventArgs e)
        {
            if (gameEnded)
            {
                // Start a new game
                point = 0;
                gameEnded = false;
                OutputLabel.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }

            Random rand = new Random();
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int sum = roll1 + roll2;

            pictureBox1.Image = Image.FromFile($"C:/Users/loucr/OneDrive/Desktop/ChattTech/ChattTech/Spring 2023/CIST2341/Week16/Craps/Craps/dice{roll1}.png");
            pictureBox2.Image = Image.FromFile($"C:/Users/loucr/OneDrive/Desktop/ChattTech/ChattTech/Spring 2023/CIST2341/Week16/Craps/Craps/dice{roll2}.png");

            if (point == 0)
            {
                // First roll
                if (sum == 7 || sum == 11)
                {
                    OutputLabel.Text += "You win!\r\n";
                    gameEnded = true;
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    OutputLabel.Text += "You lose!\r\n";
                    gameEnded = true;
                }
                else
                {
                    point = sum;
                    OutputLabel.Text += $"Your point is {point}\r\n";
                }
            }
            else
            {
                // Subsequent roll
                if (sum == point)
                {
                    OutputLabel.Text += "You win!\r\n";
                    gameEnded = true;
                }
                else if (sum == 7)
                {
                    OutputLabel.Text += "You lose!\r\n";
                    gameEnded = true;
                }
            }
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            gameEnded = true;
            RollBtn_Click(sender, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
