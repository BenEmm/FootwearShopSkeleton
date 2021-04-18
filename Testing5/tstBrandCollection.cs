﻿using System;
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
    }
}
