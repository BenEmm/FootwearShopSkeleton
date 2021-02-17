using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]

    public class tstBrand
    {
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
        public void PrimaryKeyOK() { 
        
            int testBrandID = brand.BrandID;
            Assert.IsTrue(testBrandID  > 0); // means it was assigned a number using sproc
        }

        [TestMethod] 
        public void TestBrandName()
        {
            string TestData = "Nike";
            Assert.AreEqual(brand.BrandName, TestData);
        }

        public void TestTopProduct()
        {
            int TestData = 1;
            Assert.AreEqual(brand.TopProduct, TestData);
        }
    }
}


