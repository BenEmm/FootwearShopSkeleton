using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        // Good test data
        // Create some test data to pass to the method 
        String CustomerName = "Rick Sanchez";
        String OrderNumber = "012345";
        String TrackingNumber = "ABC123";
        String Email = "Rick@Sanchez.com";
        String Quantity = "7";
        String ShippingDate = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance of the class
            clsOrder AnOrder = new clsOrder();
            //Tests to make sure the class exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderNumberOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            Int32 TestData = 25851168;

            //Assign the data to the property
            AnOrder.OrderNumber = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.OrderNumber, TestData);
        }


        [TestMethod]
        public void TrackingNumberOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            String TestData = "25TF7J39";

            //Assign the data to the property
            AnOrder.TrackingNumber = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.TrackingNumber, TestData);
        }


        [TestMethod]
        public void QuantityOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            Int32 TestData = 4;

            //Assign the data to the property
            AnOrder.Quantity = Convert.ToInt32(TestData);

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void ShippedOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            Boolean TestData = true;

            //Assign the data to the property
            AnOrder.Shipped = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.Shipped, TestData);
        }




        [TestMethod]
        public void ShippingDateOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //Assign the data to the property
            AnOrder.ShippingDate = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.ShippingDate, TestData);
        }




        [TestMethod]
        public void CustomerNameOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            String TestData = "Rick Sanchez";

            //Assign the data to the property
            AnOrder.CustomerName = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }




        [TestMethod]
        public void EmailOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            String TestData = "Rick@Sanchez.com";

            //Assign the data to the property
            AnOrder.Email = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.Email, TestData);
        }


        [TestMethod]
        public void TotalPriceOK()
        {
            //Creates an Instance of the class needed
            clsOrder AnOrder = new clsOrder();

            //Creates test Data to assign to the property
            decimal TestData = 25.00M;

            //Assign the data to the property
            AnOrder.TotalPrice = TestData;

            //Test to see if both values are equal
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {

            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderNumber = 21;

            Found = AnOrder.Find(OrderNumber);

            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderNoFound()
        {
            //Create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of new search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //Create test data to use in method
            Int32 OrderNumber = 21;
            //Test Method
            Found = AnOrder.Find(OrderNumber);
            //Check the order no 
            if (AnOrder.OrderNumber != 258694)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.CustomerName != "Rick Sanchez")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.Email != "Rick@Sanchez.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrackingNumberFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.TrackingNumber != "25TF7J39")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.TotalPrice != 4000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.Shipped != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.ShippingDate != Convert.ToDateTime("03/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNumber);
            //check the property
            if (AnOrder.Quantity != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance if the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNumber = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void ShippingDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ShippingDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, OrderDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, OrderDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, OrderDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerName = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            //invoke the method
            Error = AOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TrackingNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TrackingNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "";
            TrackingNumber = TrackingNumber.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaa"; //this should be fail
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TrackingNumber = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNumber, CustomerName, Email, Quantity, ShippingDate, TrackingNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

