using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class PassengerVehicle:Vehicle
    {
        int passengersSeatsCount;
        public int PassengersSeatsCount { get; set; }
        public PassengerVehicle(string vt,int fc, int mpm,int psc):base(vt,fc,mpm)
        {
            PassengersSeatsCount = psc;
            VehicleLabel = 2;
        }
        public override double GetFactorUtility()
        {
            return (MaxPermissibleMass/FuelConsumption);
        }
        public override string ToString()
        {
            return base.ToString()+("\tВместимость: "+PassengersSeatsCount+" человек");
        }
    }
}
