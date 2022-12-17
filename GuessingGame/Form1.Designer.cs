
namespace GuessingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxGuessing = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPreviousGuess = new System.Windows.Forms.Label();
            this.lblNewGameTimer = new System.Windows.Forms.Label();
            this.newGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guessing Game!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guess a number between 1 and 15";
            // 
            // txtBoxGuessing
            // 
            this.txtBoxGuessing.Location = new System.Drawing.Point(174, 275);
            this.txtBoxGuessing.Name = "txtBoxGuessing";
            this.txtBoxGuessing.Size = new System.Drawing.Size(138, 33);
            this.txtBoxGuessing.TabIndex = 2;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(129, 224);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 25);
            this.lblHint.TabIndex = 3;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(30, 386);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(138, 36);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(174, 386);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(138, 36);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(318, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(74, 177);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(302, 29);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Numbers guessed correctly";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviousGuess
            // 
            this.lblPreviousGuess.AutoSize = true;
            this.lblPreviousGuess.Location = new System.Drawing.Point(156, 333);
            this.lblPreviousGuess.Name = "lblPreviousGuess";
            this.lblPreviousGuess.Size = new System.Drawing.Size(0, 25);
            this.lblPreviousGuess.TabIndex = 8;
            // 
            // lblNewGameTimer
            // 
            this.lblNewGameTimer.AutoSize = true;
            this.lblNewGameTimer.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGameTimer.Location = new System.Drawing.Point(22, 275);
            this.lblNewGameTimer.Name = "lblNewGameTimer";
            this.lblNewGameTimer.Size = new System.Drawing.Size(0, 45);
            this.lblNewGameTimer.TabIndex = 9;
            // 
            // newGameTimer
            // 
            this.newGameTimer.Interval = 500;
            this.newGameTimer.Tick += new System.EventHandler(this.newGameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 434);
            this.Controls.Add(this.lblNewGameTimer);
            this.Controls.Add(this.lblPreviousGuess);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.txtBoxGuessing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(495, 473);
            this.MinimumSize = new System.Drawing.Size(495, 473);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game (Alfredo Castillo)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxGuessing;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPreviousGuess;
        private System.Windows.Forms.Label lblNewGameTimer;
        private System.Windows.Forms.Timer newGameTimer;
    }
}

