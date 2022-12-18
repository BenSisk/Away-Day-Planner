using awayDayPlanner.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public partial class bookingPresenter : IbookingPresenter
    {
        private IbookingModel model;
        private IbookingForm view;

        public bookingPresenter()
        {
            this.view = FormProvider.bookingForm;
            this.model = FormProvider.bookingModel;
            view.register(this);
            model.register(this);
            this.initialiseForm();
        }

        private void initialiseForm()
        {

        }

        public void submit()
        {
            if (model.submit(this.getActivityList()) == 0)
            {
                view.message("Application Submitted Successfully");
            }
            else
            {
                view.message("Something went wrong.");
            }
        }


        private List<string> getActivityList()
        {
            List<string> activities = new List<string>();
            return activities;
        }

        public void addActivity()
        {
            var itemForm = FormProvider.addNewItem;
            if(view.displayFormAsDialog(itemForm) == DialogResult.OK)
            {
                Activity activity = itemForm.getActivityType();
                string custom = itemForm.getCustomRequest().ToString();
                string notes = itemForm.getNotes().ToString();
                view.addItemToDGV(activity, custom, notes);
            }
        }
    }
}