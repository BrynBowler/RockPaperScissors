
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
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
    }
}

