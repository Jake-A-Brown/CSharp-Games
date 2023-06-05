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
    * Description: Solution Guessing Game
    * Author: -Jake, Brown

*********************************/

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        int numberToGuess;
        int numberOfGuesses;
        public GuessingGame()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = int.Parse(txtGuess.Text);
          
            if (guess == numberToGuess)
            {
                numberOfGuesses++;
                MessageBox.Show("You guessed the number in " + numberOfGuesses + " guesses!", "Congratulations!");
                btnGuess.Enabled = false;
                btnPlayAgain.Enabled = true;
            }
            else if (guess < numberToGuess)
            {
                numberOfGuesses++;
                lblResult.Text = "Too low!";
            }
            else
            {
                numberOfGuesses++;
                lblResult.Text = "Too high!";
            }
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
        }
        private void NewGame()
        {
            Random rand = new Random();
            numberToGuess = rand.Next(1, 101);
            numberOfGuesses = 0;
            txtGuess.Text = "";
            lblResult.Text = "";
            btnGuess.Enabled = true;
            btnPlayAgain.Enabled = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
