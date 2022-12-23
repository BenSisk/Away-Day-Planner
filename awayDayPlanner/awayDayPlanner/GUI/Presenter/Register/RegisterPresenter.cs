using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static awayDayPlanner.Lib.Factory.Register;

namespace awayDayPlanner.GUI
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IRegisterModel _model;

        public RegisterPresenter(IRegisterView view, IRegisterModel model)
        {
            _view = view;
            view.Presenter = this;
            _model = model;
        }

        public void Submit()
        {
            int number;

            if (!int.TryParse(_view.phone, out number))
                number = 0;

            User user = new User
            {
                firstname = _view.firstname,
                lastname = _view.surname,
                email = _view.email,
                dob = _view.dob,
                phone = number
            };

            Address address = new Address
            {
                FirstLine = _view.FirstLine,
                SecondLine = _view.SecondLine,
                PostCode = _view.PostCode
            };

            Login login = new Login()
            {
                Username = _view.Username,
                Password = _view.Password,
            };

            var result = _model.Submit(user, address, login, _view.Password2);

            foreach (KeyValuePair<RegisterErrors, string> item in result)
            {
                if (item.Key == RegisterErrors.Success)
                {
                    _view.Message("Registration Successful");
                    FormProvider.RegisterForm.Hide();
                    FormProvider.LoginForm.Show();
                }
                else
                {
                    RemovePreviousErrors(item);
                    UpdateErrorForm(item);
                }
            }
        }

        public void RemovePreviousErrors(KeyValuePair<RegisterErrors, string> error)
        {
            if (error.Key == RegisterErrors.UsernameSuccess)
                this.RemoveError(_view.labelUsername);
            if (error.Key == RegisterErrors.FirstSuccess)
                this.RemoveError(_view.labelFirstName);
            if (error.Key == RegisterErrors.SurnameSuccess)
                this.RemoveError(_view.labelSecondName);
            if (error.Key == RegisterErrors.EmailSuccess)
                this.RemoveError(_view.labelEmail);
            if (error.Key == RegisterErrors.PhoneSuccess)
                this.RemoveError(_view.labelPhone);
            if (error.Key == RegisterErrors.PasswordSuccess)
                this.RemoveError(_view.labelPassword);
        }
        public void UpdateErrorForm(KeyValuePair<RegisterErrors,string> error)
        {
            if (error.Key == RegisterErrors.ShortUsername ||
                error.Key == RegisterErrors.UsernameTaken ||
                error.Key == RegisterErrors.InvalidUsername)
                this.ShowError(_view.labelUsername, error.Value);
            if (error.Key == RegisterErrors.InvalidEmail)
                this.ShowError(_view.labelEmail, error.Value);
            if (error.Key == RegisterErrors.InvalidPhone)
                this.ShowError(_view.labelPhone, error.Value);
            if (error.Key == RegisterErrors.IncorrectPasswordSize ||
                error.Key == RegisterErrors.PasswordMismatch)
                this.ShowError(_view.labelPassword, error.Value);
            if (error.Key == RegisterErrors.FirstNameSize ||
                error.Key == RegisterErrors.SpecialCharactersFirstname)
                this.ShowError(_view.labelFirstName, error.Value);
            if (error.Key == RegisterErrors.SurnameSize ||
                error.Key == RegisterErrors.SpecialCharactersSurname)
                this.ShowError(_view.labelSecondName, error.Value);

        }

        public void ShowError(System.Windows.Forms.Control form, string errorMessage)
        {
            _view.PasswordError.SetToolTip(form, errorMessage);
            form.ForeColor = System.Drawing.Color.Red;
        }

        public void RemoveError(System.Windows.Forms.Control form)
        {
            _view.PasswordError.SetToolTip(form, null);
            form.ForeColor = System.Drawing.Color.Black;
        }

        public void Close()
        {
            _model.Close();
        }
    }
}
