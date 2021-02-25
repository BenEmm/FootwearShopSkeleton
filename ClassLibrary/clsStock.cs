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
            if (DB.Count == 1)
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

        public string Valid(string stockDescription, string stockColour, string stockAmount, string stockPrice, string dateOrdered)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            Double StockPriceTemp;
            Int32 StockAmountTemp;
            //If the stock descrtiption is blank
            if (stockDescription.Length == 0)
            {
                //record the error
                Error = Error + "Please enter a stock description : ";
            }
            //if the stock description is too long
            if (stockDescription.Length > 100)
            {
                //record the error 
                Error = Error + "The stock description must be less than 100 characters : ";
            }
            //if the stock colour is blank
            if (stockColour.Length == 0)
            {
                //record the error
                Error = Error + "Please enter a stock colour : ";
            }
            //if the stock colour is too long
            if (stockColour.Length > 50)
            {
                //record the error
                Error = Error + "The stock colour much be less than 50 characters : ";
            }

            //if the stock amount is negative
            if (stockAmount.Length == 0)
            {
                //record the error
                Error = Error + "The value for stock amount must be greater than 0 : ";
            }

            //if the stock amount is too large
            if (stockAmount.Length > 6)
            {
                //record the error
                Error = Error + "The value for stock amount must be less than 1,000,000 : ";
            }
            try
            {
                //copy the stockAmount value to the stockAmountTemp variable
                StockAmountTemp = Convert.ToInt32(stockAmount);
                if (StockAmountTemp < 0)
                {
                    Error = Error + "The stock amount cannot be less than 0 : ";
                }
                if (StockAmountTemp > 1000000)
                {
                    Error = Error + "The stock amount must be less then 1,000,000 : ";
                }
            }
            catch
            {
                Error = Error + "The amount data is not valid : ";
            }

                try
                {
                    //copy the stockPrice value to the stockPriceTemp variable
                    StockPriceTemp = Convert.ToDouble(stockPrice);
                    if (StockPriceTemp < 0)
                    {
                        Error = Error + "The Stock price cannot be less than 0 : ";
                    }
                    if (StockPriceTemp > 100000000.00)
                    {
                        Error = Error + "The stock price must be less than 100,000,000.00";
                    }
                }
                catch
                {
                    Error = Error + "The price data is not valid : ";
                }


                try
                {
                    //copy the dateOrdered value to the datetemp variable
                    DateTemp = Convert.ToDateTime(dateOrdered);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error 
                        Error = Error + "The date cannot be in the past : ";
                    }
                    //check to see if the date is greater than todays date
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error 
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    Error = Error + "The stock price data is not valid : ";
                }
                return Error;
            }
    }
}
