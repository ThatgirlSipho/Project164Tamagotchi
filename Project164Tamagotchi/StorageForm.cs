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

        //global variables
        public Food foodToUpdate;
        BindingList<Food> foodItems = new BindingList<Food>();

        private void StorageForm_Load(object sender, EventArgs e)
        {
            //when form loads, data from serialized file will be uploaded
            ReadDataFromFile("foodItems", foodItems);

            //when the form loads hardcoded food items and cost already added onto dgv
            Food fooditem1 = new Food("Apple", "Fruits and veg", 10);
            foodItems.Add(fooditem1);
            Food fooditem2 = new Food("Pie", "Fats and oils", 20);
            foodItems.Add(fooditem2);
            Food fooditem3 = new Food("Fish", "Protein", 30);
            foodItems.Add(fooditem3);
            Food fooditem4 = new Food("Rice", "Carbohydrates", 40);
            foodItems.Add(fooditem4);
            dgvData.DataSource = foodItems;

            //calculates the credits for pantry
            lblHealth.Text = dgvData.RowCount.ToString();
            int total;
            total = Convert.ToInt32(lblHealth.Text) * 10;
            lblHealth.Text = Convert.ToString(total);

            //code to add cost for each food type item
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                int ans1 = 5;
                int ans2 = 10;
                int ans3 = 15;
                int ans4 = 20;
                if ("Fruits and veg" == Convert.ToString(row.Cells[dgvData.Columns["Type"].Index].Value))
                {
                    row.Cells[dgvData.Columns["Cost"].Index].Value = ans1;
                }
                else if ("Fats and oils" == Convert.ToString(row.Cells[dgvData.Columns["Type"].Index].Value))
                {
                    row.Cells[dgvData.Columns["Cost"].Index].Value = ans2;
                }
                else if ("Protein" == Convert.ToString(row.Cells[dgvData.Columns["Type"].Index].Value))
                {
                    row.Cells[dgvData.Columns["Cost"].Index].Value = ans3;
                }
                else if ("Carbohydrates" == Convert.ToString(row.Cells[dgvData.Columns["Type"].Index].Value))
                {
                    row.Cells[dgvData.Columns["Cost"].Index].Value = ans4;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //when user closes form, data will be saved onto serialized file
            WriteDataToFile("foodItems", foodItems);
            MessageBox.Show("Your data has been saved");

            //messagebox so that the user clicks on the refresh button from tamagotchi home, in order to see updated code
            MessageBox.Show("Don't forget to refresh to get an update");
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //a button the user clicks before they add an item onto the dgv
            string food, type;
            food = txtName.Text;
            type = cbxType.Text;
            MessageBox.Show("Name:  " + food + "\n" + "Type:  " + type + "\n" + "After you add, cost will be deducted from score and can't be reversed");
        }
    }
}
