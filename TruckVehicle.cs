using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class TruckVehicle:Vehicle // Класс грузовые наследуемый от класса автотраспорт и является базовым для класса спец груз авто
    {
        public int MaxCargoVolume { get; set; } // максимальный перевозимый объем груза
        public int MaxCargoWeight { get; set; } // максимальна масса перевозимого груза

        // Конструктор с параметрами для грузовых машин, наследует из базового класса
        // vehicleType - тип атотранспорта,   
        //fuelConsumption- расход топлива, maxPermissibleMass - максимально допустимая масса

        public TruckVehicle(string vehicleType,int fuelConsumption, int maxPermissibleMass, int maxCargoVolume,int maxCargoWeight):base(vehicleType,fuelConsumption,maxPermissibleMass)
        {
            MaxCargoWeight = maxCargoWeight;
            MaxCargoVolume = maxCargoVolume;
           
        }
        public override double GetFactorUtility() // метод для определения коэф полезности
        {
            return (MaxCargoWeight/FuelConsumption);
        }
        //public override string ToString()
        //{
        //    return base.ToString()+("\tМаксимальный объем груза: "+MaxCargoVolume+ "м3" + "\tМаксимальный груз: "+MaxCargoWeight+"кг");
        //}
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
