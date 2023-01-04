﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.GUI.Presenter.ControlPanel;

namespace awayDayPlanner.GUI.Model.Booking
{
    public partial class BookingModel : IBookingModel
    {
        private IBookingPresenter presenter;

        public void Register(IBookingPresenter presenter)
        {
            this.presenter = presenter;
        }

        public int Submit(List<IActivity> activities, DateTime date)
        {
            if (activities.Count > 0)
            {
                AwayDay awayday = new AwayDay();
                foreach (IActivity activity in activities)
                {
                    Database.Database.Data.Activity.Add(activity.GetObject());
                    awayday.AwayDayActivities.Add(activity.GetObject());
                }
                awayday.AwayDayDate = date;
                awayday.User = FormProvider.ControlPanelPresenter.user;
                awayday.Confirmed = false;
                awayday.CanBeConfirmed = false;
                awayday.TotalCost = 0;
                Database.Database.Data.AwayDay.Add(awayday);
                Database.Database.Data.SaveChanges();

                //GeneratePDF(awayday)
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}