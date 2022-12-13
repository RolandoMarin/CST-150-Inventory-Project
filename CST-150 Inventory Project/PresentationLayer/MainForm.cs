/*rolando marin-galvan
 * CST-150
 * 12/11/22
 * Milestone 4
 * This was my own work
 */
using CST_150_Inventory_Project.BusinessLayer;
using CST_150_Inventory_Project.Models;
using CST_150_Inventory_Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Inventory_Project.Resources
{
    public partial class MainForm : Form
    {
       /// <summary>
       /// Creates object of myInventory when program is run.
       /// </summary>
        List<InventoryManager> myInventory = new List<InventoryManager>();
        int selectedRow;
        /// <summary>
        /// Default Cunstructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When Main Form loads We Get invenotry Items from Data Access Layer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        
            //loads data in grid
            Inventory inventory = new Inventory();
            inventory.GetInventory(myInventory);
            dtaInventory.DataSource = myInventory;
            //assigns columns
            GVInvHeader();

        }
        /// <summary>
        /// Method that changes the column within the GridView
        /// </summary>
        private void GVInvHeader()
        {
            //Lets iterate through the header one column at a time.
            //and chnage the header anmes
            //Loop over the columns collection fromm the data grid view
            foreach (DataGridViewColumn column in dtaInventory.Columns)
            {
                //Switch statement to change header text
                //Column index starts at 0 - and count
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Product Name";
                        break;
                    case 1:
                        column.HeaderText = "Catagory";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        break;
                        case 3:
                        column.HeaderText = "Cost";
                        break;
                    default:
                        column.HeaderText = "";
                        break;

                }
            }
        }
        /// <summary>
        /// btn event handler that adds an item with textbox inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //parse the textboxes
            bool successCost = decimal.TryParse(txtCost.Text, out decimal cost);
            bool successQuanity = int.TryParse(txtQuant.Text, out int quanitity);

            //flag
            if (successCost && successQuanity && txtCat.Text.Length > 0 && txtName.Text.Length > 0)
            {
                //Create overloadedobject with ourt textbox values 
                myInventory.Add(new InventoryManager(txtName.Text, txtCat.Text, quanitity, cost));

                Inventory businesslayer = new Inventory();

                dtaInventory.DataSource = null;
                dtaInventory.DataSource = myInventory;

            }
            else
            {
                //errors messgae
                MessageBox.Show("Please try again :)");
            }
        }
        /// <summary>
        /// gridview cellclick event handler that manages the selected cell 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtaInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when a cell has been clicked it will assign the values in texboxes

            //throws a out of bounds error when you select column
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dtaInventory.Rows[selectedRow];
                txtName.Text = dtaInventory.Rows[selectedRow].Cells[0].Value.ToString();
                txtCat.Text = dtaInventory.Rows[selectedRow].Cells[1].Value.ToString();
                txtQuant.Text = dtaInventory.Rows[selectedRow].Cells[2].Value.ToString();
                txtCost.Text = dtaInventory.Rows[selectedRow].Cells[3].Value.ToString();
            }
            else
            {
                resetValues();
            }

        }
        /// <summary>
        /// button edit event handler that edits inventory with textbox inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //when btnedit has been clicked it will update wiht a new datarow
            DataGridViewRow newDatrow = dtaInventory.Rows[selectedRow];
            newDatrow.Cells[0].Value = txtName.Text;
            newDatrow.Cells[1].Value = txtCat.Text;
            newDatrow.Cells[2].Value = txtQuant.Text;
            newDatrow.Cells[3].Value = txtCost.Text;
        }
        /// <summary>
        /// btn delete event handler that deletes the slected column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow > 0)
            {
                string message = "Do you want to Delete this Item?";
                string caption = "Delete?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    if (dtaInventory.SelectedRows.Count > 0)
                    {
                        // Define the current row highlighted in the Data GridView
                        DataGridViewRow currentRow = dtaInventory.SelectedRows[0];

                        // Casting
                        string type = (string)currentRow.Cells[0].Value;
                        // Now we need to iterate through the List
                        Inventory businessLayer = new Inventory();

                        // Inc the inventory
                        myInventory = businessLayer.DeleteItem(myInventory, type);

                        // Clear out the Data Grid View
                        dtaInventory.DataSource = null;
                        // Bind the new data to the DateGridView
                        dtaInventory.DataSource = myInventory;

                    }
                }
                else
                {
                    // Do something  
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
          
        }
        /// <summary>
        /// btn search event handler that opens a new form that displyys inventory and searches inventory with 2 criteries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm formSecond = new SearchForm(myInventory);
            formSecond.ShowDialog();
         
        }
        /// <summary>
        /// Method that resets the values of textboxes
        /// </summary>
        private void resetValues()
        {
            txtCat.Text = "";
            txtCost.Text = "";
            txtName.Text = "";
            txtQuant.Text = "";
            selectedRow = 0;
        }
        /// <summary>
        /// btn reset event handler that reset textbox values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetValues();
        }
    }
}
