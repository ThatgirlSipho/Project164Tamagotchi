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
        public Form1()
        {
            InitializeComponent();
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
    }
}
