﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Source.Activities;

namespace UnitTesting.Booking
{
    class BookingModelMoc : IbookingModel
    {
        public List<IActivity> mocActivities;
        public DateTime datetime;
        public int returnValue = 0;

        public void register(IbookingPresenter presenter) { }

        public int submit(List<IActivity> activities, DateTime datetime)
        {
            this.mocActivities = activities;
            this.datetime = datetime;
            return returnValue;
        }
    }
}