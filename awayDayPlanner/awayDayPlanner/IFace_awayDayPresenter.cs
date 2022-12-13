using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner
{
    public interface IFace_awayDayPresenter
    {
        void estimateCost();
        void setEstimatedCost(double total);
        void submit();
    }
}