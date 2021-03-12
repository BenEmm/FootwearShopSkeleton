using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        //Good test data
        //Create some test data to use with the valid method 
        string Stockdescription = "Converse";
        string Stockcolour = "Red";
        string Stockamount = "200";
        string Stockprice = "19.99";
        string Dateordered = DateTime.Now.Date.ToString();

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
            Int32 StockID = 1020;
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
            Int32 StockID = 1020;
            //Invoke the method
            Found = AStock.Find(StockID);
            //Check the Stock ID
            if (AStock.StockID != 1020)
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
            Int32 StockID = 1020;
            Found = AStock.Find(StockID);
            if (AStock.DateOrdered != Convert.ToDateTime("12/03/2021"))
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
            Int32 StockID = 1020;
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
            Int32 StockID = 1020;
            Found = AStock.Find(StockID);
            if (AStock.StockColour != "Red")
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
            Int32 StockID = 1020;
            Found = AStock.Find(StockID);
            if (AStock.StockAmount != 300)
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
            Int32 StockID = 1020;
            Found = AStock.Find(StockID);
            if (AStock.StockPrice != 20.00M)
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
            Int32 StockID = 1020;
            Found = AStock.Find(StockID);
            if (AStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockdescription = ""; //this should trigger an error
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMin()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //create some test data to pass to the method
            string Stockdescription = "a"; //this should be ok
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "";
            Stockdescription = Stockdescription.PadRight(99, 'a'); //this should pass
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMax()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "";
            Stockdescription = Stockdescription.PadRight(100, 'a'); //this should pass
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMid()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "";
            Stockdescription = Stockdescription.PadRight(50, 'a'); //this should pass
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxPlusOne()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "";
            Stockdescription = Stockdescription.PadRight(101, 'a'); //this should fail
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create some test data to pass to the method
            string Stockdescription = "";
            Stockdescription = Stockdescription.PadRight(500, 'a'); //this should fail
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "r"; //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockColoueMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "re"; //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "";
            Stockcolour = Stockcolour.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "";
            Stockcolour = Stockcolour.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "";
            Stockcolour = Stockcolour.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "";
            Stockcolour = Stockcolour.PadRight(51, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store the error message
            String Error = "";
            //create some test data to pass to the method 
            string Stockcolour = "";
            Stockcolour = Stockcolour.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
           Int32 stockAmount = -10000000;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = -1;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 0;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 1;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 999999;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 100000;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 500000;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 10000001;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountExtremeMax()
        {

            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            Int32 stockAmount = 999999999;
            //change double to string
            string Stockamount = stockAmount.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = -1000000.00;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = -0.01;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMin()
        {

            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 0.00;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 0.01;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 99999999.99;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 100000000.00;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 50000000.00;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double stockPrice = 100000000.01;
            //change double to string
            string Stockprice = stockPrice.ToString();
            //invoke the method
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Dateordered = TestDate.ToString();
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Dateordered = TestDate.ToString();
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Dateordered = TestDate.ToString();
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the day is plus one day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Dateordered = TestDate.ToString();
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the day is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Dateordered = TestDate.ToString();
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedInvalidData()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //set the dateOrdered value to a non date value
            string Dateordered = "this is not a date";
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockPriceInvalidData()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //set the stockprice value to a non price value
            string Dateordered = "aaa";
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountInvalidData()
        {
            //Create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //String variable to store the error message 
            String Error = "";
            //set the stockamount value to a non amount value
            string Dateordered = "aaa";
            //invoke the method 
            Error = AStock.Valid(Stockdescription, Stockcolour, Stockamount, Stockprice, Dateordered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
            
    }


    }

