/*rolando marin-galvan
 * CST-150
 * 11/06/22
 * Milestone 2
 * This was my own work
 */
using CST_150_Inventory_Project.BusinessLayer;
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
        //decalre variables
        DataTable table = new DataTable();
        int selectedRow;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //assigns columns
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Catagory", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Cost", typeof(decimal));
            dtaInventory.DataSource = table;
            //loads data in grid
            table.Rows.Add("Milk", "Dairy", 7, 6.99M);
            table.Rows.Add("Apple", "Produce", 48, .60M);
            table.Rows.Add("Lays", "Chips", 7, 3.49M);
            table.Rows.Add("Chobani", "Dairy", 10, 5.69M);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //parse the textboxes
            bool successCost = decimal.TryParse(txtCost.Text, out decimal cost);
            bool successQuanity = int.TryParse(txtQuant.Text, out int quanitity);

            //flag
            if (successCost && successQuanity && txtCat.Text.Length > 0 && txtName.Text.Length > 0)
            {
                //Create overloadedobject with ourt textbox values 
                Inventory inventory = new Inventory(txtName.Text, txtCat.Text, quanitity, cost);

                //add in our table with our class with getters
                table.Rows.Add(inventory.GetInventoryItem(), inventory.getCatagory(), inventory.GetQuantity(), inventory.GetCost());

            }
            else
            {
                //errors messgae
                MessageBox.Show("Please try again :)");
            }
        }

        private void dtaInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when a cell has been clicked it will assign the values in texboxes
            selectedRow = e.RowIndex;
            DataGridViewRow row = dtaInventory.Rows[selectedRow];
            txtName.Text = row.Cells[0].Value.ToString();
            txtCat.Text = row.Cells[1].Value.ToString();
            txtQuant.Text = row.Cells[2].Value.ToString();
            txtCost.Text = row.Cells[3].Value.ToString();

            lblResults.Text = row.Cells[2].Value.ToString();

        }


        private void btnInc_Click(object sender, EventArgs e)
        {
            //increments the qty
            int quant = int.Parse(txtQuant.Text);

            Inventory inventory = new Inventory(quant);
            inventory.SetQty(quant);
            inventory.IncQty();
            quant = inventory.GetQuantity();
            lblResults.Text = String.Format("{0}", quant);
            txtQuant.Text = quant.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //when btnedit has been clicked it will update wiht a new datarow
            DataGridViewRow newDatrow = dtaInventory.Rows[selectedRow];
            newDatrow.Cells[0].Value = txtName.Text;
            newDatrow.Cells[1].Value = txtCat.Text;
            newDatrow.Cells[2].Value = txtQuant.Text;
            newDatrow.Cells[3].Value = txtCost.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //deletes the row index that has been selected
            int rowIndex = dtaInventory.CurrentCell.RowIndex;
            dtaInventory.Rows.RemoveAt(rowIndex);
        }
        private void btnDec_Click(object sender, EventArgs e)
        {
            //decriments the quantity
            int quant = int.Parse(txtQuant.Text);
            Inventory inventory = new Inventory(quant);
            inventory.SetQty(quant);
            inventory.DecQuty();
            quant = inventory.GetQuantity();
            lblResults.Text = String.Format("{0}", quant);
            txtQuant.Text = quant.ToString();
        }

       
    }
}
