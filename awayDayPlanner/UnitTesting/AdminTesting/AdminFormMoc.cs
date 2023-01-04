using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View.Admin;
using awayDayPlanner.GUI.Presenter.Admin;
using System.Windows.Forms;

namespace UnitTesting.AdminTesting
{
    public class AdminFormMoc : IAdminForm
    {
        public DialogResult result;
        public bool hasRegistered;
        public bool hasReset;
        public DataGridViewRow row;
        public List<DateTime> datetime = new List<DateTime>();
        public List<int> activityCount = new List<int>();
        public List<double> price = new List<double>();
        public int numberAdded = 0;

        public void Register(IAdminPresenter presenter)
        {
            this.hasRegistered = true;
        }
        public void AddItemToDGV(DateTime datetime, int count, double price)
        {
            this.datetime.Add(datetime);
            this.activityCount.Add(count);
            this.price.Add(price);
            this.numberAdded += 1;
        }

        public void Reset()
        {
            this.hasReset = true;
        }

        public DialogResult DisplayFormAsDialog(Form form)
        {
            return result;
        }

        public DataGridViewRow GetSelected()
        {
            return row;
        }

    }
}
