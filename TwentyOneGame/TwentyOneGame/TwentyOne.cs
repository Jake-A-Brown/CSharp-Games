using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********************************
    * Class: CIST 2341 C#
    * Term: Spring 2023
    * Instructor: Ronald, Enz
    * Description: Project Twenty One
    * Author: -Jake, Brown

*********************************/

namespace TwentyOneGame
{
    public partial class TwentyOne : Form
    {
        int score;
        Random random = new Random();

        public TwentyOne()
        {
            InitializeComponent();
            //ResetGame();
        }
        private void ResetGame()
        {
            score = 0;
            RollDice();
        }
        private void RollDice()
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            if (score < 15)
            {
                try
                {
                    // Roll two dice
                    pictureBox1.Image = Image.FromFile($"C:/Users/loucr/OneDrive/Desktop/ChattTech/ChattTech/Spring 2023/CIST2341/Week16/TwentyOneGame/TwentyOneGame/dice{dice1}.png");
                    pictureBox2.Image = Image.FromFile($"C:/Users/loucr/OneDrive/Desktop/ChattTech/ChattTech/Spring 2023/CIST2341/Week16/TwentyOneGame/TwentyOneGame/dice{dice2}.png");
                    score += dice1 + dice2;
                }catch (Exception ex) { Debug.WriteLine(ex.Message); }
            }
            else
                {
                    // Roll one die
                    pictureBox1.Image = Image.FromFile($"C:/Users/loucr/OneDrive/Desktop/ChattTech/ChattTech/Spring 2023/CIST2341/Week16/TwentyOneGame/TwentyOneGame/dice{dice1}.png");
                    pictureBox2.Image = null;
                    score += dice1; 
            }

            labelScore.Text = $"Score: {score}";

            if (score > 21)
            {
                MessageBox.Show("You lose!");
                ResetGame();
            }
            else if (score == 21)
            {
                MessageBox.Show("You win!");
                ResetGame();
            }
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
