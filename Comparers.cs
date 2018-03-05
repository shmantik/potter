using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class Comparers
    {
        public int CompareByFuelConsuption(Vehicle x, Vehicle y)
        {
            if (x.FuelConsumption > y.FuelConsumption)
            {
                return 1;
            }
            else
            {
                if (x.FuelConsumption == y.FuelConsumption)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
