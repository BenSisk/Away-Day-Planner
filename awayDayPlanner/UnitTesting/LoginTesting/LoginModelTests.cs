using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting.LoginTesting
{
    [TestClass]
    public class LoginModelTests
    {
        [TestMethod]
        public void TestNullSalt()
        {
            LoginModel model = new LoginModel();

            IUser result = model.Submit("NoSuchUser", "password");

            Assert.IsNull(result);
        }

        [TestMethod]

        public void TestValidLogins()
        {
            LoginModel model = new LoginModel();
            IUser result = model.Submit("Admin", "password");

            Assert.IsInstanceOfType(result, typeof(IUser));
        }

        [TestMethod]
        public void TestInvalidPassword()
        {
            LoginModel model = new LoginModel();
            IUser result = model.Submit("Admin", "TotallyIncorrect");

            Assert.IsNull(result);
        }
    }
}
