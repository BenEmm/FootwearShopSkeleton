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
            String TestData = "4 Items Shipped";

            //Assign the data to the property
            AnOrder.Quantity = TestData;

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


    }


}

