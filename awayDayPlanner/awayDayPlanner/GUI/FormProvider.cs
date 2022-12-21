using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using awayDayPlanner.GUI;
using awayDayPlanner.GUI.View.ControlPanel;
using awayDayPlanner.GUI.View.Booking;
using awayDayPlanner.GUI.View.AwayDays;
using awayDayPlanner.GUI.Presenter.ControlPanel;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.newItem;


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


        #region Control Panel

        public static ControlPanelForm ControlPanelForm
        {
            get
            {
                if (_controlPanelForm == null)
                {
                    _controlPanelForm = new ControlPanelForm();
                    _controlPanelPresenter = FormProvider.ControlPanelPresenter;
                }

                return _controlPanelForm;
            }
        }

        public static ControlPanelPresenter ControlPanelPresenter
        {
            get
            {
                if (_controlPanelPresenter == null)
                {
                    _controlPanelPresenter = new ControlPanelPresenter();
                }

                return _controlPanelPresenter;
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


        #region AwayDay

        public static AwayDayForm AwayDayForm
        {
            get
            {
                if (_awayDayForm == null)
                {
                    _awayDayForm = new AwayDayForm();
                    _awayDayPresenter = FormProvider.AwayDayPresenter;
                }

                return _awayDayForm;
            }
        }

        public static AwayDayPresenter AwayDayPresenter
        {
            get
            {
                if (_awayDayPresenter == null)
                {
                    _awayDayPresenter = new AwayDayPresenter();
                }

                return _awayDayPresenter;
            }
        }

        public static AwayDayModel AwayDayModel
        {
            get
            {
                if (_awayDayModel == null)
                {
                    _awayDayModel = new AwayDayModel();
                }

                return _awayDayModel;
            }
        }

        #endregion


        private static RegisterForm _registerForm;
        private static LoginForm _loginForm;
        private static addNewItem _addNewItem;
        private static bookingForm _bookingForm;
        private static bookingPresenter _bookingPresenter;
        private static bookingModel _bookingModel;
        private static ControlPanelForm _controlPanelForm;
        private static ControlPanelPresenter _controlPanelPresenter;
        private static AwayDayForm _awayDayForm;
        private static AwayDayPresenter _awayDayPresenter;
        private static AwayDayModel _awayDayModel;
    }
}