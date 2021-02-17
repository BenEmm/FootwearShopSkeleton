using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]

    public class tstBrand
    {
        // create an instance of class Brand for this scope.
        clsBrand brand = new clsBrand("Nike", 2, 2, new System.DateTime(2020, 10, 11), true);

        [TestMethod]
        public void InstanceOK()
        {
            clsBrand notABrand = new clsBrand();
            Assert.IsNotNull(notABrand);

            // test full constructor
            Assert.IsNotNull(brand);
        }


        // test fields
        [TestMethod]
        public void PrimaryKeyOK()
        {
            // a brand obtains an ID when its added to DB (since the 
            // table header is denoted by the DB and not the middle layer).


            clsBrand notABrand = new clsBrand();
            int testBrandID = brand.BrandID;
            Assert.IsTrue(testBrandID > 0); // means it was assigned an ID using sproc
            Assert.IsTrue(notABrand.BrandID == 0); // means the non-brand object was not assigned a num/added to db.
        }

        [TestMethod] 
        public void TestBrandName()
        {
            string TestData = "Adidas";
            //assign
            brand.BrandName = TestData;
            //test are equal
            Assert.AreEqual(brand.BrandName, TestData);
        }

        [TestMethod]
        public void TestTopProduct()
        {
            int TestData = 3;
            brand.TopProduct = TestData;
            Assert.AreEqual(brand.TopProduct, TestData);
        }

        [TestMethod]
        public void TestLatestProduct()
        {
            int TestData = 1;
            brand.TopProduct = TestData;
            Assert.AreEqual(brand.TopProduct, TestData);
        }

        [TestMethod]
        public void TestLastRestock()
        {
            DateTime TestData = new DateTime(2020, 12, 31);// some date
            brand.LastRestock = TestData;
            Assert.AreEqual(brand.LastRestock, TestData);
        }

        [TestMethod]
        public void TestAvgPrice()
        {
            double TestData = 10.99;
            brand.AvgPrice = TestData;
            Assert.AreEqual(brand.AvgPrice, TestData);
        }

        [TestMethod]
        public void TestIsListed()
        {
            // create default Brand, no properties set...
            clsBrand notABrand = new clsBrand(); 
            // also create test data, and assign test data to global Brand
            bool TestData = true;
            brand.IsListed = TestData;
            // test global Brand
            Assert.AreEqual(brand.IsListed, TestData);
            //also test notABRand
            Assert.AreEqual(notABrand.IsListed, false);
        }

        // FIND 
        [TestMethod]
        public void TestFindMethod()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Int32 Id = 2;
            Found = ABrand.Find(Id);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBrandIdFound()
        {
            clsBrand ABrand = new clsBrand();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 2;
            Found = ABrand.Find(Id);
            if (ABrand.BrandID != 2)
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
            Int32 Id = 2;
            Found = ABrand.Find(Id);
            if (ABrand.BrandName != "Nike")
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
            Int32 Id = 2;
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
            Int32 Id = 2;
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
            Int32 Id = 2;
            Found = ABrand.Find(Id);
            if (ABrand.LastRestock != Convert.ToDateTime("11/10/2020"))
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
            Int32 Id = 2;
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
            Int32 Id = 2;
            Found = ABrand.Find(Id);
            if (ABrand.IsListed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}


