using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.View.Booking;
using awayDayPlanner.GUI.newItem;
using awayDayPlanner.GUI;

namespace awayDayPlanner.GUI
{
    public class FormProvider
    {
        #region Login System
        public static LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    var model = new Model.LoginModel();

                    _loginForm = new LoginForm();
                    _loginForm.Presenter = new LoginPresenter(_loginForm, model);
                }

                return _loginForm;
            }
        }

        public static ControlPanelForm ControlPanelForm
        {
            get
            {
                if (_controlPanel == null)
                {
                    _controlPanel = new ControlPanelForm();
                }

                return _controlPanel;
            }
        }

        public static RegisterForm RegisterForm
        {
            get
            {
                if (_registerForm == null)
                {
                    var model = new Model.RegisterModel();
                    _registerForm = new RegisterForm();
                    _registerForm.Presenter = new RegisterPresenter(_registerForm, model);
                }

                return _registerForm;
            }
        }
        #endregion

        #region Booking System
        public static bookingForm bookingForm
        {
            get
            {
                if (_bookingForm == null)
                {
                    _bookingForm = new bookingForm();
                    _bookingPresenter = FormProvider.bookingPresenter;
                }

                return _bookingForm;
            }
        }

        public static bookingPresenter bookingPresenter
        {
            get
            {
                if (_bookingPresenter == null)
                {
                    _bookingPresenter = new bookingPresenter();
                }

                return _bookingPresenter;
            }
        }

        public static bookingModel bookingModel
        {
            get
            {
                if (_bookingModel == null)
                {
                    _bookingModel = new bookingModel();
                }

                return _bookingModel;
            }
        }

        public static addNewItem addNewItem
        {
            get
            {
                if (_addNewItem == null)
                {
                    _addNewItem = new addNewItem();
                }

                return _addNewItem;
            }
        }
        #endregion

        private static RegisterForm _registerForm;
        private static LoginForm _loginForm;
        private static addNewItem _addNewItem;
        private static bookingForm _bookingForm;
        private static bookingPresenter _bookingPresenter;
        private static bookingModel _bookingModel;
        private static ControlPanelForm _controlPanel;
    }
}