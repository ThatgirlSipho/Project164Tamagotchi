﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Project164Tamagotchi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        public Tamagotchi pet = new Tamagotchi();// Tamagotchi object that will recieve the name from Form 1
        private Tamagotchi petHome; // proper object for form
        public Tamagotchi PetPlay
        {
            get { return petHome; }
        }
        int sleep;
        string name; //Sharon copy this
        int health = 50;
        int credit = 10;
        int happy;

        

        private void Home_Load(object sender, EventArgs e)
        {
            //code to pass values from the label from this form to the pantry form
            SetValueForText1 = lblPlay.Text;
            SetValueForText2 = lblHealth.Text;

            timerAwake.Start(); //sleep levels deplete from program open
            timerHappiness.Start();
            sleep = 100; 
            lblSleep.Text = Convert.ToString(sleep); 
            lblPlay.Text = Convert.ToString(credit);
            lblHealth.Text = Convert.ToString(health);
            lblName.Text = pet.Character;
            name = pet.Character;

            if(name == "Fiona")
            {
                pictureBox1.Image = Properties.Resources.Fiona_Happy;
            }
            else
            {
                pictureBox1.Image= Properties.Resources.Shrek_Happy;
            }

           
            petHome = ReadDataFromFile(name) as Tamagotchi;
            

        }


        private void btnSleep_Click(object sender, EventArgs e)
        {
            timerSleep.Start();

        }





        private void timerSleep_Tick(object sender, EventArgs e)
        {
           
            sleep += 1;
            lblSleep.Text = Convert.ToString(sleep);
            if (sleep == 100) //When sleep levels are full, pet wakes up
            {
                timerSleep.Stop();
                timerAwake.Start();
                pictureBox1.Image = Properties.Resources.Waking_up;
            }
            if (name == "Fiona" && sleep <100)
            {
                pictureBox1.Image = Properties.Resources.Fiona_Sleeping;

            }
            else if (name == "Shrek" && sleep < 100)
            {
                pictureBox1.Image = Properties.Resources.Shrek_Sleeping;
            }

        }





        private void timerAwake_Tick(object sender, EventArgs e)
        {
            // each tick is 12 seconds and maximum awake time is 4 minutes 
            if (timerSleep.Enabled)
            {
                timerAwake.Stop(); //making sure that these two do not run at the same time

            
            }
            else
            {
                timerAwake.Start();
            }
            sleep -= 2;
            health -= 2;
            lblPlay.Text = Convert.ToString(credit);
            lblHealth.Text = Convert.ToString(health);


            if (sleep == 0)
            {
                timerAwake.Stop();
                MessageBox.Show(pet.Character + " is dead");
                this.Close();
            }
            lblSleep.Text = Convert.ToString(sleep);
        }


        public void WriteDataToFile(string petName, Tamagotchi digipet)
        {
            FileStream outFile = new FileStream(petName + ".ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, digipet);
            outFile.Close();
            MessageBox.Show("Your sata has been saved!");
        }



        public object ReadDataFromFile(string filepath)
        {//deserialize file method 
            object obj = null;
            FileStream infile;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filepath))
            {
                infile = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                obj = bf.Deserialize(infile);
                infile.Close();
            }
            else
            {
                MessageBox.Show("File could not be found");
            }

            return obj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                petHome = new Tamagotchi();
                petHome.Health = health;
                petHome.Credit = credit;
                petHome.Character = lblName.Text;
                petHome.Sleep = sleep;
                WriteDataToFile(name, petHome);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show(" Your data has been saved");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerHappiness_Tick(object sender, EventArgs e)
        {
            happy = Happiness(sleep, credit, health);
            lblHappiness.Text = Convert.ToString(happy) + "%";
            if (happy <=0 && timerSleep.Enabled != true)
            {
                pictureBox1.Image = Properties.Resources.casket;
                MessageBox.Show(name + " is dead. Are you happy now?");
            }
            else if ( happy == 20 && timerSleep.Enabled != true)
            {
                MessageBox.Show("I am about to DIE. HELP ME");
                if (name == "Fiona")
                {
                    pictureBox1.Image = Properties.Resources.Fiona_Angry;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Shrek_Angry;
                }
            }
            else if (happy == 40 && timerSleep.Enabled != true)
            {
               
                if (name == "Fiona")
                {
                    pictureBox1.Image = Properties.Resources.Fiona_Worried;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Shrek_Worried;
                }
            }
            else if (happy == 60 && timerSleep.Enabled != true )
            {
                
                if (name == "Fiona")
                {
                    pictureBox1.Image = Properties.Resources.Fiona_Nervous;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Shrek_Nervous;
                }
            }
            else if (happy == 80 && timerSleep.Enabled != true)
            {
                if (name == "Fiona")
                {
                    pictureBox1.Image = Properties.Resources.fiona_satisdied;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Shrek_Satisfied;
                }
            }
            else if (happy ==100 && timerSleep.Enabled != true)
            {
                
                if (name == "Fiona")
                {
                    pictureBox1.Image = Properties.Resources.Fiona_Happy;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Shrek_Happy;
                }
            }
        }

        public int Happiness(int petSleep, int petCredit, int petHealth)
        {
            int happiness = petCredit + petHealth + petSleep;
            happiness = happiness / 3;

            return happiness;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm myform = new PlayForm();
            myform.ShowDialog();
            credit += myform.PetPlay.Credit;
            
        }

        private void btnPantry_Click(object sender, EventArgs e)
        {
            StorageForm myform = new StorageForm(); 
            myform = new StorageForm();
            myform.petPantry.Character = name;
            credit += Convert.ToInt32(StorageForm.SetValueForText1);
            health += Convert.ToInt32(StorageForm.SetValueForText2);
            myform.ShowDialog();
        }   

        //code to pass values from the label from this form to the pantry form
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //when button is clicked, updated values from the pantry will display the new code and the new credits
            lblPlay.Text = StorageForm.SetValueForText1;
            lblHealth.Text = StorageForm.SetValueForText2;
        }
    }
}
