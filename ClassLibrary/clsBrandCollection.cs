
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    /** 
     * When instantiated, the object should be populated with all brands stored in database.
     * */
    public class clsBrandCollection
    {
        //private fields
        private List<clsBrand> mBrandList = new List<clsBrand>();
        private clsBrand mThisBrand = new clsBrand();

        //public properties 
        public List<clsBrand> BrandList { get { return mBrandList; } set { mBrandList = value; } }
        public int Count { get { return BrandList.Count; } set { } }
        public clsBrand ThisBrand { get { return mThisBrand; } set { mThisBrand = value; } }


        // class constructor
        public clsBrandCollection()
        {
            clsDataConnection connection = new clsDataConnection();
            //execute stored procedure
            connection.Execute("sproc_tblBrand_SelectAll");
            PopulateArray(connection);
        }

        // add
        public Int32 Add() {
            // create new db connection
            clsDataConnection DB = new clsDataConnection();
            // load parameters
            DB.AddParameter("@BrandName", mThisBrand.BrandName);
            DB.AddParameter("@TopProduct", mThisBrand.TopProduct);
            DB.AddParameter("@LatestProduct", mThisBrand.LatestProduct);
            DB.AddParameter("@LastRestock", mThisBrand.LastRestock);
            DB.AddParameter("@AvgPrice", mThisBrand.AvgPrice);
            DB.AddParameter("@IsListed", mThisBrand.IsListed);
            // execute stored procedure
            return DB.Execute("sproc_tblBrand_Insert");
        }

        //update method
        public void Update()
        {
            // create connection to DB
            clsDataConnection DB = new clsDataConnection();
            // set parameters for sproc
            DB.AddParameter("@BrandID", mThisBrand.BrandID);
            DB.AddParameter("@BrandName", mThisBrand.BrandName);
            DB.AddParameter("@TopProduct", mThisBrand.TopProduct);
            DB.AddParameter("@LatestProduct", mThisBrand.LatestProduct);
            DB.AddParameter("@LastRestock", mThisBrand.LastRestock);
            DB.AddParameter("@AvgPrice", mThisBrand.AvgPrice);
            DB.AddParameter("@IsListed", mThisBrand.IsListed);
            // execute stored procedure
            DB.Execute("sproc_tblBrand_Update");
        }

        public void Delete()
        {
            // deletes the brand currently pointed to by ThisBrand
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BrandID", mThisBrand.BrandID);
            // Execute store proc
            DB.Execute("sproc_Brand_Delete");
        }

        public void ReportByBrandName(string brandName)
        {
            // filter brands based on full or partial BrandName
            // connect to db
            clsDataConnection DB = new clsDataConnection();

            // send the param passed to the connection
            DB.AddParameter("@BrandName", brandName);

            DB.Execute("sproc_tblBrand_FilterByBrandName");
            // populate the array
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection db)
        {
            // populates array list based on the data table in the parameter
            // var for index
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount = db.Count;
            //clear private Array list
            mBrandList = new List<clsBrand>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create brand
                clsBrand Brand = new clsBrand();
                Brand.BrandID = Convert.ToInt32(db.DataTable.Rows[Index]["BrandID"]);
                Brand.BrandName = Convert.ToString(db.DataTable.Rows[Index]["BrandName"]);
                Brand.TopProduct = Convert.ToInt32(db.DataTable.Rows[Index]["TopProduct"]);
                Brand.LatestProduct = Convert.ToInt32(db.DataTable.Rows[Index]["LatestProduct"]);
                Brand.LastRestock = Convert.ToDateTime(db.DataTable.Rows[Index]["LastRestock"]);
                Brand.AvgPrice = Convert.ToDouble(db.DataTable.Rows[Index]["AvgPrice"]);
                Brand.IsListed = Convert.ToBoolean(db.DataTable.Rows[Index]["IsListed"]);
                mBrandList.Add(Brand);
                // point to next brand
                Index++;
            }
        }
    }

}