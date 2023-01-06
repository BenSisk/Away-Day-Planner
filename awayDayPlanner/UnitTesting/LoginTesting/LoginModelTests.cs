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
            LoginModel model = new LoginModel();

            IUser result = model.Submit("NoSuchUser", "password");

            Assert.IsNull(result);
        }

        [TestMethod]

        public void TestValidLogins()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            // Check if the user exists before adding this user, incase of empty database
            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "Admin";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.UsernameTaken);
            if(!TestResult)
            {
                login.Salt = SaltProvider.GenerateSalt(new Salter());

                login.Password = login.Password + login.Salt;
                login.Password = HashProvider.Hash(login.Password, new SHA256Hasher());

                IAddress address1 = address;
                Database.Data.Address.Add((Address)address1);
                user.Address = address;
                user.Login = (Login)login;
                Database.Data.User.Add((User)user);
                Database.Data.Login.Add((Login)login);

                Database.Data.SaveChanges();
            
            }

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
