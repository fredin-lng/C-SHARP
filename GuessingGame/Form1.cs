using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Programmer: Alfredo Castillo
/// Program Objectinve: This is a guessing fame. 
/// Date: 12/02/2021
/// </summary>
/// 
namespace GuessingGame
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// declare variables
        /// </summary>
        int userGuess;
        int guessNumber;
        int oNumber;
        bool result;
        int timesGuessedCorrectly = 0;
        int secondsLeft = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuess.Enabled = false;
            txtBoxGuessing.Enabled = false;
            lblNewGameTimer.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {            
            checkGuessedNumber();
            txtBoxGuessing.Text = string.Empty;
            txtBoxGuessing.Focus();
        }

        /// <summary>
        /// check user input against random number. if its a match then let user know he guessed correctly. if too low
        /// let user know he guessed to low. if too high let user know.
        /// </summary>
        public void checkGuessedNumber()
        {
            // validate user input
            result = int.TryParse(txtBoxGuessing.Text, out oNumber);
            
            if (result)
            {
                userGuess = Convert.ToInt32(txtBoxGuessing.Text);
                if (isUserInputWithinRange(userGuess) == false)
                {
                    if (guessNumber == userGuess)
                    {
                        lblHint.Text = "You Guessed Correct";
                        timesGuessedCorrectly++;
                        lblScore.Text = string.Format("Numbers guessed correctly: {0}", timesGuessedCorrectly);
                        lblHint.Text = string.Empty;
                        requestNewNumber();
                        lblPreviousGuess.Text = string.Empty;
                        startNewGameBanner();
                    }
                    else if (userGuess > guessNumber)
                    {
                        lblHint.Text = "Guess Lower...";
                        previousGuesses(userGuess);
                    }
                    else
                    {
                        lblHint.Text = "Guess Higher...";
                        previousGuesses(userGuess);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input","Error");
            }            
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // if buttons are disabled then enable
            // force user to start new game when form is loaded
            if (btnGuess.Enabled == false)
            {
                btnGuess.Enabled = true;
                txtBoxGuessing.Enabled = true;
            }

            lblHint.Text = "";
            txtBoxGuessing.Text = string.Empty;
            txtBoxGuessing.Focus();

            requestNewNumber();
        }

        /// <summary>
        /// generate random number
        /// </summary>
        private void requestNewNumber()
        {
            Random rnd = new Random();
            guessNumber = rnd.Next(1,16);
        }

        /// <summary>
        /// display user previous guessed number
        /// </summary>
        /// <param name="guess"></param>
        private void previousGuesses(int guess)
        {
            lblPreviousGuess.Text = string.Format("Previous guess: {0}", guess);
        }


        /// <summary>
        ///  check if user input is within specified number range
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private bool isUserInputWithinRange(int x)
        {
            if (x < 1 || x > 15)
            {
                MessageBox.Show("Pick a number between 1 and 15","Error");
                return true;
            }         
            else
            {
                return false;
            }
        }

        /// <summary>
        /// enables the new game countdown banner and starts the countdown
        /// </summary>
        private void startNewGameBanner()
        {
            lblNewGameTimer.Visible = true;
            lblNewGameTimer.Text = string.Format("New game starts in: {0}", secondsLeft=5);
            newGameTimer.Start();
        }

        /// <summary>
        /// starts a 5 second timer before new game begins
        /// </summary>
        private void newGameTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            lblNewGameTimer.Text = string.Format("New game starts in: {0}", secondsLeft);
            if (secondsLeft == 0)
            {
                newGameTimer.Stop();
                lblNewGameTimer.Visible = false;
                txtBoxGuessing.Focus();
            }            
        }
    }
}
