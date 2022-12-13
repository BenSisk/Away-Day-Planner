using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner
{
    public class activityPrices
    {
        private Dictionary<string, double> prices = new Dictionary<string, double>();

        public void setPrice(string activity, double price)
        {
            if (prices.ContainsKey(activity))
            {
                prices[activity] = price;
            }
            else
            {
                prices.Add(activity, price);
            }
        }

        public double getPrice(string activity)
        {
            return prices[activity];
        }
    }
}
