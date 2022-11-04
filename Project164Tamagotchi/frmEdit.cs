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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }
        public Food foodToUpdate;
        private void frmEdit_Load(object sender, EventArgs e)
        {
            //when the form opens, all information from selected index will be shown
            txtName.Text = foodToUpdate.Name;
            cbxType.Text = foodToUpdate.Type;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            //when the button edit is clicked, all items edited will be added onto the dgv
            foodToUpdate.Name = txtName.Text;
            foodToUpdate.Type = cbxType.Text;

            this.Close();
        }
    }
}
