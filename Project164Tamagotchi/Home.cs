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

namespace Project164Tamagotchi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        public Tamagotchi pet = new Tamagotchi(); // Tamagotchi object that can be accessed in all forms
        int sleep = 0;




        private void Home_Load(object sender, EventArgs e)
        {

        }






        private void btnSleep_Click(object sender, EventArgs e)
        {
            timerSleep.Start();
        }





        private void timerSleep_Tick(object sender, EventArgs e)
        {
            //each tick is 2 seconds long and maximum sleep is 20 seconds
            sleep += 10;
            lblSleep.Text = Convert.ToString(sleep);
            if (sleep == 100) //When sleep levels are full, pet wakes up
            {
                timerSleep.Stop();
                timerAwake.Start();
            }
            // labelname.Text = pet.Character;
        }





        private void timerAwake_Tick(object sender, EventArgs e)
        {
            // each tick is 12 seconds and maximum awake time is 2 minutes 
            if (timerSleep.Enabled)
            {
                timerAwake.Stop(); //making sure that these two do not run at the same time
            }
            else
            {
                timerAwake.Start();
            }
            sleep -= 10;
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
                MessageBox.Show("File could not tbe found");
            }

            return obj;
        }




    }
}
