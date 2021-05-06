using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstBrandCollection
    {
        [TestMethod]
        public void TestConstructor()
        {
            clsBrandCollection AllBrands = new clsBrandCollection();
            Assert.IsNotNull(AllBrands);
        }

        [TestMethod]
        public void TestBrandList()
        {
            // create collection of brand instance
            clsBrandCollection AllBrands = new clsBrandCollection();
            //create a List of Brands
            List<clsBrand> TestList = new List<clsBrand>();
            // create test brand
            clsBrand TestBrand = new clsBrand();
            // set test brand fields.
            TestBrand.BrandID = 1;
            TestBrand.BrandName = "Test Brand Ltd";
            TestBrand.IsListed = true;
            TestBrand.LastRestock = DateTime.Today.Date;
            TestBrand.TopProduct = 1;
            TestBrand.LatestProduct = 1;
            TestBrand.AvgPrice = TestBrand.calculateAvgPrice();
            // add test brand to list
            TestList.Add(TestBrand);
            AllBrands.BrandList = TestList;
            Assert.AreEqual(AllBrands.BrandList, TestList);
        }

        [TestMethod]
        public void TestListAndCount()
        {
            // create an instance of a brand list class
            clsBrandCollection AllBrands = new clsBrandCollection();
            // create list of brands to assign to of AllBrands
            List<clsBrand> TestList = new List<clsBrand>();
            // create test brand item
            clsBrand TestBrand = new clsBrand();
            TestBrand.BrandID = 1;
            TestBrand.BrandName = "ABrand Name Ltd.";
            TestBrand.TopProduct = 1;
            TestBrand.LatestProduct = 1;
            TestBrand.LastRestock = DateTime.Now.Date;
            TestBrand.AvgPrice = 0.00;
            TestBrand.IsListed = false;
            // add test brand to test list
            TestList.Add(TestBrand);
            // set test list as the value for the collection class list.
            AllBrands.BrandList = TestList;
            // test that they both have same count
            Assert.AreEqual(AllBrands.Count, TestList.Count);
        }

        [TestMethod]
        public void TestAddMethod()
        {
            // create collection instance
            clsBrandCollection AllBrands = new clsBrandCollection();
            //create brand item
            clsBrand Brand = new clsBrand();
            // PK variable
            Int32 PK = 0;
            // set properties
            Brand.BrandID = 1;
            Brand.BrandName = "TestBrandInc";
            Brand.TopProduct = 2;
            Brand.LatestProduct = 2;
            Brand.LastRestock = DateTime.Now.Date;
            Brand.AvgPrice = 0.00;
            Brand.IsListed = false;
            // set ThisAddress to Brand object
            AllBrands.ThisBrand = Brand;
            //add record
            PK = AllBrands.Add();
            // set primary key
            Brand.BrandID = PK;
            // find the record
            AllBrands.ThisBrand.Find(PK);
            // test objects are equal
            Assert.AreEqual(AllBrands.ThisBrand, Brand);
        }

        [TestMethod]
        public void TestUpdateMethod()
        {
            // create collection instance
            clsBrandCollection AllBrands = new clsBrandCollection();
            // create test item
            clsBrand Test = new clsBrand();
            // primary key variable
            Int32 PK = 0;
            // set test item properties
            Test.BrandID = 1;
            Test.BrandName = "TestBrandInc";
            Test.TopProduct = 2;
            Test.LatestProduct = 2;
            Test.LastRestock = DateTime.Now.Date;
            Test.AvgPrice = 0.00;
            Test.IsListed = false;
            // set ThisBrand to be the Test object.
            AllBrands.ThisBrand = Test;
            AllBrands.Update();
            AllBrands.ThisBrand.Find(PK);
            // test that update worked
            Assert.AreEqual(AllBrands.ThisBrand, Test);
        }

        [TestMethod]
        public void TestDeleteMethod()
        {
            // create collection instance
            clsBrandCollection AllBrands = new clsBrandCollection();
            // create the test brand
            clsBrand Brand = new clsBrand();
            //PK Var
            Int32 PK = 0;
            //set brand's fields
            Brand.BrandName = "Nike";
            Brand.TopProduct = 1;
            Brand.LatestProduct = 2;
            Brand.LastRestock = DateTime.Now.Date;
            Brand.AvgPrice = 0.00;
            // set the collection's thisbrand to the test item.
            AllBrands.ThisBrand = Brand;
            // add record to database
            PK = AllBrands.Add();
            // set brand PK
            Brand.BrandID = PK;
            // find record
            AllBrands.ThisBrand.Find(PK);
            //invoke delete
            AllBrands.Delete();
            Boolean Found = AllBrands.ThisBrand.Find(PK);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void TestReportByBrandName()
        {
            clsBrandCollection AllBrands = new clsBrandCollection();
            clsBrandCollection Filtered = new clsBrandCollection();
            // apply a blank string which should return all brands
            Filtered.ReportByBrandName("");
            Assert.AreEqual(AllBrands.Count, Filtered.Count);
        }

        [TestMethod]
        public void TestReportByBrandNameNoneFound()
        {
            clsBrandCollection Filtered = new clsBrandCollection();
            // apply brand name that doesnt exist
            Filtered.ReportByBrandName("xNotxaBrand asdasd");
            // ensure there are no records
            Assert.AreEqual(0, Filtered.Count);
        }

        [TestMethod]
        public void TestReportByBrandNameSomeFound()
        {
            // create filtered collection 
            clsBrandCollection Filtered = new clsBrandCollection();
            // var to store outcome
            Boolean Ok = true;
            // apply name that doesnt exist
            Filtered.ReportByBrandName("TestBrandInc");
            if (Filtered.BrandList.Count == 2)
            {
                if (Filtered.BrandList[0].BrandID != 1395)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
