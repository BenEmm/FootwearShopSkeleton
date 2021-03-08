using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            // Test to see that it exists 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            // Create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            // Add an item to the list
            // Create the item of the test data 
            clsCustomer TestItem = new clsCustomer();
            // Set it's properties
            TestItem.AddressNo = 12;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40RT";
            TestItem.FirstName = "Jeff";
            TestItem.Surname = "Jefferson";
            TestItem.Email = "Jeff@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.IsCustomer = true;
            TestItem.TotalSpent = 4000;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllCustomers.CustomerList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            // Create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            // Create some test data to assign to the property
            Int32 SomeCount = 2;
            // Assign the data to the property
            AllCustomers.Count = SomeCount;
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            // Create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            // Create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            // Set the properties of the test object
            TestCustomer.AddressNo = 12;
            TestCustomer.Address = "Jeff Street";
            TestCustomer.PostCode = "LE40RT";
            TestCustomer.FirstName = "Jeff";
            TestCustomer.Surname = "Jefferson";
            TestCustomer.Email = "Jeff@Jeff.com";
            TestCustomer.AccountCreationDate = DateTime.Now.Date;
            TestCustomer.IsCustomer = true;
            TestCustomer.TotalSpent = 4000;
            // Assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            // Add an item to the list
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Set its properties
            TestItem.AddressNo = 12;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40RT";
            TestItem.FirstName = "Jeff";
            TestItem.Surname = "Jefferson";
            TestItem.Email = "Jeff@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.IsCustomer = true;
            TestItem.TotalSpent = 4000;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllCustomers.CustomerList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            // Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }*/
    }
}
