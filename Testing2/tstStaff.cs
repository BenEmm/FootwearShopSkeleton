using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test if exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FullNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Full Name";
            //assign the data to the property
            AStaff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FullName, TestData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Password1";
            //assign the data to the property
            AStaff.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Password, TestData);
        }

        [TestMethod]
        public void DateOfLeavingOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfLeaving = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfLeaving, TestData);
        }

        [TestMethod]
        public void PostionOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Weekend Staff";
            //assign the data to the property
            AStaff.Positon = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Positon, TestData);
        }

        [TestMethod]
        public void FullTimeOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.FullTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FullTime, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result sof validation
            Boolean found = false;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //test to see if result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void StaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.StaffID != 21)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.FullName != "Full Name")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.Password != "Password1")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfLeavingFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.DateOfLeaving != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.Positon != "Weekend Staff")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FullTimeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.FullTime != false)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }
    }
}
