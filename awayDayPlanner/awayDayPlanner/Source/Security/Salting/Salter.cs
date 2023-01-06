using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Security.Salting
{
    public class Salter : ISalt
    {
        public string GenerateSalt()
        {
            const string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!\"£$%^&*()0123456789";
            var builder = new StringBuilder();
            Random random = new Random((int)DateTime.Now.Ticks);

            for (var i = 0; i < 10; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
