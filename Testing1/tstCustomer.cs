using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
