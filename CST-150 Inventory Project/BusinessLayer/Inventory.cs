/*rolando marin-galvan
 * CST-150
 * 12/11/22
 * Milestone 4
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
using CST_150_Inventory_Project.Models;
using CST_150_Inventory_Project.DataAccessLayer;

namespace CST_150_Inventory_Project.BusinessLayer
{
    public class Inventory
    { 
        /// <summary>
        /// Default cunstructor
        /// </summary>
       public Inventory()
        {
           
        }
        /// <summary>
        /// Get Inventory method that comes from Model
        /// </summary>
        /// <param name="myInventory"></param>
        /// <returns></returns>
        public List<InventoryManager> GetInventory(List<InventoryManager> myInventory)
        {
            InvDataAccessLayer getInventory = new InvDataAccessLayer();
            // Just return the received List back to presentation
            // layer
            return getInventory.GetInventory(myInventory);
        }

        /// <summary>
        /// Delete the Inventory row for the Hightligted Row
        /// and return the new inventory List
        /// </summary>
        /// <param name="myInventory"></param>
        /// <param name="currentRow"></param>
        /// <param name="rabbitType"></param>
        /// <returns></returns>
        public List<InventoryManager> DeleteItem(List<InventoryManager> myInventory, string type)
        {
            // Declare and Initialize
            int row = 0;

            // Iterate through the list and find the highlighted row
            foreach (InventoryManager item in myInventory)
            {
                // Find the highlighted row
                if (item.InventoryItem == type)
                {
                    // Delete the item
                    myInventory.RemoveAt(row);

                    return myInventory;
                }
                // If we did not find the bunny to delete - inc counter
                row++;
            }
            // if the tryparse had a problem return the original list
            return myInventory;
        }

        /// <summary>
        /// Method that Iterates through the list and Searches item given criteria
        /// </summary>
        /// <param name="myInventory"></param>
        /// <param name="mySearch"></param>
        /// <param name="inventoryItem"></param>
        /// <param name="catagory"></param>
        /// <returns></returns>
        public List<InventoryManager> SearchItem(List<InventoryManager> myInventory, List<InventoryManager> mySearch, string inventoryItem, string catagory)
        {
            // Iterate through the list and find the highlighted row
            foreach (InventoryManager item in myInventory)
            {
                // Find the highlighted row
                if (item.InventoryItem.ToLower().Contains(inventoryItem.ToLower()) || item.Catagory.ToLower().Contains(catagory.ToLower()))
                {
                    // Add item to search list
                    mySearch.Add(item);
                }
            }
            // Return the search list
            return mySearch;
        }
    }
}
