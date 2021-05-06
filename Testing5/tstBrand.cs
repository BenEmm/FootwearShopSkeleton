using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]

    public class tstBrand
    {
        clsBrand Brand = new clsBrand();
        // test data
        Int32 BrandID = 0;
        string BrandName = "Sketchers";
        string TopProduct = "Light-Ups";
        string LatestProduct = "Sketchers Runners";
        string LastRestock = DateTime.Today.ToString();
        // isListed ignored
        // avgPrice is calculated and not validated.
        

        [TestMethod]
        public void InstanceOK()
        {
            clsBrand notABrand = new clsBrand();
            Assert.IsNotNull(notABrand);

            // test full constructor
            Assert.IsNotNull(Brand);
        }


        // test fields
        [TestMethod]
        public void PrimaryKeyOK()
        {
            // a brand obtains an ID when its added to DB (since the 
            // table header is denoted by the DB and not the middle layer
            clsBrand Brand = new clsBrand();
            Int32 TestData = 1395;
            Brand.BrandID = TestData;
            Assert.AreEqual(Brand.BrandID, TestData);
        }

        [TestMethod] 
        public void TestBrandName()
        {
            string TestData = "Adidas";
            //assign
            Brand.BrandName = TestData;
            //test are equal
            Assert.AreEqual(Brand.BrandName, TestData);
        }

        [TestMethod]
        public void TestTopProduct()
        {
            int TestData = 3;
            Brand.TopProduct = TestData;
            Assert.AreEqual(Brand.TopProduct, TestData);
        }

        [TestMethod]
        public void TestLatestProduct()
        {
            int TestData = 1;
            Brand.TopProduct = TestData;
            Assert.AreEqual(Brand.TopProduct, TestData);
        }

        [TestMethod]
        public void TestLastRestock()
        {
            DateTime TestData = new DateTime(2020, 12, 31);// some date
            Brand.LastRestock = TestData;
            Assert.AreEqual(Brand.LastRestock, TestData);
        }

        [TestMethod]
        public void TestAvgPrice()
        {
            double TestData = 10.99;
            Brand.AvgPrice = TestData;
            Assert.AreEqual(Brand.AvgPrice, TestData);
        }

        [TestMethod]
        public void TestIsListed()
        {
            // create default Brand, no properties set...
            clsBrand notABrand = new clsBrand(); 
            // also create test data, and assign test data to global Brand
            bool TestData = true;
            Brand.IsListed = TestData;
            // test global Brand
            Assert.AreEqual(Brand.IsListed, TestData);
            //also test notABRand
            Assert.AreEqual(notABrand.IsListed, false);
        }

        // FIND 
        [TestMethod]
        public void TestFindMethod()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBrandIdFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.BrandID != 1395)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandNameFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.BrandName != "TestBrandInc")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTopProductFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.TopProduct != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLatestProductFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.LatestProduct != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastRestockFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.LastRestock != Convert.ToDateTime("06/05/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvgPriceFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 3;
            Found = ABrand.Find(Id);
            if (ABrand.AvgPrice != 0.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsListedFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1395;
            Found = ABrand.Find(Id);
            if (ABrand.IsListed != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidMethod()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, LastRestock);
        }


        // brand name tests
        // name : string 50 not null
        // topproduct : int not null
        // latestprod : int not null
        // lastrestock : date

        [TestMethod]
        public void TestValidBrandNameMinLessOne()
        {
            clsBrand brand = new clsBrand();
            String ErrorMsg = "";

            // invoke Valid() with 1 character for BrandName
            ErrorMsg = brand.Valid("", TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (error)
            Assert.AreEqual(ErrorMsg, "You must enter a brand name.<br />");

        }

        [TestMethod]
        public void TestValidBrandNameMin()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string min = "a";
            ErrorMsg = brand.Valid(min, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidBrandNameMinPlusOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string minPlusOne = "ab";
            ErrorMsg = brand.Valid(minPlusOne, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidBrandNameMaxLessOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string maxLessOne = "heres a str that should be exactly 49 characters.";
            ErrorMsg = brand.Valid(maxLessOne, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidBrandNameMax()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string max = "heres a str that should be exactly 50 characters..";
            ErrorMsg = brand.Valid(max, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidBrandNameMid()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string mid = "this one is 25 chars(mid)";
            ErrorMsg = brand.Valid(mid, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidBrandNameMaxAddOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";
            // invoke Valid() with 1 character for BrandName
            string maxAddOne = "heres a str that should be exactly 51 characters...";
            ErrorMsg = brand.Valid(maxAddOne, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "Your brand name is too long. Must be fewer than 50 characters long.<br />");
        }

        [TestMethod]
        public void TestValidBrandNameExtremeMax()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";


            // invoke Valid() with 1 character for BrandName
            string extremeMax = "Extreme Max String (200) Extreme Max String (200) Extreme Max String (200) " +
                "Extreme Max String (200) Extreme Max String (200) Extreme Max String (200) Extreme Max String (200) " +
                "Extreme Max String (200) ";

            ErrorMsg = brand.Valid(extremeMax, TopProduct, LatestProduct, LastRestock);

            // Check the error message matches expected result (no error)
            Assert.AreEqual(ErrorMsg, "Your brand name is too long. Must be fewer than 50 characters long.<br />");
        }




        // test last restock date
        [TestMethod]
        public void TestValidLastRestockExtremeMin()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            DateTime TestDate = DateTime.Today.AddYears(-50);

            string ExtremeMin = TestDate.ToString();

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, ExtremeMin);

            Assert.AreEqual(ErrorMsg, "Please enter a more recent date (after 31-12-2000).<br />");
        }


        [TestMethod]
        public void TestValidLastRestockMinLessOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            string MinMinusOne = "30/12/2000";

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, MinMinusOne);

            Assert.AreEqual(ErrorMsg, "Please enter a more recent date (after 31-12-2000).<br />");
        }

        [TestMethod]
        public void TestValidLastRestockMin()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            string Min = "31/12/2000";

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, Min);
            // should accept min value
            Assert.AreEqual(ErrorMsg, "");
        }


        [TestMethod]
        public void TestValidLastRestockMinPlusOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            string MinPlusOne = "01/01/2001";

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, MinPlusOne);

            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidLastRestockMaxLessOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            DateTime TestDate = DateTime.Today.AddDays(-1); // yesterday

            string MaxLessOne = TestDate.ToString();

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, MaxLessOne);
            // no error msg
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidLastRestockMax()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            DateTime TestDate = DateTime.Today; // today

            string Max = TestDate.ToString();

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, Max);
            // no error msg
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void TestValidLastRestockMaxPlusOne()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            DateTime TestDate = DateTime.Today.AddDays(1); // tomorrow

            string MaxPlusOne = TestDate.ToString();

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, MaxPlusOne);
            // Error message expected
            Assert.AreEqual(ErrorMsg, "Date cannot be in the future.<br />");
        }


        [TestMethod]
        public void TestValidLastRestockExtremeMax()
        {
            clsBrand brand = new clsBrand();

            String ErrorMsg = "";

            DateTime TestDate = DateTime.Today.AddYears(50); // extreme test data

            string ExtremeMax = TestDate.ToString();

            ErrorMsg = brand.Valid(BrandName, TopProduct, LatestProduct, ExtremeMax);
            // Error message expected
            Assert.AreEqual(ErrorMsg, "Date cannot be in the future.<br />");
        }
    }
}


