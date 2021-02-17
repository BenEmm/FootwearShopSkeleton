using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data member for the Customer ID property
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                // This line of code send data out of the property
                return mCustomerID;
            }
            set
            {
                // This line of code allows data into the property
                mCustomerID = value;
            }
        }

        // Private data member for the AccountCreationDate property
         private DateTime mAccountCreationDate;
         public DateTime AccountCreationDate
        {
            get
            {
                // This line of code send data out of the property
                return mAccountCreationDate;
            }
            set
            {
                // This line of code allows data into the property
                mAccountCreationDate = value;
            }
        }
        // Private data memeber for the FirstName property
        private string mFirstName;
        public string FirstName
        {
            get
            {
                // This line of code send data out of the property
                return mFirstName;
            }
            set
            {
                // This line of code allows data into the property
                mFirstName = value;
            }
        }

        // Private data member for the Surname property
        private string mSurname;
        public string Surname
        {
            get
            {
                // This line of code send data out of the property
                return mSurname;
            }
            set
            {
                // This line of code allows data into the property
                mSurname = value;
            }
        }

        private int mAddressNo;
        public int AddressNo
        {
            get
            {
                // This line of code sends data out of the property
                return mAddressNo;
            }
            set
            {
                // This line of code allows data into the property
                mAddressNo = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                // This line of code send data out of the property
                return mAddress;
            }
            set
            {
                // This line of code allows data into the property
                mAddress = value;
            }
        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                // This line of code send data out of the property
                return mPostCode;
            }
            set
            {
                // This line of code allows data into the property
                mPostCode = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                // This line of code send data out of the property
                return mEmail;
            }
            set
            {
                // This line of code allows data into the property
                mEmail = value;
            }
        }

        private bool mIsCustomer;
        public bool IsCustomer
        {
            get
            {
                // This line of code send data out of the property
                return mIsCustomer;
            }
            set
            {
                // This line of code allows data into the property
                mIsCustomer = value;
            }
        }

        private decimal mTotalSpent;
        public decimal TotalSpent
        {
            get
            {
                // This line of code send data out of the property
                return mTotalSpent;
            }
            set
            {
                // This line of code allows data into the property
                mTotalSpent = value;
            }
        }

        public bool Find(int CustomerID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the Customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // Execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // If one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["First_Name"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddressNo = Convert.ToInt32(DB.DataTable.Rows[0]["AddressNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Account_Creation_Date"]);
                mIsCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["Is_Customer"]);
                mTotalSpent = Convert.ToDecimal(DB.DataTable.Rows[0]["Total_Spent"]);
                // Return that everything worked okay
                return true;
            }
            // If no record was found 
            else
            {
                // Return false indicating a problem
                return false;
            }
        }
    }
}