namespace Project164Tamagotchi
{
    partial class PlayForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(576, 140);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 55);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(45, 296);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(93, 29);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer";
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOne.Location = new System.Drawing.Point(226, 157);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(24, 25);
            this.lblNumOne.TabIndex = 2;
            this.lblNumOne.Text = "?";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTwo.Location = new System.Drawing.Point(304, 157);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(24, 25);
            this.lblNumTwo.TabIndex = 3;
            this.lblNumTwo.Text = "?";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(265, 157);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(24, 25);
            this.lblSymbol.TabIndex = 4;
            this.lblSymbol.Text = "?";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(88, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 29);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(406, 162);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(121, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(571, 23);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(90, 29);
            this.lblCredit.TabIndex = 7;
            this.lblCredit.Text = "Credit: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(265, 23);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(120, 29);
            this.lblTimeLeft.TabIndex = 8;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblNumTwo);
            this.Controls.Add(this.lblNumOne);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCheck);
            this.Name = "PlayForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}
