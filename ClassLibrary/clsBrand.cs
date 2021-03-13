using System;

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
        
        //public properties & getters/setters
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

        public bool Find(int brandId)
        {
            clsDataConnection connection = new clsDataConnection();
            connection.AddParameter("@BrandID", brandId);
            connection.Execute("sproc_FindByBrandID");

            // if a record exists in connection database
            if (connection.Count == 1)
            {
                BrandID = Convert.ToInt32(connection.DataTable.Rows[0]["BrandID"]);
                brandName = Convert.ToString(connection.DataTable.Rows[0]["BrandName"]);
                topProduct = Convert.ToInt32(connection.DataTable.Rows[0]["TopProduct"]);
                latestProduct = Convert.ToInt32(connection.DataTable.Rows[0]["LatestProduct"]);
                lastRestock = Convert.ToDateTime(connection.DataTable.Rows[0]["LastRestock"]);
                avgPrice = Convert.ToDouble(connection.DataTable.Rows[0]["AvgPrice"]);
                isListed = Convert.ToBoolean(connection.DataTable.Rows[0]["IsListed"]);
                return true;
            }
            else
            {
                // was not found.
                return false;
            }
        }

        public string Valid(string brandName, string topProduct, string latestProduct, string lastRestock)
        {
            String ErrorMsg = "";

            if (brandName.Length == 0)
            {
                ErrorMsg += "You must enter a brand name.\n";
            }
            else if (brandName.Length > 50)
            {
                ErrorMsg += "Your brand name is too long. Must be fewer than 50 characters long.\n";
            }
            else if (topProduct == "")
            {
                ErrorMsg += "You must select a top product.\n";
            }
            else if (latestProduct == "")
            {
                ErrorMsg += "You must select a latest product.\n";
            }
            else if (lastRestock == "")
            {
                ErrorMsg += "Please select a date\n";
            }
            else if (Convert.ToDateTime(lastRestock) < Convert.ToDateTime("31/12/2000"))
            {
                // shouldnt accept a date in the far past (sql min date = 1753)
                ErrorMsg += "Please enter a more recent date (after 31-12-2000).\n";
            }
            else if (Convert.ToDateTime(lastRestock) > DateTime.Now.Date)
            {
                ErrorMsg += "Date cannot be in the future.\n";
            }
            
            return ErrorMsg;
        }


        // functionality needed
        public double calculateAvgPrice()  
        {
            return 0.00;
        }
        

        // may not use
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

        
    }

}
