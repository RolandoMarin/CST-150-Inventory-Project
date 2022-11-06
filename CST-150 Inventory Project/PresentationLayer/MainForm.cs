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
        DataTable table = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Catagory", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Cos,", typeof(decimal));
            dtaInventory.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool successCost = decimal.TryParse(txtCost.Text, out decimal cost);
            bool successQuanity = int.TryParse(txtQuant.Text, out int quanitity);


            if (successCost && successQuanity && txtCat.Text.Length >0 && txtName.Text.Length > 0)
            {

                Inventory inventory = new Inventory(txtName.Text, txtCat.Text, quanitity,cost );
   
                table.Rows.Add(inventory.getCatagory(),inventory.getCatagory(),inventory.GetQuantity(),inventory.GetCost());

            }
            else
            {
                MessageBox.Show("Please try again :)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dtaInventory.CurrentCell.RowIndex;
            dtaInventory.Rows.RemoveAt(rowIndex);
        }
    }
}
