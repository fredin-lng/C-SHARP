using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int turn;
        public int oWins = 0;
        public int xWins = 0;
        public int draws = 0;
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe\nProgrammer: Alfredo Castillo\nDate: 02/01/22\nAbout: This is a simple Tic Tac Toe game.","About",MessageBoxButtons.OK);
        }

        private void setFirstTurn()
        {
            // 0 = X
            // 1 = O
            Random rnd = new Random();
            int id = rnd.Next(0, 2);
            turn = id;
            if (turn == 0)
            {
                lblTurn.Text = "X turn";
            }
            else
            {
                lblTurn.Text = "O turn";
            }
        }

        private void nextTurn(int next)
        {

            if (next == 0)
            {
                lblTurn.Text = "X turn";
            }
            else
            {
                lblTurn.Text = "O turn";
            }
        }

        private void checkXWins()
        {
            int won = 0;

            // check horizontally
            if (btn0.Text == "X" && btn1.Text == "X" && btn2.Text == "X")
            {
                btn0.BackColor = Color.Green;
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                won = 1;
            }

            if (btn3.Text == "X" && btn4.Text == "X" && btn5.Text == "X")
            {
                btn3.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                won = 1;
            }

            if (btn6.Text == "X" && btn7.Text == "X" && btn8.Text == "X")
            {
                btn6.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }

            // check vertically
            if (btn0.Text == "X" && btn3.Text == "X" && btn6.Text == "X")
            {
                btn0.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                won = 1;
            }

            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                won = 1;
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }

            // check diagonally
            if (btn0.Text == "X" && btn4.Text == "X" && btn8.Text == "X")
            {
                btn0.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }
            if (btn2.Text == "X" && btn4.Text == "X" && btn6.Text == "X")
            {
                btn2.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                won = 1;
            }

            if (!string.IsNullOrEmpty(btn0.Text) && !string.IsNullOrEmpty(btn1.Text) && !string.IsNullOrEmpty(btn2.Text) && !string.IsNullOrEmpty(btn3.Text) && !string.IsNullOrEmpty(btn4.Text) && !string.IsNullOrEmpty(btn5.Text)
                 && !string.IsNullOrEmpty(btn6.Text) && !string.IsNullOrEmpty(btn7.Text) && !string.IsNullOrEmpty(btn8.Text))
            {
                draws++;
                lblDraws.Text = draws.ToString();
                MessageBox.Show("It's a draw!", "Results");

                resetGame();
            }

            if (won == 1)
            {
                xWins++;
                lblWinsX.Text = xWins.ToString();
                MessageBox.Show("X wins!");

                resetGame();
            }
        }
        private void checkOWins()
        {
            int won = 0;
            // check horizontally
            if (btn0.Text == "O" && btn1.Text == "O" && btn2.Text == "O")
            {
                btn0.BackColor = Color.Green;
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                won = 1;
            }
            if (btn3.Text == "O" && btn4.Text == "O" && btn5.Text == "O")
            {
                btn3.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                won = 1;
            }
            if (btn6.Text == "O" && btn7.Text == "O" && btn8.Text == "O")
            {
                btn6.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }

            // check vertically
            if (btn0.Text == "O" && btn3.Text == "O" && btn6.Text == "O")
            {
                btn0.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                won = 1;
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                won = 1;
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }

            // check diagonally
            if (btn0.Text == "O" && btn4.Text == "O" && btn8.Text == "O")
            {
                btn0.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                won = 1;
            }
            if (btn2.Text == "O" && btn4.Text == "O" && btn6.Text == "O")
            {
                btn2.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                won = 1;
            }

            if (!string.IsNullOrEmpty(btn0.Text) && !string.IsNullOrEmpty(btn1.Text) && !string.IsNullOrEmpty(btn2.Text) && !string.IsNullOrEmpty(btn3.Text) && !string.IsNullOrEmpty(btn4.Text) && !string.IsNullOrEmpty(btn5.Text)
                 && !string.IsNullOrEmpty(btn6.Text) && !string.IsNullOrEmpty(btn7.Text) && !string.IsNullOrEmpty(btn8.Text))
            {
                draws++;
                lblDraws.Text = draws.ToString();
                MessageBox.Show("It's a draw!", "Results");

                resetGame();
            }

            if (won == 1)
            {
                oWins++;
                lblWinsO.Text = oWins.ToString();
                MessageBox.Show("O wins!","Results");
                
                resetGame();
            }
        }
        private void resetGame()
        {

            btn0.BackColor = Color.White;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;

            btn0.ResetText();
            btn1.ResetText();
            btn2.ResetText();
            btn3.ResetText();
            btn4.ResetText();
            btn5.ResetText();
            btn6.ResetText();
            btn7.ResetText();
            btn8.ResetText();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picTitle.Image = Properties.Resources.titactoetitle;
            setFirstTurn();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn0.Text = "X";
                this.btn0.Font = new Font("Arial", 35);
                this.btn0.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn0.Text = "O";
                this.btn0.Font = new Font("Arial", 35);
                this.btn0.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn1.Text = "X";
                this.btn1.Font = new Font("Arial", 35);
                this.btn1.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn1.Text = "O";
                this.btn1.Font = new Font("Arial", 35);
                this.btn1.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn2.Text = "X";
                this.btn2.Font = new Font("Arial", 35);
                this.btn2.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn2.Text = "O";
                this.btn2.Font = new Font("Arial", 35);
                this.btn2.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn3.Text = "X";
                this.btn3.Font = new Font("Arial", 35);
                this.btn3.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn3.Text = "O";
                this.btn3.Font = new Font("Arial", 35);
                this.btn3.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn4.Text = "X";
                this.btn4.Font = new Font("Arial", 35);
                this.btn4.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn4.Text = "O";
                this.btn4.Font = new Font("Arial", 35);
                this.btn4.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn5.Text = "X";
                this.btn5.Font = new Font("Arial", 35);
                this.btn5.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn5.Text = "O";
                this.btn5.Font = new Font("Arial", 35);
                this.btn5.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn6.Text = "X";
                this.btn6.Font = new Font("Arial", 35);
                this.btn6.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn6.Text = "O";
                this.btn6.Font = new Font("Arial", 35);
                this.btn6.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn7.Text = "X";
                this.btn7.Font = new Font("Arial", 35);
                this.btn7.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn7.Text = "O";
                this.btn7.Font = new Font("Arial", 35);
                this.btn7.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                this.btn8.Text = "X";
                this.btn8.Font = new Font("Arial", 35);
                this.btn8.Enabled = false;
                checkXWins();
                turn = 1;
            }
            else
            {
                this.btn8.Text = "O";
                this.btn8.Font = new Font("Arial", 35);
                this.btn8.Enabled = false;
                checkOWins();
                turn = 0;
            }

            nextTurn(turn);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
