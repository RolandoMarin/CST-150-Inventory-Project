/*rolando marin-galvan
 * CST-150
 * 12/11/22
 * Milestone 4
 * This was my own work
 */
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
        //Properties
        public string InventoryItem { get; set; }
        public string Catagory { get; set; }
        public int Quantitiy { get; set; }
        public decimal ProductCost { get; set; }


        /// <summary>
        /// Overloaded Cunstructor
        /// </summary>
        /// <param name="_inventoryItem"></param>
        /// <param name="_catagory"></param>
        /// <param name="_quantity"></param>
        /// <param name="_productCost"></param>
        public InventoryManager(string _inventoryItem, string _catagory, int _quantity, decimal _productCost)
        {
            InventoryItem = _inventoryItem;
            ProductCost = _productCost;
            Quantitiy = _quantity;
            Catagory = _catagory;
        }
  
    }
}
