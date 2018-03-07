using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class PassengerVehicle:Vehicle // класс пассажирский автотранспорт наследуемый от класса Vehicle (автотранспорт)
    {
        
        public int PassengersSeatsCount { get; set; } // кол-во пассажирских мест

        // конструктор с параметрами, наследует от базового класса параметры:
        // maxPermissibleMass - максимально допустимая масса,
        // vehicleType - вид автотраспорта,
        // fuelConsumption - расход топлива
        public PassengerVehicle(string vehicleType,int fuelConsumption, int maxPermissibleMass,int passengersSeatsCount) :base(vehicleType, fuelConsumption, maxPermissibleMass) 
        {
            PassengersSeatsCount = passengersSeatsCount;
        }
        public override double GetFactorUtility()
        {
            return ((PassengersSeatsCount*80)/FuelConsumption);
        }
        //public override string ToString()
        //{
        //    return base.ToString()+("\tВместимость: "+PassengersSeatsCount+" человек");
        //}
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
