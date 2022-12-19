using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Firstline = _view.firstline,
                SecondLine = _view.secondline,
                PostCode = _view.postcode
            };

            _model.Submit(user, address);
        }

        public void Close()
        {
            _model.Close();
        }
    }
}
