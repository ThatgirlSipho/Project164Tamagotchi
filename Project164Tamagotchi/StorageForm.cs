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
using System.IO;

namespace Project164Tamagotchi
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        //serialization method to write data of food items to file
        public void WriteDataToFile(string listName, BindingList<Food> foodItems)
        {
            FileStream outFile = new FileStream(listName + ".ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, foodItems);
            outFile.Close();
        }


        //serialization method to read data of food from file
        public void ReadDataFromFile(string listName, BindingList<Food> foodItems)
        {
            try
            {
                FileStream inFile = new FileStream(listName + ".ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                foodItems.Clear();
                var tempList = (BindingList<Food>)bFormatter.Deserialize(inFile);
                foreach (Food myObject in tempList)
                { foodItems.Add(myObject); }
                inFile.Close();
            }
            catch (FileNotFoundException)
            { MessageBox.Show("The data file could not be found"); }
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {
            //display of scores and credits from one form to another
            lblScore.Text = Home.SetValueForText1;
            lblCredits.Text = Home.SetValueForText2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //when the button is clicked, data from the label will be passed to the tamagotchi home form
            SetValueForText1 = lblScore.Text;
            SetValueForText2 = lblCredits.Text;

            //when user closes form, data will be saved onto serialized file
            WriteDataToFile("foodItems", foodItems);
            MessageBox.Show("Your data has been saved");

            //messagebox so that the user clicks on the refresh button from tamagotchi home, in order to see updated code
            MessageBox.Show("Don't forget to refresh to get an update");
            this.Hide();
        }
    }
}
