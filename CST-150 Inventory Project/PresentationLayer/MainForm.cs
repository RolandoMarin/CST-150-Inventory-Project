using CST_150_Inventory_Project.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Inventory_Project.Resources
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("catagory", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Cost", typeof(int));

            dtaInventory.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool successCost = int.TryParse(txtCost.Text, out int cost);
            bool successQuanity = int.TryParse(txtQuant.Text, out int quanitity);


            if (successCost && successQuanity && txtCat.Text.Length >0 && txtName.Text.Length > 0)
            {
                var obj = new List<Inventory>();
                for(int i =0; i< obj.Count; i++)
                {

                    obj.Add(new Inventory(txtName.Text, cost, quanitity, txtCat.Text));

                }


            }
            else
            {
                MessageBox.Show("Please try again :)");
            }
        }

    }
}
