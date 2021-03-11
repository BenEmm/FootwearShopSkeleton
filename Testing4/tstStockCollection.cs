using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockID = 1;
            TestItem.StockDescription = "converse";
            TestItem.StockColour = "red";
            TestItem.StockAmount = 10;
            TestItem.StockPrice = 10.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);


        }
        
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object 
            TestStock.Available = true;
            TestStock.StockID = 1;
            TestStock.StockDescription = "converse";
            TestStock.StockColour = "red";
            TestStock.StockAmount = 10;
            TestStock.StockPrice = 10.00M;
            TestStock.DateOrdered = DateTime.Now.Date;
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockID = 1;
            TestItem.StockDescription = "converse";
            TestItem.StockColour = "red";
            TestItem.StockAmount = 10;
            TestItem.StockPrice = 10.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
    }

    
}
