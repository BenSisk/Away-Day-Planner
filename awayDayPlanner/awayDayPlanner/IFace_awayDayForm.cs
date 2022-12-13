using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner
{
    public interface IFace_awayDayForm
    {
        void register(IFace_awayDayPresenter presenter);
        Boolean getActivity1 { get; }
        Boolean getActivity2 { get; }
        Boolean getActivity3 { get; }
        void setEstimatedCost(string total);
        void message(string message);
    }
}