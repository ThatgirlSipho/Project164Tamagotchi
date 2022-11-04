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
using System.Reflection.Emit;

namespace Project164Tamagotchi
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        //global variables
        public Food foodToUpdate;
        BindingList<Food> foodItems = new BindingList<Food>();

        //code to pass values from this form to the home form
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

            // when form loads, data from serialized file will be uploaded
            ReadDataFromFile("foodItems", foodItems);

            //when the form loads hardcoded food items and cost already added onto dgv
            Food fooditem1 = new Food("Apple", "Fruits and veg", 5);
            foodItems.Add(fooditem1);
            Food fooditem2 = new Food("Pie", "Fats and oils", 10);
            foodItems.Add(fooditem2);
            Food fooditem3 = new Food("Fish", "Protein", 15);
            foodItems.Add(fooditem3);
            Food fooditem4 = new Food("Rice", "Carbohydrates", 20);
            foodItems.Add(fooditem4);
            dgvData.DataSource = foodItems;

            //calculates the credits for pantry
            lblCredits.Text = dgvData.RowCount.ToString();
            int total;
            total = Convert.ToInt32(lblCredits.Text) * 10;
            lblCredits.Text = Convert.ToString(total);

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex;
            //data from the selected row will be displayed onto the editform when it opens 
            selectedRowIndex = dgvData.CurrentCell.RowIndex;
            Food foodToEdit = (Food)dgvData.Rows[selectedRowIndex].DataBoundItem;
            frmEdit myForm = new frmEdit();

            //when the button edit is clicked the edit form opens 
            myForm.foodToUpdate = foodToEdit;
            myForm.ShowDialog();
            foodItems[selectedRowIndex] = myForm.foodToUpdate;

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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //when the button information is clicked a new form opens
            Information newForm = new Information();
            newForm.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            //calculates how much food item is in the food storage for the tamagotchi
            string value;
            int total = 0;
            int count = 0;
            int countFruitsandveg = 0;
            int countFatsAndOils = 0;
            int countProtein = 0;
            int countCarbohydrates = 0;
            for (int i = 0; i < dgvData.Columns.Count; i++)
            {
                for (int j = 0; j < dgvData.Rows.Count - 1; j++)
                {
                    value = Convert.ToString(dgvData[i, j].Value);
                    if (value == "Fruits and veg")
                    {
                        countFruitsandveg += 1;

                    }
                    else if (value == "Fats and oils")
                    {
                        countFatsAndOils += 1;
                    }
                    else if (value == "Protein")
                    {
                        countProtein += 1;
                    }
                    else if (value == "Carbohydrates")
                    {
                        countCarbohydrates += 1;
                    }

                    count++;
                    total = countFruitsandveg + countFatsAndOils + countProtein + countCarbohydrates;

                }
            }

            //displays the amount of food item from datagrid
            MessageBox.Show("Fruits and veg:" + " " + countFruitsandveg + "\n" +
                "Fats and oils:" + " " + countFatsAndOils + "\n" +
                "Protein:" + " " + countProtein + "\n" +
                "Carbohydrates:" + " " + countCarbohydrates + "\n" +
                "Total Food Items:" + " " + total.ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //when the button delete is clicked, the selected row information will be deleted
            int selectedRowIndexex = 0;
            Food foodItemToRemove = foodItems[selectedRowIndexex];
            foodItems.Remove(foodItemToRemove);

            //code to display credits after the user deletes from the pantry library
            lblCredits.Text = dgvData.RowCount.ToString();
            int sum;
            sum = Convert.ToInt32(lblCredits.Text) * 10;
            lblCredits.Text = Convert.ToString(sum);
        }
    }
}
