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
            Int32 TestData = 8;

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
            String TestData = "Jeff";

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
            String TestData = "Jefferson";

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
            String TestData = "Jeff@Jeff.com";

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
            Int32 TestData = 12;

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
            String TestData = "Jeff Street";

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
            String TestData = "LE40RT";

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

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the results of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.CustomerID != 8)
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.AccountCreationDate != Convert.ToDateTime("05/02/2021"))
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.FirstName != "Jeff")
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.Surname != "Jefferson")
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.AddressNo != 12)
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.Address != "Jeff Street")
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.PostCode != "LE40RT")
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.Email != "Jeff@Jeff.com")
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsCustomerFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.IsCustomer != true)
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalSpentFound()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 8;
            // Invoke the method
            Found = ACustomer.Find(CustomerID);
            // Check the address no
            if (ACustomer.TotalSpent != 4000)
            {
                OK = false;
            }
            // Test to see if that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}
