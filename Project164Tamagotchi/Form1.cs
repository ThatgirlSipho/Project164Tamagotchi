using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project164Tamagotchi
{
    public partial class Form1 : Form
    {
        //Create mediaplayer
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
                    
           InitializeComponent();
            //read music from location
            //player.settings.setMode("loop", true);
             //_soundPlayer = new SoundPlayer("shrek.wave");
            //_soundPlayer.URL = 
            // WindowsMediaPlayer player = new WindowsMediaPlayer();

            
            //player.URL = Shrek_song;
            //player.settings.setMode("loop", true);
            //_soundPlayer.Stream = new MemoryStream(Properties.Resources.Shrek)
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
        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            //Play music
             //_soundPlayer.Play();
        }
        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            //Stop music
           //_soundPlayer.Stop();
        }
    }
}
