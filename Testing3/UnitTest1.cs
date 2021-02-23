using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
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
            Int32 TestData = 4 ;

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
            String TestData = "Obi Wan Kenobi";

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
            String TestData = "obiwankenobi@gmail.com";

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
            if (AnOrder.OrderNumber != 21)
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
            if (AnOrder.CustomerName != "Jack James")
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
            if (AnOrder.Email != "TestEmail@Test.com")
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
            if (AnOrder.TrackingNumber != "XXXXXXX")
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
            if (AnOrder.TotalPrice != 50)
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
            if (AnOrder.ShippingDate != Convert.ToDateTime("16/09/2021"))
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
            if (AnOrder.Quantity != 10 )
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }







    }


}

