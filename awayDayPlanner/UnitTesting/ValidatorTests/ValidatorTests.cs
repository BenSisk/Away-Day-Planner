using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTesting.ValidatorTests
{
    [TestClass]
    public class ValidatorTests
    {

        [TestMethod]
        public void ValidateFirstNameIsNotNull()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = null;
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.EmptyFirstName);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSurnameIsNotNull()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = null;
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.EmptySurname);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateShortFirstName()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.FirstNameSize);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateShortSurname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = "";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SurnameSize);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateLongSurname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = "abcdefghisjltygbcaznthsdfgdfgdfgsdfsdfsdfsdferbbdf";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SurnameSize);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateLongFirstnamee()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "abcdefghisjltygbcaznthsdfgerdfgdfbbdf";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.FirstNameSize);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSpecialCharsFirstname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "$%^$$%^";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SpecialCharactersFirstname);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSpecialCharsSurname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = "$%^$$%^";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SpecialCharactersSurname);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateFirstnameCantBeNumeric()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "123456";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.FirstNameHasDigits);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSurnnameCantBeNumeric()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = "123456";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SurnameHasDigits);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSuccessfulFirstname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "Anthony";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.FirstSuccess);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSuccessfulSurname()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.lastname = "Anthony";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.SurnameSuccess);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidatePasswordSize()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            login.Password = "1234";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "1234", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.IncorrectPasswordSize);
            Assert.IsTrue(TestResult);
        }
        [TestMethod]
        public void ValidatePasswordMismatch()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            login.Password = "password";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "Password", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.PasswordMismatch);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidatePasswordSuccess()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            login.Password = "123456";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.PasswordSuccess);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateEmail1Char()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.email = "1";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.InvalidEmail);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateEmailwithoutAt()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.email = "12342342.com";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.InvalidEmail);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateEmailwithAt()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.email = "123423@42";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.InvalidEmail);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateEmailSuccess()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.email = "123423@42.com";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.EmailSuccess);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateEmailEndsInDot()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.email = "123423@42.";
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.InvalidEmail);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidatePhoneIsNot1Char()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.phone = 0;
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.InvalidPhone);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidatePhoneSuccess()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.phone = 0234567891;
            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "123456", new Validator());

            // finish checking
            bool TestResult = verified.ContainsKey(RegisterErrors.PhoneSuccess);
            Assert.IsTrue(TestResult);
        }

        [TestMethod]
        public void ValidateSuccesfulDetails()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            IUser user = new UserMock();
            ILogin login = new LoginMock();
            IAddress address = new AddressMock();

            user.firstname = "Anthony";
            user.lastname = "Anthony";
            user.phone = 0234567891;
            user.email = "as@as.com";
            login.Password = "password";
            login.Username = "AdminTest";

            var verified = awayDayPlanner.Source.Security.Validator.Validate.ValidateRegister(login,
                                         user,
                                         address,
                                         "password", new Validator());

            bool TestResult = verified.ContainsKey(RegisterErrors.Success);
            Assert.IsTrue(TestResult);
        }
    }
}
