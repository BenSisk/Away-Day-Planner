using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.GUI.View.Admin;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting.AdminTesting
{
    public class AdminReviewFormMoc : IAdminReviewForm
    {
        public bool hasRegistered;
        public bool hasReset;
        public List<ActivityType> typeList = new List<ActivityType>();
        public List<string> nameList = new List<string>();
        public List<double> priceList = new List<double>();
        public string text;
        public string title;
        public DataGridViewRowCollection rowCollection;
        public bool hasExit;

        public void Register(IAdminReviewPresenter presenter)
        {
            this.hasRegistered = true;
        }

        public void Reset()
        {
            this.hasReset = true;
        }

        public void AddItemToDGV(ActivityType Type, string name, double price)
        {
            this.typeList.Add(Type);
            this.nameList.Add(name);
            this.priceList.Add(price);
        }

        public void Exit()
        {
            this.hasExit = true;
        }

        public DataGridViewRowCollection GetPrices()
        {
            return rowCollection;
        }

        public void Message(string text, string title)
        {
            this.text = text;
            this.title = title;
        }
    }
}
