using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        // Constructor for the class
        public clsCustomerCollection()
        {
            // var for the index
            Int32 Index = 0;
            // Car to store the record count
            Int32 RecordCount = 0;
            // Object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                // Read in the field from the current record
                ACustomer.IsCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["Is_Customer"]);
                ACustomer.AddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressNo"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["First_Name"]);
                ACustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Account_Creation_Date"]);
                ACustomer.TotalSpent = Convert.ToDecimal(DB.DataTable.Rows[Index]["Total_Spent"]);
                // Add the record to the private data member
                mCustomerList.Add(ACustomer);
                // Point at the next record
                Index++;
            }
        }

        public int Count
        {
            get
            {
                // return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                // We shall worry about this later (this line is actually in the lab work)
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                // Return the private data
                return mCustomerList;
            }
            set
            {
                // Set the private data
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}