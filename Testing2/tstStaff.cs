using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        string FullName = "Full Name";
        string Salary = 7.78.ToString();
        string DateOfJoining = DateTime.Now.Date.ToString();
        string Position = "Staff Position";

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
        public void SalaryOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            double TestData = 7.78;
            //assign the data to the property
            AStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }

        [TestMethod]
        public void DateOfJoiningOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfJoining = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfJoining, TestData);
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
        public void ActiveOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result sof validation
            Boolean found = false;
            //create some test data to use with the method 
            Int32 StaffID = 3;
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
            Int32 StaffID = 3;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.StaffID != 3)
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
            Int32 StaffID = 3;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.FullName != "Charlie Knolls")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 3;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.Salary != 7.78)
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
            Int32 StaffID = 3;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.DateOfJoining != Convert.ToDateTime("13/03/2020"))
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
            Int32 StaffID = 3;
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
            Int32 StaffID = 3;
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

        [TestMethod]
        public void ActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of validation
            Boolean found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 3;
            //invoke the method 
            found = AStaff.Find(StaffID);
            //check the staffID
            if (AStaff.Active != true)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FullName = "";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string FullName = "a";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string FullName = "aa";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string FullName = "";
            FullName = FullName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should fail
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string FullName = "";
            FullName = FullName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameExtreme()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should fail
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double testSalary = -1000000.00;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double testSalary = -0.01;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should pass
            double testSalary = 0.0;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should pass
            double testSalary = 0.01;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should pass
            double testSalary = 1000000.00 - 1;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should pass
            double testSalary = 1000000.00;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //This test should fail
            double testSalary = 1000001.00;
            //change double to string
            string Salary = testSalary.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //this test should fail
            string Salary = "This is not a salary!";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfJoining = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is yesterday
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfJoining = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfJoining = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is tomorrow
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfJoining = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is more than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfJoining = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfJoiningInvalidData()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String varibale to store any error message
            String Error = "";
            //set the dateofjoining to a non date value 
            string DateOfJoining = "This is not a date!";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string Position = "a";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string Position = "aa";
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string Position = "";
            Position = Position.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string Position = "";
            Position = Position.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should fail
            string Position = "";
            Position = Position.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should pass
            string Position = "";
            Position = Position.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionExtreme()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //this test should fail
            string Position = "";
            Position = Position.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FullName, Salary, DateOfJoining, Position);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
