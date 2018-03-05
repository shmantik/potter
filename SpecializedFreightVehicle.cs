using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class SpecializedFreightVehicle:Vehicle
    {
        string numberDateInspection;
        public string NumberDateInspection { get; set; }
        string specialization;
        public string Specialization { get; set; }
        public SpecializedFreightVehicle(string vt, int fc, int mpm, string ndi, string spec):base(vt,fc,mpm)
        {
            NumberDateInspection = ndi;
            Specialization = spec;
            VehicleLabel = 3;
        }
        public override double GetFactorUtility()
        {
            return ((MaxPermissibleMass/FuelConsumption)*1.3) ;
        }
        public override string ToString()
        {
            return base.ToString()+("\tОсвидетельствование: "+NumberDateInspection+"\tСпециализация: "+Specialization);
        }
    }
}
