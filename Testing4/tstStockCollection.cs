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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Available = true;
            TestItem.StockID = 1;
            TestItem.StockDescription = "Converse";
            TestItem.StockColour = "Red";
            TestItem.StockAmount = 300;
            TestItem.StockPrice = 20.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //set this stock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Available = true;
            TestItem.StockID = 1;
            TestItem.StockDescription = "Converse";
            TestItem.StockColour = "Red";
            TestItem.StockAmount = 300;
            TestItem.StockPrice = 20.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //set this stock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //modify the test data
            TestItem.Available = false;
            TestItem.StockID = 3;
            TestItem.StockDescription = "AirMax";
            TestItem.StockColour = "Yellow";
            TestItem.StockAmount = 15;
            TestItem.StockPrice = 40.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record 
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see thisAddress matches testdata
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Available = true;
            TestItem.StockID = 1;
            TestItem.StockDescription = "Converse";
            TestItem.StockColour = "Red";
            TestItem.StockAmount = 300;
            TestItem.StockPrice = 20.00M;
            TestItem.DateOrdered = DateTime.Now.Date;
            //set this stock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
    }

    
}
