using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project164Tamagotchi
{
    public partial class PlayForm : Form
    {
        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;
        int credits = 0;
        int timeLeft;
        public PlayForm()
        {
            InitializeComponent();
            SetUpGame();
        }

        private Tamagotchi petPlay;
        public Tamagotchi  PetPlay
        {
            get { return petPlay; }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CheckAnswer(object sender, EventArgs e)
        {
            //Ensures that only numbers are entered
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
            else if(txtAnswer.Text == null)
            { 
                MessageBox.Show("Please enter a value");
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                //Player gets the answer right
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 10;
                lblScore.Text = "Score: " + score;
                SetUpGame();
                petPlay = new Tamagotchi();
                petPlay.Credit = score;

            }
            else
            {   //Player gets the answer wrong
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }
        }
    private void SetUpGame()
            //randomizes numbers
            //equation set up
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.HotPink;
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Crimson;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    break;
            }

            lblNumOne.Text = numA.ToString();
            lblNumTwo.Text = numB.ToString();
            //Timer starts
            //Timer restarts when player gets the answer right
            timeLeft = 30;
            lblTimeLeft.Text = "30 seconds";
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
           if (timeLeft > 0)
            {   //Countdown will continue
                timeLeft = timeLeft - 1;
                lblTimeLeft.Text = "Time Left: " + timeLeft + " seconds";
            }
            else
            {
               //The Player has ran out of time.
                gameTimer.Stop();
                lblTimeLeft.Text = "Time's up!";
                btnCheck.Enabled = false;
            }

        }

      
    }    
}
