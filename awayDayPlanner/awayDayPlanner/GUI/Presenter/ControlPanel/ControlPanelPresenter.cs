﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View;
using awayDayPlanner.GUI.View.ControlPanel;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.GUI.Presenter.ControlPanel
{
    public class ControlPanelPresenter : IControlPanelPresenter
    {
        public User user;

        private IControlPanelForm view;
        public List<ActivityType> list;

        public ControlPanelPresenter()
        {
            this.view = FormProvider.ControlPanelForm;
            view.register(this);
            LoadActivitiesFromDB();


            //BELOW IS NOT STAYING HERE
            var query = from users in Database.Database.Data.User
                        where (users.userID == 1)
                        select users;
            user = query.First();
        }

        public void newAwayDay()
        {
            FormProvider.bookingForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }

        public void viewExistingAwayDays()
        {
            FormProvider.AwayDayForm.Reset();
            FormProvider.AwayDayForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }

        private void LoadActivitiesFromDB()
        {
            var query = from activities in Database.Database.Data.ActivityOptions
                         select activities;

            list = query.ToList();
            ActivityType custom = null;

            foreach (var item in list)
            {
                if (item.ActivityTypeName != "Custom")
                {
                    ActivityFactory.ActivityFactorySingleton.RegisterActivity(item, new Activity(item));
                }
                else
                {
                    custom = item;
                }
            }

            if (custom == null)
            {
                custom = new ActivityType("Custom", 0);
                Database.Database.Data.ActivityOptions.Add(custom);
                Database.Database.Data.SaveChanges();
                list.Add(custom);
            }

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(custom, new Activity(custom));
        }

        public void LogOut()
        {
            FormProvider.AdminForm.Reset();
            FormProvider.AdminForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }
    }
}