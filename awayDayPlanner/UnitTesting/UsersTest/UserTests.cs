using awayDayPlanner.GUI;
using awayDayPlanner.GUI.Model;
using awayDayPlanner.GUI.Presenter.Login;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitTesting.Booking;

namespace UnitTesting.LoginTesting
{
    [TestClass]
    public class UserClassTests
    {
        [TestMethod]
        public void TestUserClassInstance()
        {
            IUser user = User.getInstance();

            Assert.IsInstanceOfType(user, typeof(IUser));

        }

        [TestMethod]
        public void TestUserSetters()
        {
            IUser user = User.getInstance();

            user.userID = 1;
            user.firstname = "Test";
            user.lastname = "Test2";
            user.email = "Test@test.com";
            user.dob = DateTime.Today;
            user.phone = 123456789;

            Assert.AreEqual(user.userID, 1);
            Assert.AreEqual(user.firstname, "Test");
            Assert.AreEqual(user.lastname, "Test2");
            Assert.AreEqual(user.email, "Test@test.com");
            Assert.AreEqual(user.dob, DateTime.Today);
            Assert.AreEqual(user.phone, 123456789);

        }



        [TestMethod]
        public void TestUsersLogin()
        {
            IUser user = User.getInstance();
            user.Login = (Login) Login.getInstance();

            Assert.IsInstanceOfType(user.Login, typeof(Login));
        }

        [TestMethod]
        public void TestUsersAddress()
        {
            IUser user = User.getInstance();
            user.Address = MockRepository.GenerateMock<IAddress>();

            Assert.IsInstanceOfType(user.Address, typeof(IAddress));
        }

        [TestMethod] public void TestAdminBool()
        {
            IUser user = User.getInstance();
            Assert.IsFalse(user.isAdmin);
        }

        [TestMethod]
        public void TestLoginFormReadOnly()
        {
            ILoginView view = MockRepository.GenerateStub<ILoginView>();
            view.Presenter = MockRepository.GenerateStub<ILoginPresenter>();

            view.Stub(x => x.Username).Return("test");
            view.Stub(x => x.Password).Return("password");

            Assert.AreEqual("test", view.Username);
            Assert.AreEqual("password", view.Password);
        }

        [TestMethod]
        public void TestLoginReset() 
        {
            ILoginView view = MockRepository.GenerateStub<ILoginView>();

            ILoginPresenter Presenter = MockRepository.GenerateStub<ILoginPresenter>();

            view.Presenter = Presenter;

            view.Expect(i => i.Reset());

            Presenter.Reset();

            view.VerifyAllExpectations();
        }

        [TestMethod]
        public void TestMessageBox()
        {
            ILoginView view = MockRepository.GenerateStub<ILoginView>();
            view.Expect(i => i.Message("this is a test"));

            view.VerifyAllExpectations();

        }
    }
}
