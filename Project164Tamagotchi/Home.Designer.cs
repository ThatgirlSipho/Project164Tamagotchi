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
            this.SuspendLayout();
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(493, 333);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(75, 23);
            this.btnSleep.TabIndex = 0;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(493, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sleep Level:";
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Location = new System.Drawing.Point(563, 279);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(10, 13);
            this.lblSleep.TabIndex = 2;
            this.lblSleep.Text = ".";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}