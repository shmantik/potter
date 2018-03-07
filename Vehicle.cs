using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp  
{
    abstract class Vehicle : IComparable<Vehicle> // Базовый абстрактный класс автонтраспорт
    {
        public string VehicleType { get; set; } //  определения типа авто
        public int FuelConsumption { get; set; } //  расход топлива
        public int MaxPermissibleMass { get; set; } //Максимально допустимая масса
        
        // базовый конструктор с параметрами автотраспорта
        // vehicleType - тип атотранспорта,   
        //fuelConsumption- расход топлива, maxPermissibleMass - максимально допустимая масса
        public Vehicle(string vehicleType, int fuelConsumption, int maxPermissibleMass) 
        {
            VehicleType = vehicleType;
            FuelConsumption = fuelConsumption;
            MaxPermissibleMass = maxPermissibleMass;
        }

        public abstract double GetFactorUtility(); // абстрактный метод вычисления коэф полезности
        
        public override string ToString() // базовый метод ToString для вывода данных об авто на консолль
        {
            return ("Тип:"+VehicleType+"  Расход топлива: " + FuelConsumption+ " л/100км" + "  Максимальная масса: " + MaxPermissibleMass + " кг"  + "  КП: " + GetFactorUtility());
        }

        // Метод сортировки по типу транспорта, выводит сначала спец грузовые, потом пассажирские и в конце грузоые
        public int CompareTo(Vehicle v)
        {
            if (v is SpecializedFreightVehicle)
            {
                return 1;
            }
            else if (v is TruckVehicle)
            {
                return -1;
            }
            return 0;
        }
        



    }
}
