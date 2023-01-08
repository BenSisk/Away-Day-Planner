using awayDayPlanner.Database;
using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Security.Salting;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using UnitTesting.ValidatorTests;

namespace UnitTesting.LoginTesting
{
    [TestClass]
    public class LoginModelTests
    {
        [TestMethod]
        public void TestNullSalt()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            LoginModel model = new LoginModel();

            IUser result = model.Submit("NoSuchUser", "password");

            Assert.IsNull(result);
        }

      
        [TestMethod]
        public void TestInvalidPassword()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            LoginModel model = new LoginModel();
            IUser result = model.Submit("Admin", "TotallyIncorrect");

            Assert.IsNull(result);
        }
    }
}
