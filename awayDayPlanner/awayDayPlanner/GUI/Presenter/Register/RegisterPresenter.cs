using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
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
            User user = new User
            {
                firstname = _view.firstname,
                lastname = _view.surname,
                email = _view.email,
                dob = _view.dob,
                phone = _view.phone
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

            foreach (var item in result)
            {
                Console.WriteLine(item);
                if (item == RegisterErrors.Success)
                {
                    _view.Message("Registration successful, You can now login");
                    this.Close();
                }

                if (item == RegisterErrors.FirstNameSize)
                {
                    this.ShowError(_view.labelFirstName, "Firstname cannot be empty");
                    _view.labelFirstName.ForeColor = System.Drawing.Color.Red;
                }

                if (item == RegisterErrors.SurnameSize)
                {
                    this.ShowError(_view.labelSecondName, "Surname cannot be empty");
                    _view.labelSecondName.ForeColor = System.Drawing.Color.Red;
                }

                if (item == RegisterErrors.PasswordMismatch)
                {
                    this.ShowError(_view.labelPassword, "Password Mismatch");
                    _view.labelPassword.ForeColor = System.Drawing.Color.Red;
                }
                else if (item == RegisterErrors.IncorrectPasswordSize)
                {
                    this.ShowError(_view.labelPassword, "Incorrect Password size");
                    _view.labelPassword.ForeColor = System.Drawing.Color.Red;
                }
                else if (item == RegisterErrors.PasswordSuccess)
                {
                    _view.PasswordError.SetToolTip(_view.labelPassword, null);
                    _view.labelPassword.ForeColor = System.Drawing.Color.Black;
                }

                _view.PasswordError.Active = true;
            }
        }

        public void ShowError(System.Windows.Forms.Control form, string errorMessage)
        {
            _view.PasswordError.SetToolTip(form, errorMessage);
            _view.PasswordError.Show(form);
        }

        public void Close()
        {
            _model.Close();
        }
    }
}
