using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;


namespace awayDayPlanner.GUI
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IRegisterModel _model;
        private static RegisterPresenter instance = null;


        private RegisterPresenter()
        {
            _view = RegisterForm.getInstance();
            _model = RegisterModel.getInstance();
        }

        public static RegisterPresenter getInstance()
        {
            if (instance == null)
                instance = new RegisterPresenter();
            return instance;
        }
        public void Submit()
        {
            int number;

            if (!int.TryParse(_view.phone, out number))
                number = 0;

            User user = User.getInstance();
            user.firstname = _view.firstname;
            user.lastname = _view.surname;
            user.email = _view.email;
            user.dob = _view.dob;
            user.phone = number;

            Address address = Address.getInstance();
            address.FirstLine = _view.FirstLine;
            address.SecondLine = _view.SecondLine;
            address.PostCode = _view.PostCode;

            Login login = Login.getInstance();

            login.Username = _view.Username;
            login.Password = _view.Password;

            var result = _model.Submit(_view.Password2);

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

        private void RemovePreviousErrors(KeyValuePair<RegisterErrors, string> error)
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
        private void UpdateErrorForm(KeyValuePair<RegisterErrors,string> error)
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

        private void ShowError(System.Windows.Forms.Control form, string errorMessage)
        {
            _view.PasswordError.SetToolTip(form, errorMessage);
            form.ForeColor = System.Drawing.Color.Red;
        }

        private void RemoveError(System.Windows.Forms.Control form)
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
