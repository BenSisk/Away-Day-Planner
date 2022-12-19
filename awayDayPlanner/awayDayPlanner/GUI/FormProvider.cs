using awayDayPlanner.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    _loginForm = new LoginForm();
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
                    _registerForm = new RegisterForm();
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
    }
}