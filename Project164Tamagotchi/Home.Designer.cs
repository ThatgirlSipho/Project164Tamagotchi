namespace Project164Tamagotchi
{
    partial class Home
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
            this.btnSleep = new System.Windows.Forms.Button();
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.timerAwake = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblSleep = new System.Windows.Forms.Label();
            this.btnPantry = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblHappiness = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Sienna;
            this.btnSleep.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSleep.Location = new System.Drawing.Point(843, 549);
            this.btnSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(190, 65);
            this.btnSleep.TabIndex = 0;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // timerSleep
            // 
            this.timerSleep.Interval = 2000;
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // timerAwake
            // 
            this.timerAwake.Interval = 12000;
            this.timerAwake.Tick += new System.EventHandler(this.timerAwake_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(892, 492);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sleep:";
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleep.ForeColor = System.Drawing.Color.Sienna;
            this.lblSleep.Location = new System.Drawing.Point(969, 492);
            this.lblSleep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(18, 24);
            this.lblSleep.TabIndex = 2;
            this.lblSleep.Text = ".";
            // 
            // btnPantry
            // 
            this.btnPantry.BackColor = System.Drawing.Color.Sienna;
            this.btnPantry.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantry.Location = new System.Drawing.Point(502, 549);
            this.btnPantry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPantry.Name = "btnPantry";
            this.btnPantry.Size = new System.Drawing.Size(190, 65);
            this.btnPantry.TabIndex = 4;
            this.btnPantry.Text = "Pantry";
            this.btnPantry.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Sienna;
            this.btnPlay.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(162, 549);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(190, 65);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(216, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Play:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(540, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pantry";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.Sienna;
            this.lblPlay.Location = new System.Drawing.Point(279, 495);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(18, 24);
            this.lblPlay.TabIndex = 8;
            this.lblPlay.Text = ".";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.Sienna;
            this.lblCredits.Location = new System.Drawing.Point(630, 495);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(18, 24);
            this.lblCredits.TabIndex = 9;
            this.lblCredits.Text = ".";
            // 
            // lblHappiness
            // 
            this.lblHappiness.AutoSize = true;
            this.lblHappiness.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappiness.ForeColor = System.Drawing.Color.Sienna;
            this.lblHappiness.Location = new System.Drawing.Point(100, 86);
            this.lblHappiness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHappiness.Name = "lblHappiness";
            this.lblHappiness.Size = new System.Drawing.Size(247, 129);
            this.lblHappiness.TabIndex = 10;
            this.lblHappiness.Text = "100";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Sienna;
            this.btnSave.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1064, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 54);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Sienna;
            this.btnClose.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1064, 86);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 54);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(402, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Sienna;
            this.btnRefresh.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(562, 624);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "🔁";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(476, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(199, 63);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Sienna;
            this.lblScore.Location = new System.Drawing.Point(1079, 163);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(103, 63);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(894, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 63);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gold:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHappiness);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPantry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSleep);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Timer timerSleep;
        private System.Windows.Forms.Timer timerAwake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.Button btnPantry;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblHappiness;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label5;
    }
}