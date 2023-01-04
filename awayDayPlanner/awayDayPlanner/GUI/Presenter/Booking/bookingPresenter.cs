using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.GUI.View.Booking;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.View.NewItem;

namespace awayDayPlanner.GUI.Presenter.Booking
{
    public partial class BookingPresenter : IBookingPresenter
    {
        private IBookingModel model;
        private IBookingForm view;
        private IAddNewItem newItemForm;
        private List<IActivity> activities = new List<IActivity>();

        public BookingPresenter(IBookingForm view, IBookingModel model, IAddNewItem newItemForm)
        {
            this.view = view;
            this.model = model;
            this.newItemForm = newItemForm;
            view.Register(this);
            model.Register(this);
        }

        public void Submit()
        {
            if (model.Submit(this.activities, view.GetDate()) == 0)
            {
                view.Message("Application Submitted Successfully");
                this.Close();
            }
            else
            {
                view.Message("Something went wrong.");
            }
        }

        public void AddActivity()
        {
            if (view.DisplayFormAsDialog(newItemForm) == DialogResult.OK)
            {
                //call a factory to create an activity object with activity type, name and notes
                var activity = newItemForm.GetActivityType();
                string custom = newItemForm.GetCustomRequest().ToString();
                string notes = newItemForm.GetNotes().ToString();

                IActivity activityInstance = ActivityFactory.ActivityFactorySingleton.GetActivityInstance(activity);
                activityInstance.Type = activity;
                activityInstance.Name = custom;
                activityInstance.Notes = notes;

                activities.Add(activityInstance);
                view.AddItemToDGV(activityInstance.Name, activityInstance.Notes, activityInstance.Type.ActivityTypeEstimatedPrice);
            }
        }

        public void DeleteRows(DataGridViewSelectedRowCollection rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                this.activities.RemoveAt(row.Index);
                view.DeleteRow(row);
            }
        }

        public void Close()
        {
            FormProvider.BookingForm.Hide();
            FormProvider.ControlPanelForm.Show();
            activities.Clear();
            view.Reset();
        }
    }
}