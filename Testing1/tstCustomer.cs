using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        // Good test data
        // Create some test data to pass to the method 
        String First_Name = "Jeff";
        String Surname = "Jefferson";
        String AddressNo = "12";
        String Address = "Jeff Street";
        String Postcode = "LE40RT";
        String Email = "Jeff@Jeff.com";
        String Account_Creation_Date = DateTime.Now.Date.ToString();
    

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

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message 
            String Error = "";
            // Create some test data to pass to the method
            string AddressNo = ""; // this should trigger an error
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the resut is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMin()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string AddressNo = "a"; // This should be okay
            // invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMinPlusOne()
        {
            // Create an instancce of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string AddressNo = "aa"; // This should be okay
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressNo = "aaaaa"; //this should be ok
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressNo = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message 
            String Error = "";
            // Create some test data to pass to the method
            string AddressNo = "aaaaaaa"; // This should fail
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoExtremeMax()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string AddressNo = "";
            AddressNo = AddressNo.PadRight(500, 'a'); // This should fail
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateExtremeMin()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to todays date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            // Convert the date variable to a string variable
            string Account_Creation_Date = TestDate.ToString();
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Account_Creation_Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Account_Creation_Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Account_Creation_Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Account_Creation_Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateInvalidData()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Set the DateAdded to a non date value
            string Account_Creation_Date = "this is not a date!";
            // Invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string Postcode = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "a";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aa";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Postcode = "aaaaaaaa";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Postcode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void AddressMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string Address = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void AddressMin()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass
            
            string Address = "a";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void AddressMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Address = "aa";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(249, 'a');
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(250, 'a');
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void AddressMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string Address = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void AddressMid()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Address = "";

            Address = Address.PadRight(125, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstNameMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string First_Name = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string First_Name = "a";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstNameMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string First_Name = "aa";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void FirstNameMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string First_Name = "";

            First_Name = First_Name.PadRight(29, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string First_Name = "";
            First_Name = First_Name.PadRight(30, 'a');
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstNameMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this shold fail

            string First_Name = "";

            First_Name = First_Name.PadRight(31, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FirstNameMid()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string First_Name = "";

            First_Name = First_Name.PadRight(15, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SurnameMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string Surname = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "a";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SurnameMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Surname = "aa";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void SurnameMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Surname = "";

            Surname = Surname.PadRight(49, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "";
            Surname = Surname.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SurnameMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this shold fail

            string Surname = "";

            Surname = Surname.PadRight(51, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SurnameMid()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Surname = "";

            Surname = Surname.PadRight(25, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        // ----------------------------------------------------------------------------------------------- //

        public void EmailMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should fail

            string Email = "";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Email = "aa";

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Email = "";

            Email = Email.PadRight(99, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this shold fail

            string Email = "";

            Email = Email.PadRight(101, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailMid()

        {

            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //this should pass

            string Email = "";

            Email = Email.PadRight(50, 'a');

            //invoke the method

            Error = ACustomer.Valid(First_Name, Surname, AddressNo, Address, Postcode, Email, Account_Creation_Date);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");
        }
    }
}
