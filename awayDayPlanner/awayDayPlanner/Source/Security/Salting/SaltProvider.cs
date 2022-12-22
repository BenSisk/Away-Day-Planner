using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Security.Salting
{
    internal class SaltProvider
    {
        public static string GenerateSalt(ISalt salter)
        {
            return salter.GenerateSalt();
        }
    }
}
