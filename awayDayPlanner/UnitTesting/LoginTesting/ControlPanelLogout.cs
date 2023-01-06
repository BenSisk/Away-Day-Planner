using awayDayPlanner.GUI.Presenter.ControlPanel;
using awayDayPlanner.GUI.View.ControlPanel;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;
using UnitTesting.ValidatorTests;

namespace UnitTesting.LoginTesting
{
    [TestClass]
    public class ControlPanelLogout
    {
        [TestMethod]
        public void PresenterSetsUserToNull()
        {
            IControlPanelForm view = MockRepository.GenerateMock<IControlPanelForm>();
            ControlPanelPresenter presenter = new ControlPanelPresenter(view);

            IUser user = new UserMock();
            User.UpdateInstance(user);

            presenter.LogOut();
            user = User.getInstance();
            Assert.IsNull(user);
        }
    }
}
