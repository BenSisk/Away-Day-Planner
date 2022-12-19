using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Database
{
    public class Database
    {
        public static ADPContext Data
        {
            get
            {

                if (_database == null)
                {
                    _database = new ADPContext();
                }

                return _database;
            }
        }

        private static ADPContext _database;
    }
}
