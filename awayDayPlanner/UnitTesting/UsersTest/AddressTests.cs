using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting.UsersTest
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void TestAddressClassInstance()
        {
            IAddress address = Address.getInstance();

            Assert.IsInstanceOfType(address, typeof(IAddress));
        }

        [TestMethod]
        public void TestAddressSettersGetters()
        {
            IAddress address = Address.getInstance();
            address.AddressID = 1;
            address.FirstLine = "test";
            address.SecondLine = "test2";
            address.PostCode = "testPostcode";

            Assert.AreEqual(address.AddressID, 1);
            Assert.AreEqual(address.FirstLine, "test");
            Assert.AreEqual(address.SecondLine, "test2");
            Assert.AreEqual(address.PostCode, "testPostcode");
        }
    }
}
