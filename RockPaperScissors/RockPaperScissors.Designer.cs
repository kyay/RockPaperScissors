namespace RockPaperScissors
{
    partial class RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblUserStats = new System.Windows.Forms.Label();
            this.lblComputerStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(13, 300);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(154, 47);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "1";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(173, 300);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(154, 47);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Tag = "2";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(333, 300);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(154, 47);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Tag = "3";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // lblUserStats
            // 
            this.lblUserStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStats.Location = new System.Drawing.Point(10, 9);
            this.lblUserStats.Name = "lblUserStats";
            this.lblUserStats.Size = new System.Drawing.Size(237, 288);
            this.lblUserStats.TabIndex = 3;
            this.lblUserStats.Text = "User Stats:";
            this.lblUserStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblComputerStats
            // 
            this.lblComputerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerStats.Location = new System.Drawing.Point(253, 9);
            this.lblComputerStats.Name = "lblComputerStats";
            this.lblComputerStats.Size = new System.Drawing.Size(232, 288);
            this.lblComputerStats.TabIndex = 4;
            this.lblComputerStats.Text = "Computer Stats:";
            this.lblComputerStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 359);
            this.Controls.Add(this.lblComputerStats);
            this.Controls.Add(this.lblUserStats);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "RockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblUserStats;
        private System.Windows.Forms.Label lblComputerStats;
    }
}

