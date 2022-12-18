using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Booking
{
    public interface IbookingModel
    {
        void register(IbookingPresenter presenter);
        int submit(List<string> activities);
    }
}
