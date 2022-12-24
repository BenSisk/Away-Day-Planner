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
using awayDayPlanner.GUI.View.Admin;
using awayDayPlanner.GUI.Presenter.ControlPanel;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.Model.Admin;
using awayDayPlanner.GUI.View.NewItem;

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
                    _bookingPresenter = new bookingPresenter(bookingForm, bookingModel, addNewItem);
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

        public static AwayDayActivities AwayDayActivities
        {
            get
            {
                if (_awayDayActivities == null)
                {
                    _awayDayActivities = new AwayDayActivities();
                }

                return _awayDayActivities;
            }
        }

        #endregion


        #region Admin

        public static AdminForm AdminForm
        {
            get
            {
                if (_adminForm == null)
                {
                    _adminForm = new AdminForm();
                    _adminPresenter = FormProvider.AdminPresenter;
                }

                return _adminForm;
            }
        }

        public static AdminPresenter AdminPresenter
        {
            get
            {
                if (_adminPresenter == null)
                {
                    _adminPresenter = new AdminPresenter();
                }

                return _adminPresenter;
            }
        }

        public static AdminModel AdminModel
        {
            get
            {
                if (_adminModel == null)
                {
                    _adminModel = new AdminModel();
                }

                return _adminModel;
            }
        }

        public static AdminReviewForm AdminReviewForm
        {
            get
            {
                if (_adminReviewForm == null)
                {
                    _adminReviewForm = new AdminReviewForm();
                    _adminReviewPresenter = FormProvider.AdminReviewPresenter;
                }

                return _adminReviewForm;
            }
        }

        public static AdminReviewPresenter AdminReviewPresenter
        {
            get
            {
                if (_adminReviewPresenter == null)
                {
                    _adminReviewPresenter = new AdminReviewPresenter();
                }

                return _adminReviewPresenter;
            }
        }

        public static AdminReviewModel AdminReviewModel
        {
            get
            {
                if (_adminReviewModel == null)
                {
                    _adminReviewModel = new AdminReviewModel();
                }

                return _adminReviewModel;
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
        private static AwayDayActivities _awayDayActivities;
        private static AdminForm _adminForm;
        private static AdminPresenter _adminPresenter;
        private static AdminModel _adminModel;
        private static AdminReviewForm _adminReviewForm;
        private static AdminReviewPresenter _adminReviewPresenter;
        private static AdminReviewModel _adminReviewModel;
    }
}