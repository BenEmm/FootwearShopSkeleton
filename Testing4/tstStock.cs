using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        
        public void InstanceOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Test to see if it has been created
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockIDOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property 
            Int32 TestData = 456;

            //Assign the data to the property
            AStock.StockID = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.StockID, TestData);

        }

        [TestMethod]
        public void StockDescriptionOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            String TestData = "Black and White Converse";

            //Assign the data to the property
            AStock.StockDescription = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.StockDescription, TestData);
        }

        [TestMethod]
        public void StockColourOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            String TestData = "Black and White";

            //Assign the data to the property
            AStock.StockColour = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.StockColour, TestData);
        }

        [TestMethod]
        public void StockAmountOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            Int32 TestData = 340;

            //Assign the data to the property
            AStock.StockAmount = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.StockAmount, TestData);
        }

        [TestMethod]
        public void StockPriceOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            decimal TestData = 20.00M;

            //Assign the data to the property
            AStock.StockPrice = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.StockPrice, TestData);
        }

        [TestMethod]
        public void AvailableOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            Boolean TestData = true;

            //Assign the data to the property
            AStock.Available = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void DateOrderedOK()
        {
            //Create an instance of a class we want to create
            clsStock AStock = new clsStock();

            //Create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //Assign the data to the property
            AStock.DateOrdered = TestData;

            //Test to see if the two values are the same
            Assert.AreEqual(AStock.DateOrdered, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNotFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StockID = 21;
            //Invoke the method
            Found = AStock.Find(StockID);
            //Check the Stock ID
            if (AStock.StockID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if(AStock.DateOrdered != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockDescriptionFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if (AStock.StockDescription != "Converse")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockColourFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if (AStock.StockColour != "Black and White")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAmountFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if (AStock.StockAmount != 200)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockPriceFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if (AStock.StockPrice != 39.99M)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock AStock = new clsStock();
            //Boolean variable that stores the result of the search
            Boolean Found = false;
            //Boolean variable to record whether the data is ok (assumed it is)
            Boolean OK = true;
            //Create some test data to use with the method 
            Int32 StockID = 21;
            Found = AStock.Find(StockID);
            if (AStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        }
}
