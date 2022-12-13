using CST_150_Inventory_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Inventory_Project.DataAccessLayer
{
    public class InvDataAccessLayer
    {
        /// <summary>
        /// Method that hardcodes Inventory
        /// </summary>
        /// <param name="myInventory"></param>
        /// <returns></returns>
        public List<InventoryManager> GetInventory(List<InventoryManager> myInventory)
        {
            // Create our inventory List of Objects
            myInventory.Add(new InventoryManager("Milk","Dairy",5,4.99M));
            myInventory.Add(new InventoryManager("Bread","Produce",19,2.99M));
            myInventory.Add(new InventoryManager("Orange Juice", "Juice", 4, 7.99M));
            myInventory.Add(new InventoryManager("Apple", "Produce", 44, .99M));
            myInventory.Add(new InventoryManager("Hershey's", "Candy", 12, 2.79M));
            myInventory.Add(new InventoryManager("Chai", "Beverage", 39, 18.99M));
            myInventory.Add(new InventoryManager("Coffee", "Beverage", 12, 7.89M));
            myInventory.Add(new InventoryManager("Frozen Pizza", "Frozen Foods", 3, 16.99M));
            myInventory.Add(new InventoryManager("Salad", "Produce", 44, 5.89M));
            myInventory.Add(new InventoryManager("Rice", "Grains", 22, 7.99M));

            return myInventory;
        }
    }
}
