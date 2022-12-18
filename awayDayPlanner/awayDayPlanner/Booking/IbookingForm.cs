﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public interface IbookingForm
    {
        void register(IbookingPresenter presenter);
        void message(string message);
        DialogResult displayFormAsDialog(Form form);
        void addItemToDGV(Activity activity, string customName, string notes);
        DataGridViewRowCollection getItinerary();
    }
}