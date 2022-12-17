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
/// Program Objectinve: This program is a simple rock paper scissors game. 
/// Date: 11/30/2021
/// </summary>
/// 
namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// declasre variables
        /// </summary>
        int playerOneChoice;
        int playerTwoChoice;
        int p1Score = 0;
        int p2Score = 0;
        int imageCounterP1 = 0;
        int imageCounterP2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// select rock
        /// </summary>    
        private void btnRock_Click(object sender, EventArgs e)
        {
            // load rock image to player one picture box
            picBoxPlayerOne.Image = Properties.Resources.rock;
            playerOneChoice = 0;
            playerTwoChoice = playerTwoTurn();
            imageTimerPlayerOne.Stop();
            imageTimerPlayerTwo.Stop();
            winner();
            imageTimerPlayerOne.Start();
            imageTimerPlayerTwo.Start();
        }

        /// <summary>
        /// select paper
        /// </summary>    
        private void btnPaper_Click(object sender, EventArgs e)
        {
            // load paper image to player one picture box
            picBoxPlayerOne.Image = Properties.Resources.paper;
            playerOneChoice = 1;
            playerTwoChoice = playerTwoTurn();
            imageTimerPlayerOne.Stop();
            imageTimerPlayerTwo.Stop();
            winner();
            imageTimerPlayerOne.Start();
            imageTimerPlayerTwo.Start();
        }

        /// <summary>
        /// select scissors
        /// </summary>        
        private void btnScissors_Click(object sender, EventArgs e)
        {
            // load scissor image to player one picture box
            picBoxPlayerOne.Image = Properties.Resources.scissors;
            playerOneChoice = 2;
            playerTwoChoice = playerTwoTurn();
            imageTimerPlayerOne.Stop();
            imageTimerPlayerTwo.Stop();
            winner();
            imageTimerPlayerOne.Start();
            imageTimerPlayerTwo.Start();
        }

        /// <summary>
        ///  close application
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        /// <summary>
        /// set image for computer turn (player two)
        /// </summary>
        /// <returns>0:Rock, 1:Paper, 2:Scissors</returns>
        private int playerTwoTurn()
        {            
            Random rnd = new Random();
            int playerTwo = rnd.Next(3);

            if (playerTwo == 0)
            {
                picBoxPlayerTwo.Image = Properties.Resources.rock;
            }
            else
            {
                if (playerTwo == 1)
                {
                    picBoxPlayerTwo.Image = Properties.Resources.paper;
                }
                else
                {
                    picBoxPlayerTwo.Image = Properties.Resources.scissors;
                }
            }           

            return playerTwo;
        }

        /// <summary>
        ///  this void checks for a winner
        /// </summary>
        private void winner()
        {
            switch (playerOneChoice)
            {
                case 0:
                    if (playerTwoChoice == 2)
                    {
                        p1Score++;
                        lblPlayerOne.Text = "User Wins: " + p1Score.ToString();
                        MessageBox.Show("You Won!", "Results", MessageBoxButtons.OK);
                    }
                    else if (playerOneChoice == playerTwoChoice)
                    {
                        MessageBox.Show("It's a Tie!", "Results", MessageBoxButtons.OK);
                    }
                    else
                    {
                        p2Score++;
                        lblPlayerTwo.Text = "Computer Wins: " + p2Score.ToString();
                        MessageBox.Show("You Loose!", "Results", MessageBoxButtons.OK);
                    }
                    break;
                case 1:
                    if (playerTwoChoice == 0)
                    {
                        p1Score++;
                        lblPlayerOne.Text = "User Wins: " + p1Score.ToString();
                        MessageBox.Show("You Won!", "Results", MessageBoxButtons.OK);
                    }
                    else if (playerOneChoice == playerTwoChoice)
                    {
                        MessageBox.Show("It's a Tie!", "Results", MessageBoxButtons.OK);
                    }
                    else
                    {
                        p2Score++;
                        lblPlayerTwo.Text = "Computer Wins: " + p2Score.ToString();
                        MessageBox.Show("You Loose!", "Results", MessageBoxButtons.OK);
                    }
                    break;
                case 2:
                    if (playerTwoChoice == 1)
                    {
                        p1Score++;
                        lblPlayerOne.Text = "User Wins: " + p1Score.ToString();
                        MessageBox.Show("You Won!", "Results", MessageBoxButtons.OK);
                    }
                    else if (playerOneChoice == playerTwoChoice)
                    {
                        MessageBox.Show("It's a Tie!", "Results", MessageBoxButtons.OK);
                    }
                    else
                    {
                        p2Score++;
                        lblPlayerTwo.Text = "Computer Wins: " + p2Score.ToString();
                        MessageBox.Show("You Loose!", "Results", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    break;
            }
            
        }

        /// <summary>
        /// loop through images for player 1 and player 2
        /// </summary>
        private void imageTimerPlayerOne_Tick(object sender, EventArgs e)
        {
            picBoxPlayerOne.Image = imageListRockPaperScissors.Images[imageCounterP1];

            if (imageCounterP1 == imageListRockPaperScissors.Images.Count - 1)
            {
                imageCounterP1 = 0;
            }
            else
            {
                imageCounterP1++;
            }
        }

        private void imageTimerPlayerTwo_Tick(object sender, EventArgs e)
        {
            picBoxPlayerTwo.Image = imageListRockPaperScissors.Images[imageCounterP2];

            if (imageCounterP2 == imageListRockPaperScissors.Images.Count - 1)
            {
                imageCounterP2 = 0;
            }
            else
            {
                imageCounterP2++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imageCounterP1 = 0;
            imageCounterP2 = 0;
            lblPlayerOne.Text = "User Wins:";
            lblPlayerTwo.Text = "Computer Wins:";
        }
    }
}
