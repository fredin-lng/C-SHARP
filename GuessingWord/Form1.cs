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
/// Program Objectinve: This a game of guessing a word by letter or entire word.
/// Date: 12/10/2021
/// </summary>
///
namespace GuessingWord
{
    public partial class Form1 : Form
    {
        // declare variables
        public string selectedWord;
        private string temp;
        private string guess;
        private char letter;
        private bool letterInWord = false;
        private int foundCount;
        char ch;
        bool result;

        private Bitmap[] hangImages = {Properties.Resources.hangman1, Properties.Resources.hangman2, Properties.Resources.hangman3,
                                        Properties.Resources.hangman4, Properties.Resources.hangman5, Properties.Resources.hangman6, Properties.Resources.hangman7 };
        private int wrongGuess = 0;

        string[] words = { "apricot", "elephant", "tigress", "fortunate", "impossible", "historical", "colorful", "science" };

        public Form1()
        {
            InitializeComponent();

            // pick a new word when form loads
            setUpWord(newWord());

            lblSelectedWord.Text = guess;

            // display selected/mystery word length to user
            lblWordLength.Text = "Word Length: " + newWordCount(selectedWord).ToString();
        }

        public string newWord()
        {
            /// pic a new random word
            Random rnd = new Random();
            int wordIndex = rnd.Next(0, 8);
            string mysteryWord = words[wordIndex];
            selectedWord = mysteryWord;
            temp = selectedWord;
            return mysteryWord;
        }

        public int newWordCount(string word)
        {
            // count the length of selected/mystery word
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                count = i;
            }
            return count;
        }

        public void setUpWord(string word)
        {
            // replace selected/mystery word charcters with -
            Random random = new Random();
            int nr = random.Next(0, 2);

            for (int i = 0; i < word.Length; i++)
            {
                 guess += "-";
            }
        }

        private void btnSubmitLetter_Click(object sender, EventArgs e)
        {
            // assign letter the submitted guess letter
            result = char.TryParse(txtBoxGuessLetter.Text, out ch);
            if (result)
            {
                letter = Convert.ToChar(txtBoxGuessLetter.Text.Substring(0, 1));
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    char tempChar = Convert.ToChar(selectedWord.Substring(i, 1));

                    if (tempChar == letter)
                    {
                        guess = guess.Substring(0, i) + letter + guess.Substring(i + 1, (guess.Length - 1 - i));

                        selectedWord = selectedWord.Substring(0, i) + '?' + selectedWord.Substring(i + 1, (guess.Length - 1 - i));

                        ++foundCount;
                        letterInWord = true;
                    }
                }

                // if submitted letter is not a match then count as wrong guess and switch image. log letter that is not a match
                if (!letterInWord)
                {
                    wrongGuess++;
                    if (wrongGuess < 7)
                    {
                        picHangMan.Image = hangImages[wrongGuess];
                        lblWordsMissed.Text += letter + ", ";
                    }
                    else
                    {
                        MessageBox.Show("YOU LOOSE");
                    }
                }

                txtBoxGuessLetter.Text = string.Empty;
                txtBoxGuessLetter.Focus();
                letterInWord = false;

                lblSelectedWord.Text = guess;
            }
            else
            {
                MessageBox.Show("Check input");
            }           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            /// reset all labels and pick a new word
            selectedWord = "";
            guess="";
            letterInWord = false;
            
            setUpWord(newWord());

            lblSelectedWord.Text = guess;
            lblWordsMissed.Text = "Missed:";
            
            letterInWord = false;

            picHangMan.Image = hangImages[0];

        }

        private void btnSubmitWord_Click(object sender, EventArgs e)
        {
            //call woord sumission check
            checkWordSubmission(temp);                                  
        }

        public void checkWordSubmission(string word)
        {
            // check if submitted word matched selected/mystery word. if match announce winner. else check if word submitted is wrong and 
            // increment hangman
            if (txtBoxWord.Text == word)
            {
                lblSelectedWord.Text = txtBoxWord.Text;
                MessageBox.Show("Congratulations You Won!");
            }
            else
            {
                wrongGuess++;
                if (wrongGuess < 7)
                {
                    picHangMan.Image = hangImages[wrongGuess];
                    lblWordsMissed.Text += txtBoxWord.Text + ", ";
                }
                else
                {
                    MessageBox.Show("YOU LOOSE");
                }
            }

            txtBoxWord.Text = string.Empty;
        }

        private void txtBoxGuessLetter_TextChanged(object sender, EventArgs e)
        {
            // if input character length is greater than 1 delete last character
            string s = txtBoxGuessLetter.Text;
            
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }

            txtBoxGuessLetter.Text = s;
        }
    }
}
