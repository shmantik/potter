using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class SpecializedFreightVehicle:TruckVehicle // Наследуемый класс Спец грузовой транспорт от класса TruckVehicle (грузовой транспорт)
    {
        public string NumberDateInspection { get; set; } // Номер и дата последнего осведетельствования авто
        public string Specialization { get; set; } // специализация перевозимого груза
       
        
        // конструктор с параметрами для Спец грузовых авто
        // наследует  параметры:
        // vehicleType - тип атотранспорта,   
        //fuelConsumption - расход топлива, maxPermissibleMass - максимально допустимая масса,
        // maxCargoWeight - максимальная масса перевозимого груза, maxCargoVolume - максимальный обьем перевозимого груза
        public SpecializedFreightVehicle(string vehicleType, int fuelConsumption, int maxPermissibleMass, int maxCargoWeight,int maxCargoVolume, string numberDateInspection, string specialization) :base(vehicleType,fuelConsumption,maxPermissibleMass,maxCargoWeight,maxCargoVolume)
        {
            MaxCargoWeight = maxCargoWeight;
            NumberDateInspection = numberDateInspection;
            Specialization = specialization;
            FuelConsumption = fuelConsumption;
        }

        // метод для определения коэф полезности для спец груз авто
        public override double GetFactorUtility() 
        {
            return ((MaxCargoWeight/FuelConsumption))*1.3 ;
        }
        //public override string ToString()
        //{
        //    return base.ToString()+("\tОсвидетельствование: "+NumberDateInspection+"\tСпециализация: "+Specialization);
        //}
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
