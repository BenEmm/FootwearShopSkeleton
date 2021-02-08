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
            // Set the private data members to the test data value
            mCustomerID = 21;
            mFirstName = "First";
            mSurname = "Surname";
            mAccountCreationDate = Convert.ToDateTime("08/02/2021");
            mAddressNo = 12;
            mAddress = "Address here";
            mPostCode = "LE12 4BP";
            mEmail = "JoeBloggs@email.com";
            mIsCustomer = true;
            mTotalSpent = 550;

            // Always return true
            return true;
        }
    }
}