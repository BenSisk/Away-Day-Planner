using awayDayPlanner.GUI.Presenter.Booking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting.Booking
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();
            bookingPresenter presenter = new bookingPresenter(view, model);

            presenter.submit();
        }
    }
}
