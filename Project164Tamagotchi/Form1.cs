using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;


namespace Project164Tamagotchi
{
    
    public partial class Form1 : Form
    {
        //code to open windows media player
        WindowsMediaPlayer player = new WindowsMediaPlayer();
       
        public Form1()
        {
                    
           InitializeComponent();
            //to locate mediaplayer file
            player.URL = "shrek.mp3"; 
            player.settings.setMode("loop", true);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Home myform = new Home();

            if (cbxNames.SelectedIndex == 0)
            {
                myform.pet.Character = "Fiona";
            }
            else
            {
                myform.pet.Character = "Shrek";
            }
            myform.ShowDialog();
            this.Close();
        }
         private void btnClose_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Write the file first
            StreamWriter outputFile;
            outputFile = new StreamWriter("Instructions.txt");
            outputFile.WriteLine("Welcome to the world of Shrek and Fiona. To start the game please select which character you want to be. Your pet needs to be taken care of. You must feed your pet, make sure it sleeps and then it also needs some entertainment. If you do not do these things with your pet they will die and your game will be over. Goodluck and have fun!");
            outputFile.Close();

            //Read instructions from file
            StreamReader inputFile;
            inputFile = new StreamReader("Instructions.txt");
            string inputAllLines;
            inputAllLines = inputFile.ReadToEnd();
            MessageBox.Show(inputAllLines);
            inputFile.Close();
        }

        private void btnStopMusic_Click_1(object sender, EventArgs e)
        {
            //stop music playing
            player.controls.stop();
        }

        private void btnPlayMusic_Click_1(object sender, EventArgs e)
        {
            //start music
            player.controls.play();
        }
    }
}
