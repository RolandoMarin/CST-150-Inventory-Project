using Microsoft.VisualStudio.TestTools.UnitTesting;
using CST_150_Inventory_Project.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CST_150_Inventory_Project.Models;

namespace CST_150_Inventory_Project.BusinessLayer.Tests
{
    [TestClass()]
    public class InventoryManagerTests
    {
        InventoryManager inventoryManager = new InventoryManager();
        [TestMethod()]
        public void AddNewItemTest()
        {
            var ItemOne = new InventoryManager();

            Assert.AreEqual(21, ItemOne);
     
        }
    }
}