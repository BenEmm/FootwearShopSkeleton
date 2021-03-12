using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member for thisstock
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var  to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AStock.StockColour = Convert.ToString(DB.DataTable.Rows[Index]["StockColour"]);
                AStock.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                AStock.StockPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["StockPrice"]);
                AStock.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data member 
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }


        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //to be completed

            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data 
                return mThisStock;
            }
            set
            {
                //set the private data 
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockColour", mThisStock.StockColour);
            DB.AddParameter("@StockAmount", mThisStock.StockAmount);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@DateOrdered", mThisStock.DateOrdered);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisstock 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockColour", mThisStock.StockColour);
            DB.AddParameter("@StockAmount", mThisStock.StockAmount);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@DateOrdered", mThisStock.DateOrdered);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }
    }
}