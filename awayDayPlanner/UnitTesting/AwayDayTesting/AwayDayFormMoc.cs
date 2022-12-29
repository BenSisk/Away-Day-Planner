using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting.AwayDayTesting
{
    public class AwayDayFormMoc : IAwayDayForm
    {
        public DateTime datetime;
        public int count;
        public string status;
        public double price;
        public DataGridViewRow row = new DataGridViewRow();
        public DialogResult result = DialogResult.OK;
        public string message_txt;
        public string title;
        public bool haveDisplayedForm = false;
        public bool haveReset = false;

        public void register(IAwayDayPresenter presenter) { }
        public void Reset()
        {
            this.haveReset = true;
        }
        public void AddItemToDGV(DateTime datetime, int count, string status, double price)
        {
            this.datetime = datetime;
            this.count = count;
            this.status = status;
            this.price = price;
        }
        public DataGridViewRow GetSelected()
        {
            return row;
        }
        public DialogResult displayFormAsDialog(Form form)
        {
            this.haveDisplayedForm = true;
            return result;
        }
        public void Message(string message_txt, string title)
        {
            this.message_txt = message_txt;
            this.title = title;
        }
    }
}