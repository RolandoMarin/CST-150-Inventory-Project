using CST_150_Inventory_Project.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Inventory_Project.Models
{
    public class InventoryManager
    {
        public string InventoryItem { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantitiy { get; set; }
        public string Catagory { get; set; }

        public Inventory[] GetInventory(Inventory[] invArray)
        {
            invArray[0] = new Inventory("Bread", "Grain", 22, 8.99M); 
            invArray[1] = new Inventory("Eggs", "Produce", 2, 4.39M);
            invArray[2] = new Inventory("Milk", "Dairy", 3, 4.09M);
            invArray[3] = new Inventory("Candy", "Sweets", 55, 2.99M);
            invArray[4] = new Inventory(" Orange Juice", "Juice", 3, 5.99M);
            return invArray;
        }


    }
}
