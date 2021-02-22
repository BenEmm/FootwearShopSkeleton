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

        public string Valid(string First_Name, string Surname, string AddressNo, string Address, string Postcode, string Email, string Account_Creation_Date)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (AddressNo.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (AddressNo.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Account_Creation_Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (Postcode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (Postcode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is too long
            if (Address.Length > 250)
            {
                //record the error
                Error = Error + "The address must be less than 250 characters : ";
            }
            //is the first name blank
            if (First_Name.Length == 0)
            {
                //record the error
                Error = Error + "The firstname may not be blank : ";
            }
            //if the first name is too long
            if (First_Name.Length > 30)
            {
                //record the error
                Error = Error + "The firstname must be less than 30 characters : ";
            }
            //is the surname blank
            if (Surname.Length == 0)
            {
                //record the error
                Error = Error + "The surname may not be blank : ";
            }
            //if the surname is too long
            if (Surname.Length > 50)
            {
                //record the error
                Error = Error + "The surname must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}