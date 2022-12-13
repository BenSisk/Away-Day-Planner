using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner
{
    public interface IFace_awayDayModel
    {
        void register(IFace_awayDayPresenter presenter);
        void estimateCost(List<string> activities);
        int submit(List<string> activities);
    }
}
