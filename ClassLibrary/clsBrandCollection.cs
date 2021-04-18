
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

        //public properties 
        public List<clsBrand> BrandList { get { return mBrandList; } set { mBrandList = value; } }
        public int Count { get { return BrandList.Count; } set { } }
        public clsBrand ThisBrand { get; set; }


        // class constructor
        public clsBrandCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection connection = new clsDataConnection();
            //execute stored procedure
            connection.Execute("sproc_tblBrand_SelectAll");
            //get count of brands in table
            recordCount = connection.Count;
            while (index < recordCount)
            {
                clsBrand brand = new clsBrand();
                brand.BrandID = Convert.ToInt32(connection.DataTable.Rows[index]["BrandID"]);
                brand.BrandName = Convert.ToString(connection.DataTable.Rows[index]["BrandName"]);
                brand.TopProduct = Convert.ToInt32(connection.DataTable.Rows[index]["TopProduct"]);
                brand.LatestProduct = Convert.ToInt32(connection.DataTable.Rows[index]["LatestProduct"]);
                brand.LastRestock = Convert.ToDateTime(connection.DataTable.Rows[index]["LastRestock"]);
                brand.AvgPrice = Convert.ToDouble(connection.DataTable.Rows[index]["AvgPrice"]);
                brand.IsListed = Convert.ToBoolean(connection.DataTable.Rows[index]["IsListed"]);
                mBrandList.Add(brand);
                index++;
            }

        }
    }

}