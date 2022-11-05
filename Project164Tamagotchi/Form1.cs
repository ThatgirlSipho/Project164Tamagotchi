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
            player.URL = "C:\\Users\\sunev\\Documents\\2022\\Semester 2\\INF 164\\Part1.GroupINF164\\shrek.wav";
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

        private void btnPlay_Click_1(object sender, EventArgs e)
        {

        }
    }
}
