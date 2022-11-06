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
            //Read instructions from file
            string path = @"Instructions.txt";
            StreamReader read = new StreamReader(File.OpenRead(path));
            MessageBox.Show(read.ReadToEnd());
            read.Close();
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
