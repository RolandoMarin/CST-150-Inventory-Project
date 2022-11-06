using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using CST_150_Inventory_Project.Resources;

namespace CST_150_Inventory_Project.BusinessLayer
{
    internal class Inventory
    {
        public string InventoryItem { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantitiy { get; set; }
        public string Catagory { get; set; }

        public Inventory()
        { 

        }
        public Inventory(string _inventoryItem, string _catagory, int _quantity,decimal _productCost)
        {
            InventoryItem = _inventoryItem;
            ProductCost = _productCost;
            Quantitiy = _quantity;
            Catagory = _catagory;
        }
        public string GetInventoryItem(){
            return InventoryItem;
        }
        public string getCatagory()
        {
            return Catagory;
        }
        public int GetQuantity()
        {
            return Quantitiy;
        }
        public decimal GetCost()
        {
            return ProductCost;
        }
    }
}
