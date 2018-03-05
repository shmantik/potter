using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class TruckVehicle:Vehicle
    {
        int maxCargoVolume;
        public int MaxCargoVolume { get; set; }
        int maxCargoWeight;
        public int MaxCargoWeight { get; set; }
        public TruckVehicle(string vt,int fc, int mpm, int mcv,int mcw):base(vt,fc,mpm)
        {
            MaxCargoWeight = mcw;
            MaxCargoVolume = mcv;
            VehicleLabel = 1;
        }
        public override double GetFactorUtility()
        {
            return (MaxPermissibleMass/FuelConsumption);
        }
        public override string ToString()
        {
            return base.ToString()+("\tМаксимальный объем груза: "+MaxCargoVolume+ "м3" + "\tМаксимальный груз: "+MaxCargoWeight+"кг");
        }
    }
}
