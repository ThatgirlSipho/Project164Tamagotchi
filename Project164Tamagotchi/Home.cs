using System;
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



        public Tamagotchi pet = new Tamagotchi(); // Tamagotchi object that can be accessed in all forms
        int sleep;
        string name; //Sharon copy this
        int health = 50;
        int credit = 100;
        int happy;

        

        private void Home_Load(object sender, EventArgs e)
        {

            timerAwake.Start(); //sleep levels deplete from program open
            timerHappiness.Start();
            sleep = 100; //Sleep levels start high
            lblSleep.Text = Convert.ToString(sleep); //display the sleep levels
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

           
            pet = ReadDataFromFile(name) as Tamagotchi;
            
           

        }


        private void btnSleep_Click(object sender, EventArgs e)
        {
            timerSleep.Start();
        }





        private void timerSleep_Tick(object sender, EventArgs e)
        {
            //each tick is 2 seconds long and maximum sleep is 20 seconds
            sleep += 1;
            lblSleep.Text = Convert.ToString(sleep);
            if (sleep == 100) //When sleep levels are full, pet wakes up
            {
                timerSleep.Stop();
                timerAwake.Start();
            }
            if (name == "Fiona")
            {
                pictureBox1.Image = Properties.Resources.Fiona_Sleeping;

            }
            else
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

                pet.Health = health;
                pet.Credit = credit;
                pet.Character = lblName.Text;
                pet.Sleep = sleep;
                WriteDataToFile(name, pet);

            }
            catch (Exception)
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
                MessageBox.Show("I am getting worried. Help should come anytime soon");
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
            this.Hide();
        }

        private void btnPantry_Click(object sender, EventArgs e)
        {
            StorageForm myform = new StorageForm(); 
            myform = new StorageForm();
            this.Hide();
        }
    }
}
