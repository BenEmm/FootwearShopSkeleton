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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", StockID);
            DB.Execute("sproc_tblStock_FilterByStockID");
            if(DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockColour = Convert.ToString(DB.DataTable.Rows[0]["StockColour"]);
                mStockAmount = Convert.ToInt32(DB.DataTable.Rows[0]["StockAmount"]);
                mStockPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}