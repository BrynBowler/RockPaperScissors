
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
            this.Result = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.opponentTalley = new System.Windows.Forms.Label();
            this.userTalley = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.opponentImage = new System.Windows.Forms.PictureBox();
            this.versusImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versusImage)).BeginInit();
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
            this.opponentResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.opponentResult.Enabled = false;
            this.opponentResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opponentResult.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.opponentResult.Location = new System.Drawing.Point(598, 313);
            this.opponentResult.Name = "opponentResult";
            this.opponentResult.Size = new System.Drawing.Size(164, 33);
            this.opponentResult.TabIndex = 3;
            this.opponentResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opponentResult.TextChanged += new System.EventHandler(this.opponentResult_TextChanged);
            // 
            // userResult
            // 
            this.userResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.userResult.Enabled = false;
            this.userResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userResult.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.userResult.Location = new System.Drawing.Point(216, 313);
            this.userResult.Name = "userResult";
            this.userResult.Size = new System.Drawing.Size(164, 33);
            this.userResult.TabIndex = 4;
            this.userResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userResult.TextChanged += new System.EventHandler(this.userPlay_TextChanged);
            // 
            // playResult
            // 
            this.playResult.AutoSize = true;
            this.playResult.Location = new System.Drawing.Point(26, 9);
            this.playResult.Name = "playResult";
            this.playResult.Size = new System.Drawing.Size(170, 15);
            this.playResult.TabIndex = 5;
            this.playResult.Text = "Choose Rock, Paper or Scissors";
            this.playResult.Click += new System.EventHandler(this.playResult_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.GrayText;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Result.Location = new System.Drawing.Point(410, 31);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(154, 33);
            this.Result.TabIndex = 6;
            this.Result.Text = "In Play";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(410, 394);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(154, 54);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "Next Round";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // opponentTalley
            // 
            this.opponentTalley.AutoSize = true;
            this.opponentTalley.BackColor = System.Drawing.SystemColors.Control;
            this.opponentTalley.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opponentTalley.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opponentTalley.Location = new System.Drawing.Point(662, 40);
            this.opponentTalley.Name = "opponentTalley";
            this.opponentTalley.Size = new System.Drawing.Size(41, 49);
            this.opponentTalley.TabIndex = 8;
            this.opponentTalley.Text = "0";
            this.opponentTalley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTalley
            // 
            this.userTalley.AutoSize = true;
            this.userTalley.BackColor = System.Drawing.SystemColors.Control;
            this.userTalley.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userTalley.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTalley.Location = new System.Drawing.Point(276, 40);
            this.userTalley.Name = "userTalley";
            this.userTalley.Size = new System.Drawing.Size(41, 49);
            this.userTalley.TabIndex = 9;
            this.userTalley.Text = "0";
            this.userTalley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userImage
            // 
            this.userImage.Location = new System.Drawing.Point(216, 129);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(164, 178);
            this.userImage.TabIndex = 10;
            this.userImage.TabStop = false;
            // 
            // opponentImage
            // 
            this.opponentImage.Location = new System.Drawing.Point(598, 129);
            this.opponentImage.Name = "opponentImage";
            this.opponentImage.Size = new System.Drawing.Size(164, 178);
            this.opponentImage.TabIndex = 11;
            this.opponentImage.TabStop = false;
            // 
            // versusImage
            // 
            this.versusImage.Location = new System.Drawing.Point(443, 172);
            this.versusImage.Name = "versusImage";
            this.versusImage.Size = new System.Drawing.Size(92, 95);
            this.versusImage.TabIndex = 12;
            this.versusImage.TabStop = false;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.versusImage);
            this.Controls.Add(this.opponentImage);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.userTalley);
            this.Controls.Add(this.opponentTalley);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.playResult);
            this.Controls.Add(this.userResult);
            this.Controls.Add(this.opponentResult);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versusImage)).EndInit();
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
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label opponentTalley;
        private System.Windows.Forms.Label userTalley;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.PictureBox opponentImage;
        private System.Windows.Forms.PictureBox versusImage;
    }
}

