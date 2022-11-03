using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CST_150_Inventory_Project.BusinessLayer
{
    internal class Inventory 
    {
        public string InventoryItem { get; set; }
        public int ProductCost { get; set; }
        //public bool InStock { get; set; }
        public int Quantitiy { get; set; }
        public string Catagory { get; set; }

        public Inventory(string _inventoryItem, int _productCost ,int _quantity,string _catagory)
        {
            InventoryItem = _inventoryItem;
            ProductCost = _productCost;
            Quantitiy = _quantity;
            Catagory = _catagory;
        }
    }
}
