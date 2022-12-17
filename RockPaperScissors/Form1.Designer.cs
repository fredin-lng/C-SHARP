
namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.picBoxTitle = new System.Windows.Forms.PictureBox();
            this.picBoxPlayerTwo = new System.Windows.Forms.PictureBox();
            this.picBoxPlayerOne = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageListRockPaperScissors = new System.Windows.Forms.ImageList(this.components);
            this.imageTimerPlayerOne = new System.Windows.Forms.Timer(this.components);
            this.imageTimerPlayerTwo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(137, 203);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(85, 20);
            this.lblPlayerOne.TabIndex = 0;
            this.lblPlayerOne.Text = "User Wins:";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(304, 203);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(126, 20);
            this.lblPlayerTwo.TabIndex = 1;
            this.lblPlayerTwo.Text = "Computer Wins:";
            // 
            // picBoxTitle
            // 
            this.picBoxTitle.Image = global::RockPaperScissors.Properties.Resources.title;
            this.picBoxTitle.Location = new System.Drawing.Point(44, 12);
            this.picBoxTitle.Name = "picBoxTitle";
            this.picBoxTitle.Size = new System.Drawing.Size(408, 145);
            this.picBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle.TabIndex = 4;
            this.picBoxTitle.TabStop = false;
            // 
            // picBoxPlayerTwo
            // 
            this.picBoxPlayerTwo.Location = new System.Drawing.Point(294, 236);
            this.picBoxPlayerTwo.Name = "picBoxPlayerTwo";
            this.picBoxPlayerTwo.Size = new System.Drawing.Size(140, 204);
            this.picBoxPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerTwo.TabIndex = 3;
            this.picBoxPlayerTwo.TabStop = false;
            // 
            // picBoxPlayerOne
            // 
            this.picBoxPlayerOne.Location = new System.Drawing.Point(131, 236);
            this.picBoxPlayerOne.Name = "picBoxPlayerOne";
            this.picBoxPlayerOne.Size = new System.Drawing.Size(140, 204);
            this.picBoxPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerOne.TabIndex = 2;
            this.picBoxPlayerOne.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(23, 236);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 33);
            this.btnRock.TabIndex = 5;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(23, 407);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 33);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(23, 315);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 33);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 505);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageListRockPaperScissors
            // 
            this.imageListRockPaperScissors.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRockPaperScissors.ImageStream")));
            this.imageListRockPaperScissors.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRockPaperScissors.Images.SetKeyName(0, "paper.jpg");
            this.imageListRockPaperScissors.Images.SetKeyName(1, "rock.jpg");
            this.imageListRockPaperScissors.Images.SetKeyName(2, "scissors.jpg");
            // 
            // imageTimerPlayerOne
            // 
            this.imageTimerPlayerOne.Enabled = true;
            this.imageTimerPlayerOne.Interval = 200;
            this.imageTimerPlayerOne.Tick += new System.EventHandler(this.imageTimerPlayerOne_Tick);
            // 
            // imageTimerPlayerTwo
            // 
            this.imageTimerPlayerTwo.Enabled = true;
            this.imageTimerPlayerTwo.Interval = 120;
            this.imageTimerPlayerTwo.Tick += new System.EventHandler(this.imageTimerPlayerTwo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(491, 550);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.picBoxTitle);
            this.Controls.Add(this.picBoxPlayerTwo);
            this.Controls.Add(this.picBoxPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(507, 589);
            this.MinimumSize = new System.Drawing.Size(507, 589);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.PictureBox picBoxPlayerOne;
        private System.Windows.Forms.PictureBox picBoxPlayerTwo;
        private System.Windows.Forms.PictureBox picBoxTitle;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageListRockPaperScissors;
        private System.Windows.Forms.Timer imageTimerPlayerOne;
        private System.Windows.Forms.Timer imageTimerPlayerTwo;
    }
}

