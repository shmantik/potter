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
        
        static void PrintArray(Vehicle [] array)
        {
            foreach (Vehicle v in array)
            {
                Console.WriteLine(v);
            }
        }
        static void Main(string[] args)
        {
            void InitArray()
            {
                autopark[0] = new PassengerVehicle("пассажирский", 12, 640, 8);
                autopark[1] = new PassengerVehicle("пассажирский", 10, 480, 6);
                autopark[2] = new PassengerVehicle("пассажирский", 14, 800, 10);
                autopark[3] = new PassengerVehicle("пассажирский", 15, 3600, 12);
                autopark[4] = new TruckVehicle("грузовой", 18, 3000, 9, 2000);
                autopark[5] = new TruckVehicle("грузовой", 16, 2100, 7, 1800);
                autopark[6] = new TruckVehicle("грузовой", 14, 1800, 5, 1500);
                autopark[7] = new TruckVehicle("грузовой", 15, 1500, 4, 1000);
                autopark[8] = new SpecializedFreightVehicle("спец груз", 20, 4000, 3800, 7, "№3 от 12.04.2017", " перевозка топлива");
                autopark[9] = new SpecializedFreightVehicle("спец груз", 22, 4500, 4000, 9, "№12 от 23.06.2015", " рефрижератор");
                autopark[10] = new SpecializedFreightVehicle("спец груз", 19, 3900, 3700, 8, "№1 от 03.07.2016", " перевозка животных");
                autopark[11] = new SpecializedFreightVehicle("спец груз", 21, 5000, 4500, 10, "№10 от 23.10.2014", " перевозка металла");
            }
            InitArray();
            Console.WriteLine();
            // сортируем автотраспорт, вызывая метод сортировки из  класса Comparers
            Console.WriteLine("1.Отсортировать список транспортных средств по возрастанию расхода топлива");
            Array.Sort(autopark, new FuelComparers());
            PrintArray(autopark);

            Console.WriteLine();
            Console.WriteLine("2.Отсортировать список транспортных средств по убыванию коэффициента полезности");
            Array.Sort(autopark, (y, z) => z.GetFactorUtility().CompareTo(y.GetFactorUtility()));
            PrintArray(autopark);
            
            Console.WriteLine();
            Console.WriteLine("3.Упорядочить список по видам транспортных средств: сначала грузовые специализированные, потом пассажирские и в конце - грузовые универсальные");
            Array.Sort(autopark);
            PrintArray(autopark);
            
            Console.WriteLine();
            Console.WriteLine("4.	Вывести только пассажирские транспортные средства с максимальной допустимой массой, не превышающей 3500 кг");
            var autoParkQuery = autopark.Where(a => a.VehicleType == "пассажирский" && a.MaxPermissibleMass <= 3500);
            foreach (var a in autoParkQuery)
            {
                Console.WriteLine(a);
            }
           
            Console.ReadKey();
        }
    }
}
