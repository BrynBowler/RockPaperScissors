
namespace RockPaperScissors
{
    partial class RockPaperScissors
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.opponentResult = new System.Windows.Forms.TextBox();
            this.userResult = new System.Windows.Forms.TextBox();
            this.playResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rock.Location = new System.Drawing.Point(42, 31);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(135, 135);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Paper
            // 
            this.Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paper.Location = new System.Drawing.Point(42, 172);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(135, 135);
            this.Paper.TabIndex = 1;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Scissors
            // 
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.Location = new System.Drawing.Point(42, 313);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(135, 135);
            this.Scissors.TabIndex = 2;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // opponentResult
            // 
            this.opponentResult.Location = new System.Drawing.Point(629, 229);
            this.opponentResult.Name = "opponentResult";
            this.opponentResult.Size = new System.Drawing.Size(116, 23);
            this.opponentResult.TabIndex = 3;
            this.opponentResult.TextChanged += new System.EventHandler(this.opponentResult_TextChanged);
            // 
            // userResult
            // 
            this.userResult.Location = new System.Drawing.Point(212, 229);
            this.userResult.Name = "userResult";
            this.userResult.Size = new System.Drawing.Size(122, 23);
            this.userResult.TabIndex = 4;
            this.userResult.TextChanged += new System.EventHandler(this.userPlay_TextChanged);
            // 
            // playResult
            // 
            this.playResult.AutoSize = true;
            this.playResult.Location = new System.Drawing.Point(388, 28);
            this.playResult.Name = "playResult";
            this.playResult.Size = new System.Drawing.Size(170, 15);
            this.playResult.TabIndex = 5;
            this.playResult.Text = "Choose Rock, Paper or Scissors";
            this.playResult.Click += new System.EventHandler(this.playResult_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.playResult);
            this.Controls.Add(this.userResult);
            this.Controls.Add(this.opponentResult);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.TextBox opponentResult;
        private System.Windows.Forms.TextBox userPlay;
        private System.Windows.Forms.TextBox userResult;
        private System.Windows.Forms.Label playResult;
    }
}

