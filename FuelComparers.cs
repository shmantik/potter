using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class FuelComparers : IComparer<Vehicle>// класс для сортировки по возрастанию расхода топлива
    {

        public int Compare(Vehicle x, Vehicle y)
        {
            return x.FuelConsumption.CompareTo(y.FuelConsumption);
        }
    }
}
