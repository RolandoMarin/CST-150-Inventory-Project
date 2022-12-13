using CST_150_Inventory_Project.BusinessLayer;
using CST_150_Inventory_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Inventory_Project.PresentationLayer
{
    public partial class SearchForm : Form
    {
        List<InventoryManager> mySearch = new List<InventoryManager>();
        List<InventoryManager> myInventory = new List<InventoryManager>();
        public SearchForm()
        {
            InitializeComponent();
        }
        public SearchForm(List<InventoryManager> arrayInventory)
        {
            InitializeComponent();
            dtaInventory.DataSource = arrayInventory;
            myInventory = arrayInventory;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            string searchForName = txtSearchName.Text;
            string SearchForCat = txtSearchCatagory.Text;

            //verify is mysearch is clear before adding to the list
            mySearch.Clear();
            //simce this is logic we need to do this in the business layer
            Inventory businesslayer = new Inventory();
            mySearch = businesslayer.SearchItem(myInventory, mySearch, searchForName, SearchForCat);
            //reset the datasource
            dtaInventory.DataSource = null;
            //rebind the data
            dtaInventory.DataSource = mySearch;
        }
    }
}
