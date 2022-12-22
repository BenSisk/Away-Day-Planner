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
                if (item == RegisterErrors.Success)
                {
                        _view.Message("Registration successful, You can now login");
                        this.Close();
                }
                if (item == RegisterErrors.PasswordMismatch)
                {
                    //_view.lbl
                    throw new NotImplementedException();
                }
            }
        }

        public void Close()
        {
            _model.Close();
        }
    }
}
