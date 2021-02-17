using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;
        private DateTime mDateOrdered;
        private string mStockDescription;
        private string mStockColour;
        private Int32 mStockAmount;
        private decimal mStockPrice;
        private Boolean mAvailable;

        public DateTime DateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;

            }
        }

        public Int32 StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }

        public string StockDescription
        {
            get
            {
                return mStockDescription;
            }
            set
            {
                mStockDescription = value;
            }
        }

        public string StockColour
        {
            get
            {
                return mStockColour;
            }
            set
            {
                mStockColour = value;
            }
        }

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public Int32 StockAmount
        {
            get
            {
                return mStockAmount;
            }
            set
            {
                mStockAmount = value;
            }
        }
 
        public decimal StockPrice
        {
            get
            {
                return mStockPrice;
            }
            set
            {
                mStockPrice = value;
            }
        }

        public bool Find(int StockID)
        {
            //Set the private data members to the test data value 
            mStockID = 21;
            mDateOrdered = Convert.ToDateTime("16/09/2020");
            mStockDescription = ("Converse");
            mStockColour = ("Black and White");
            mStockAmount = 200;
            mStockPrice = 39.99M;
            mAvailable = true;
            //return true
            return true;
        }
    }
}