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
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Sienna;
            this.btnSleep.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSleep.Location = new System.Drawing.Point(451, 313);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(125, 42);
            this.btnSleep.TabIndex = 0;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // timerSleep
            // 
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // timerAwake
            // 
            this.timerAwake.Tick += new System.EventHandler(this.timerAwake_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(448, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sleep Level:";
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleep.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSleep.Location = new System.Drawing.Point(563, 279);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(13, 17);
            this.lblSleep.TabIndex = 2;
            this.lblSleep.Text = ".";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblName.Location = new System.Drawing.Point(273, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 43);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSleep);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Timer timerSleep;
        private System.Windows.Forms.Timer timerAwake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.Label lblName;
    }
}