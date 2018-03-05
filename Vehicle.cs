using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    abstract class Vehicle
    {
        string vehicleType;
        public String VehicleType;
        private int fuelConsumption;
        public int FuelConsumption { get; set; }
        private int maxPermissibleMass;
        public int MaxPermissibleMass { get; set; }
        public Int32 VehicleLabel { get; set; }
        public Vehicle(string vt, int fc, int mpm)
        {
            VehicleType = vt;
            FuelConsumption = fc;
            MaxPermissibleMass = mpm;
        }
        public abstract double GetFactorUtility();
        public override string ToString()
        {
            return ("Тип: "+VehicleType+"\tРасход топлива: " + FuelConsumption+ " л/100км" + "\tМаксимальная масса: " + MaxPermissibleMass + " кг"  + "\tКП: " + GetFactorUtility());
        }
    }
}
