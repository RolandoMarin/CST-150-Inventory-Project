/*rolando marin-galvan
 * CST-150
 * 11/06/22
 * Milestone 2
 * This was my own work
 */
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
    public class Inventory
    {
        //properties
        public string InventoryItem { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantitiy { get; set; }
        public string Catagory { get; set; }

        //overloaded cunstrucotr
        public Inventory(int _quantity)
        {
            Quantitiy = _quantity;
        }
        //overloaded cunstrucotr
        public Inventory(string _inventoryItem, string _catagory, int _quantity,decimal _productCost)
        {
            InventoryItem = _inventoryItem;
            ProductCost = _productCost;
            Quantitiy = _quantity;
            Catagory = _catagory;
        }
        //getters and setters
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
        //increment the quantitiy
        public void IncQty()
        {
            Quantitiy ++;
        }
        //decriment the quanitity
        public void DecQuty()
        {
            Quantitiy--;
        }
        public void SetQty(int _quantity)
        {
            Quantitiy = _quantity;
        }
    }
}
