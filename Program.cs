using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansportApp
{
    class Program
    {
       static Vehicle[] autopark = new Vehicle[12];
        static void Main(string[] args)
        {
            void InitArray()
            {
                autopark[0] = new PassengerVehicle("пассажирский",12, 640, 8);
                autopark[1] = new PassengerVehicle("пассажирский",10, 480, 6);
                autopark[2] = new PassengerVehicle("пассажирский",14, 800, 10);
                autopark[3] = new PassengerVehicle("пассажирский",15, 960, 12);
                autopark[4] = new TruckVehicle("грузовой",18, 3000, 9, 2000);
                autopark[5] = new TruckVehicle("грузовой",16, 2100, 7, 1800);
                autopark[6] = new TruckVehicle("грузовой",14, 1800, 5, 1500);
                autopark[7] = new TruckVehicle("грузовой",15, 1500, 4, 1000);
                autopark[8] = new SpecializedFreightVehicle("спец груз",20, 4000, "№3 от 12.04.2017", " перевозка топлива");
                autopark[9] = new SpecializedFreightVehicle("спец груз", 22, 4500, "№12 от 23.06.2015", " рефрижератор");
                autopark[10] = new SpecializedFreightVehicle("спец груз", 19, 3900, "№1 от 03.07.2016", " перевозка животных");
                autopark[11] = new SpecializedFreightVehicle("спец груз", 21, 5000, "№10 от 23.10.2014", " перевозка металла");
            }
            void PrintArray()
            {
                foreach(Vehicle v in autopark)
                {
                    Console.WriteLine(v);
                }
            }
            int CompareByFuelConsuption(Vehicle x, Vehicle y)
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
            int CompareByFactorUtility(Vehicle x, Vehicle y)
            {
                if (x.GetFactorUtility() < y.GetFactorUtility())
                {
                    return 1;
                }
                else
                {
                    if (x.GetFactorUtility() == y.GetFactorUtility())
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            int SortByVehicleLable(Vehicle x, Vehicle y)
            {
                if (x.VehicleLabel < y.VehicleLabel)
                {
                    return 1;
                }
                else
                {
                    if (x.VehicleLabel == y.VehicleLabel)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            void GetLightCar()
            {
                foreach(Vehicle v in autopark)
                {
                    if (v.MaxPermissibleMass <= 3500)
                    {
                        Console.WriteLine(v); 
                    }
                }
            }
            InitArray();
            
            Console.WriteLine();
            Console.WriteLine("1.Отсортировать список транспортных средств по возрастанию расхода топлива");
            Array.Sort(autopark,CompareByFuelConsuption);
            PrintArray();
            Console.WriteLine();
            Console.WriteLine("2.Отсортировать список транспортных средств по убыванию коэффициента полезности");
            Array.Sort(autopark, CompareByFactorUtility);
            PrintArray();
            Console.WriteLine();
            Console.WriteLine("3.Упорядочить список по видам транспортных средств: сначала грузовые специализированные, потом пассажирские и в конце - грузовые универсальные");
            Array.Sort(autopark, SortByVehicleLable);
            PrintArray();
            Console.WriteLine();
            Console.WriteLine("4.	Вывести только пассажирские транспортные средства с максимальной допустимой массой, не превышающей 3500 кг");
            GetLightCar();
            Console.ReadKey();

            
        }
    }
}
