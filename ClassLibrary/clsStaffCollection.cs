﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList = new List<clsStaff>();
        //constructor for the class
        public clsStaffCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaffdb_SelectAll");
            //populate the array list with the table data
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter db
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                AStaff.DateOfJoining = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfJoining"]);
                AStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AStaff.FullTime = Convert.ToBoolean(DB.DataTable.Rows[Index]["FullTime"]);
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;

            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {

            }
        }
        private clsStaff mThisStaff = new clsStaff();
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set private data
                mThisStaff = value;
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of mthisstaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@DateOfJoining", mThisStaff.DateOfJoining);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@FullTime", mThisStaff.FullTime);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute query returning the primary key 
            return DB.Execute("sproc_tblStaffdb_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@DateOfJoining", mThisStaff.DateOfJoining);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@FullTime", mThisStaff.FullTime);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute stored procedure
            DB.Execute("sproc_tblStaffdb_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by thisStaff
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the params for stored procedure 
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the procedure
            DB.Execute("sproc_tblStaffdb_Delete");
        }

        public void ReportByPosition(string Position)
        {
            //filters the records based on a position
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the position parameter to the database
            DB.AddParameter("@Position", Position);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffdb_FilterByPosition");
            //populate the array list with the table data 
            PopulateArray(DB);
        }
    }
}