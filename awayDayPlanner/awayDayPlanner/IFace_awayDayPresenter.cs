using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner
{
    public interface IFace_awayDayPresenter
    {
        void submit();
        void register(IFace_awayDayForm view);
        void register(IFace_awayDayModel model);
    }
}