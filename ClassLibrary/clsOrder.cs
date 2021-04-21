using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderNumber;

        public int OrderNumber
        {
            get
            {
                return mOrderNumber;
            }

            set
            {
                mOrderNumber = value;
            }
        }
        private string mTrackingNumber;

        public string TrackingNumber
        {
            get
            {
                return mTrackingNumber;
            }


            set
            {
                mTrackingNumber = value;
            }
        }

        private int mQuantity;

        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

        private bool mShipped;
        public bool Shipped
        {
            get
            {
                return mShipped;
            }

            set
            {
                mShipped = value;
            }
        }

        private DateTime mShippingDate;

        public DateTime ShippingDate
        {
            get
            {
                return mShippingDate;
            }

            set
            {
                mShippingDate = value;
            }
        }

        private string mCustomerName;

        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }


        private string mEmail;

        public string Email
        {
            get
            {
                return mEmail;
            }

            set
            {
                mEmail = value;
            }
        }

        private decimal mTotalPrice;

        public decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }

            set
            {
                mTotalPrice = value;
            }
        }

        public bool Find(clsOrder anOrder)
        {
            return true;
        }

        public bool Find(int OrderNumber)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search
            DB.AddParameter("@OrderNumber", OrderNumber);
            //Execute procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderNumber");
            //if one record is found (Either 1 or 0)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mTrackingNumber = Convert.ToString(DB.DataTable.Rows[0]["TrackingNumber"]);
                mShippingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ShippingDate"]); ;
                mShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipped"]);
                //Return everything that worked 
                return true;
            }

            //If no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public string Valid(string orderNumber, string customerName, string email, string quantity, string shippingDate, string trackingNumber)
        {

            String Error = "";
            DateTime DateTemp;

            if (orderNumber.Length == 0)
            {
                // record the error
                Error = Error + "The order no may not be blank : ";
            }
            //if the order no is greater than 6 characters
            if (orderNumber.Length > 6)
            {
                //record the error
                Error = Error + "The order no must be less than 6 characters : ";
            }

            try
            {
                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(shippingDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }
            //is the customer name blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "the customer name may not be blank :";
            }
            //if the customer name is too long
            if (customerName.Length > 50)
            {
                //record the error 
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            //is the customer email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "the customer email may not be blank :";
            }
            //if the customer email is too long
            if (email.Length > 50)
            {
                //record the error 
                Error = Error + "The customer email must be less than 50 characters : ";
            }

            //if the TrackingNo is blank
            if (trackingNumber.Length == 0)
            {
                // record the error
                Error = Error + "The tracking no may not be blank : ";
            }
            //if the tracking no is greater than 6 characters
            if (trackingNumber.Length > 6)
            {
                //record the error
                Error = Error + "The tracking no must be less than 6 characters : ";
            }
            //if the Quantity is blank
            if (quantity.Length == 0)
            {
                // record the error
                Error = Error + "The tracking no may not be blank : ";
            }
            //if the quantity is greater than 3 characters
            if (quantity.Length > 3)
            {
                //record the error
                Error = Error + "The quantity must be less than 3 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}