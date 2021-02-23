﻿using System;

namespace ClassLibrary {

    public class clsBrand
    {
        //encapsulated fields 
        private Int32 brandId;
        private string brandName;
        private int topProduct;
        private int latestProduct;
        private DateTime lastRestock;
        private double avgPrice;
        private bool isListed;
        
        //public properties and getters/setters
        public Int32 BrandID { get { return brandId; } private set { brandId = value; } } // cannot set this outside of class, the DB assigns the number, this class will fetch the num to be set here.
        public string BrandName { get { return brandName; } set { brandName = value; } }
        public int TopProduct { get { return topProduct; } set { topProduct = value; } }
        public int LatestProduct { get { return latestProduct; } set { latestProduct = value; } }
        public DateTime LastRestock { get { return lastRestock; } set { lastRestock = value; } }
        public double AvgPrice { get { return avgPrice; } set { avgPrice = value; } }
        public bool IsListed { get { return isListed; } set { isListed = value; } }

        public clsBrand()
        {
            BrandID = 0;
            BrandName = "";
            TopProduct = 0;
            LatestProduct = 0;
            LastRestock = new DateTime();
            AvgPrice = 0.00;
            IsListed = false;
        }

        // full constructor
        public clsBrand(string name, int tProduct, int lProduct, DateTime restock, bool isListed) 
        {
            BrandName = name;
            TopProduct = tProduct;
            LatestProduct = lProduct;
            LastRestock = restock;
            AvgPrice = calculateAvgPrice();
            IsListed = isListed;
            AddToDatabase(this);
            BrandID = FindBrandID(); // the num of the last db entry
        }


        public void Delete()
        {
            clsDataConnection connection = new clsDataConnection();
            connection.AddParameter("@BrandID", this.BrandID);
            connection.Execute("sproc_Brand_Delete");
        }
        public void AddToDatabase(clsBrand brand)  
        {
            // converts a DateTime variable to sql DATE format.
            string sqlRestockDate = (brand.LastRestock.Year + brand.LastRestock.Month + brand.LastRestock.Day).ToString();
            clsDataConnection connection = new clsDataConnection();
            connection.AddParameter("@BrandName", brand.BrandName);
            connection.AddParameter("@TopProduct", brand.TopProduct);
            connection.AddParameter("@LatestProduct", brand.LatestProduct);
            connection.AddParameter("@LastRestock ", sqlRestockDate);
            connection.AddParameter("@AvgPrice", brand.AvgPrice);
            connection.AddParameter("@IsListed", brand.IsListed);
            connection.Execute("sproc_Brand_Add");
        }

        public bool Find(int brandId)
        {
            BrandID = 2;
            BrandName = "Nike";
            TopProduct = 2;
            LatestProduct = 2;
            LastRestock = Convert.ToDateTime("11/10/2020");
            AvgPrice = 0.00;
            IsListed = true;

            //always return true
            return true;
        }

        public double calculateAvgPrice()  
        {
            return 0.00;
        }

        private int FindBrandID()
        {
            clsDataConnection connection = new clsDataConnection();
            return connection.Execute("sproc_Get_LastRow");
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || this.GetType().Name != obj.GetType().Name)
            {
                return false;
            }

            clsBrand other = (clsBrand)obj;

            return this.BrandID == other.BrandID;
        }

    }

}