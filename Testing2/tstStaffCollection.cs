using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if that exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property- a list
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 7;
            TestItem.FullName = "Full Name";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff";
            TestItem.FullTime = true;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the staff member
            AllStaff.StaffList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffMemberOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //creat some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 7;
            TestItem.FullName = "Full Name";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff";
            TestItem.FullTime = true;
            TestItem.Active = true;
            //assign the data to the staff member
            AllStaff.ThisStaff = TestItem;
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property- a list
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 7;
            TestItem.FullName = "Full Name";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff";
            TestItem.FullTime = true;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the staff member
            AllStaff.StaffList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 123;
            TestItem.FullName = "Full Name";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff";
            TestItem.FullTime = true;
            TestItem.Active = true;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create th eitem of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 Primarykey = 0;
            //set its properties
            TestItem.FullName = "Name One";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff type 1";
            TestItem.FullTime = true;
            TestItem.Active = true;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            Primarykey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = Primarykey;
            //modify the test data
            TestItem.FullName = "Name two";
            TestItem.Salary = 7.78;
            TestItem.DateOfJoining = DateTime.Now.Date;
            TestItem.Positon = "staff type 2";
            TestItem.FullTime = false;
            TestItem.Active = false;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(Primarykey);
            //test to see t=if they match
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}
