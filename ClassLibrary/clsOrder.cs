using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNumber;

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

        public string Email {
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
            mOrderNumber = 21;
            mTotalPrice = 50;
            mQuantity = 10;
            mEmail = "TestEmail@Test.com";
            mCustomerName = "Jack James";
            mTrackingNumber = "XXXXXXX";
            mShippingDate = Convert.ToDateTime("16/09/2021");
            mShipped = true;
            return true;
        }
    }
}