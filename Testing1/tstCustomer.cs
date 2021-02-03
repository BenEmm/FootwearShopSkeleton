using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            Int32 TestData = 32452;

            // Assign the data to the property
            ACustomer.CustomerID = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            String TestData = "Name";

            // Assign the data to the property
            ACustomer.FirstName = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerSurnameNameOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            String TestData = "Name";

            // Assign the data to the property
            ACustomer.Surname = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            String TestData = "JohnSmith@hotmail.com";

            // Assign the data to the property
            ACustomer.Email = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void IsCustomerOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            Boolean TestData = true;

            // Assign the data to the property
            ACustomer.IsCustomer = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.IsCustomer, TestData);
        }

        [TestMethod]
        public void TotalSpentOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            decimal TestData = 2.1M;

            // Assign the data to the property
            ACustomer.TotalSpent = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.TotalSpent, TestData);
        }

        [TestMethod]
        public void AddressNoProperty()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            Int32 TestData = 1;

            // Assign the data to the property
            ACustomer.AddressNo = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.AddressNo, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            String TestData = "Some Street";

            // Assign the data to the property
            ACustomer.Address = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            String TestData = "LE4 0QE";

            // Assign the data to the property
            ACustomer.PostCode = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void AccountCreationDateOK()
        {
            // Create an insance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            // Assign the data to the property
            ACustomer.AccountCreationDate = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(ACustomer.AccountCreationDate, TestData);
        }


    }
}
