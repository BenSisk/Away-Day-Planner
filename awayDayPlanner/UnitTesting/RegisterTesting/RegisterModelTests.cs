using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.ValidatorTests;

namespace UnitTesting.RegisterTesting
{
    [TestClass]
    public class RegisterModelTests
    {
        [TestMethod]
        public void EmptyAddress()
        {
            RegisterModel model = new RegisterModel();

            IAddress address = null;

            IUser user = new UserMock();
            ILogin login = new LoginMock();

            var results = model.Submit("password", user, login, address);

            Assert.IsNull(results);
        }

        [TestMethod]
        public void EmptyUser()
        {
            RegisterModel model = new RegisterModel();

            IAddress address = new AddressMock();

            IUser user = null;
            ILogin login = new LoginMock();

            var results = model.Submit("password", user, login, address);

            Assert.IsNull(results);
        }

        [TestMethod]
        public void EmptyLogin()
        {
            RegisterModel model = new RegisterModel();

            IAddress address = new AddressMock();

            IUser user = new UserMock();
            ILogin login = null;

            var results = model.Submit("password", user, login, address);

            Assert.IsNull(results);
        }
    }
}
