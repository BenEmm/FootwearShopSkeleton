﻿using System;
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.IsCustomer = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Jeff";
            TestItem.Surname = "Jefferson";
            TestItem.AddressNo = 12;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40RT";
            TestItem.Email = "Jeff@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.TotalSpent = 4000;
            //set this stock to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.IsCustomer = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Jeff";
            TestItem.Surname = "Jefferson";
            TestItem.AddressNo = 12;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40RT";
            TestItem.Email = "Jeff@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.TotalSpent = 4000;
            // Set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomers.Add();
            // Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            // Modify the test data
            TestItem.IsCustomer = true;
            TestItem.CustomerID = 34;
            TestItem.FirstName = "Jeffington";
            TestItem.Surname = "Jefferson";
            TestItem.AddressNo = 57;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40QQ";
            TestItem.Email = "Jeffing@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.TotalSpent = 999;
            // Set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            // Update the record
            AllCustomers.Update();
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // Set it's properties
            TestItem.IsCustomer = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Jeff";
            TestItem.Surname = "Jefferson";
            TestItem.AddressNo = 12;
            TestItem.Address = "Jeff Street";
            TestItem.PostCode = "LE40RT";
            TestItem.Email = "Jeff@Jeff.com";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            TestItem.TotalSpent = 4000;
            // Set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomers.Add();
            //Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Delete the record
            AllCustomers.Delete();
            // Now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySurname()
        {
            // Create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply a blank string (Should return all records)
            FilteredCustomers.ReportBySurname("");
            // Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportBySurnameNoneFound()
        {
            // Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply a surname that doesn't exist
            FilteredCustomers.ReportBySurname("XYZ");
            // Test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportBySurnameTestDataFound()
        {
            // Create an instance of the filtered data
            clsCustomerCollection FilteredSurnames = new clsCustomerCollection();
            // Var to store the outcome
            Boolean OK = true;
            // Apply a Surname that doesn't exist
            FilteredSurnames.ReportBySurname("Jefferson");
            // Check that the correct number of records are found 
            if (FilteredSurnames.Count == 2)
            {
                // Check that the first record id is 1020
                if (FilteredSurnames.CustomerList[0].CustomerID != 1024)
                {
                    OK = false;
                }
                // Check that the first record is ID 1021
                if (FilteredSurnames.CustomerList[1].CustomerID != 1025)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
