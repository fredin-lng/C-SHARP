
namespace GuessingWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmitLetter = new System.Windows.Forms.Button();
            this.txtBoxGuessLetter = new System.Windows.Forms.TextBox();
            this.btnSubmitWord = new System.Windows.Forms.Button();
            this.txtBoxWord = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picHangMan = new System.Windows.Forms.PictureBox();
            this.lblSelectedWord = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.lblWordsMissed = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblWordsMissed);
            this.groupBox1.Controls.Add(this.lblWordLength);
            this.groupBox1.Controls.Add(this.lblSelectedWord);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnNewGame);
            this.groupBox2.Controls.Add(this.btnSubmitLetter);
            this.groupBox2.Controls.Add(this.txtBoxGuessLetter);
            this.groupBox2.Controls.Add(this.btnSubmitWord);
            this.groupBox2.Controls.Add(this.txtBoxWord);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSubmitLetter
            // 
            this.btnSubmitLetter.Location = new System.Drawing.Point(6, 51);
            this.btnSubmitLetter.Name = "btnSubmitLetter";
            this.btnSubmitLetter.Size = new System.Drawing.Size(120, 23);
            this.btnSubmitLetter.TabIndex = 3;
            this.btnSubmitLetter.Text = "Submit Letter";
            this.btnSubmitLetter.UseVisualStyleBackColor = true;
            this.btnSubmitLetter.Click += new System.EventHandler(this.btnSubmitLetter_Click);
            // 
            // txtBoxGuessLetter
            // 
            this.txtBoxGuessLetter.Location = new System.Drawing.Point(6, 19);
            this.txtBoxGuessLetter.Name = "txtBoxGuessLetter";
            this.txtBoxGuessLetter.Size = new System.Drawing.Size(120, 20);
            this.txtBoxGuessLetter.TabIndex = 2;
            this.txtBoxGuessLetter.TextChanged += new System.EventHandler(this.txtBoxGuessLetter_TextChanged);
            // 
            // btnSubmitWord
            // 
            this.btnSubmitWord.Location = new System.Drawing.Point(150, 51);
            this.btnSubmitWord.Name = "btnSubmitWord";
            this.btnSubmitWord.Size = new System.Drawing.Size(120, 23);
            this.btnSubmitWord.TabIndex = 1;
            this.btnSubmitWord.Text = "Submit Word";
            this.btnSubmitWord.UseVisualStyleBackColor = true;
            this.btnSubmitWord.Click += new System.EventHandler(this.btnSubmitWord_Click);
            // 
            // txtBoxWord
            // 
            this.txtBoxWord.Location = new System.Drawing.Point(150, 19);
            this.txtBoxWord.Name = "txtBoxWord";
            this.txtBoxWord.Size = new System.Drawing.Size(120, 20);
            this.txtBoxWord.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.picHangMan);
            this.groupBox3.Location = new System.Drawing.Point(520, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 390);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // picHangMan
            // 
            this.picHangMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHangMan.Image = ((System.Drawing.Image)(resources.GetObject("picHangMan.Image")));
            this.picHangMan.Location = new System.Drawing.Point(3, 16);
            this.picHangMan.Name = "picHangMan";
            this.picHangMan.Size = new System.Drawing.Size(222, 371);
            this.picHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangMan.TabIndex = 0;
            this.picHangMan.TabStop = false;
            // 
            // lblSelectedWord
            // 
            this.lblSelectedWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedWord.Location = new System.Drawing.Point(6, 136);
            this.lblSelectedWord.Name = "lblSelectedWord";
            this.lblSelectedWord.Size = new System.Drawing.Size(490, 39);
            this.lblSelectedWord.TabIndex = 1;
            this.lblSelectedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(376, 51);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordLength.Location = new System.Drawing.Point(336, 265);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(131, 25);
            this.lblWordLength.TabIndex = 2;
            this.lblWordLength.Text = "Word Length:";
            // 
            // lblWordsMissed
            // 
            this.lblWordsMissed.AutoSize = true;
            this.lblWordsMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsMissed.Location = new System.Drawing.Point(6, 265);
            this.lblWordsMissed.Name = "lblWordsMissed";
            this.lblWordsMissed.Size = new System.Drawing.Size(81, 25);
            this.lblWordsMissed.TabIndex = 3;
            this.lblWordsMissed.Text = "Missed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(776, 453);
            this.MinimumSize = new System.Drawing.Size(776, 453);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing A Word";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHangMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picHangMan;
        private System.Windows.Forms.Button btnSubmitLetter;
        private System.Windows.Forms.TextBox txtBoxGuessLetter;
        private System.Windows.Forms.Button btnSubmitWord;
        private System.Windows.Forms.TextBox txtBoxWord;
        private System.Windows.Forms.Label lblSelectedWord;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblWordsMissed;
        private System.Windows.Forms.Label lblWordLength;
    }
}

