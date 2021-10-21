using System;
using System.Collections.Generic;
using System.Linq;

namespace ORFU21_Stas_Workshop_211021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------[VOLVO STUFF]--------------------");
            //Console.WriteLine("---------------------[Uppgift 1]--------------------");
            //UppGift_1_Vehicle car01 = new Sedan();
            //car01.ShowInfo();

            //UppGift_1_Vehicle car02 = new Crossover();
            //car02.ShowInfo();

            //UppGift_1_Vehicle car03 = new Truck();
            //car03.ShowInfo();

            Console.WriteLine("\n---------------------[Uppgift 2]--------------------");

            List<UppGift_2_Vehicle> volvoWarehouse = new List<UppGift_2_Vehicle>();
            volvoWarehouse.Add(new V60());
            volvoWarehouse.Add(new XC90());
            volvoWarehouse.Add(new V40());
            volvoWarehouse.Add(new V40());
            volvoWarehouse.Add(new XC90());
            volvoWarehouse.Add(new XC40EV());
            for (int i = 0; i < volvoWarehouse.Count; i++)
            {
                Console.WriteLine($"{volvoWarehouse[i].ModelName}");
            }

            Console.WriteLine("\n--------------(Sorted List by Type & Price)--------------\n");
            
            var sortedList = from sortType in volvoWarehouse
                        orderby sortType.ModelName, sortType.Price
                        select sortType;

            foreach (var item in sortedList)
            {
                Console.WriteLine($"Model Name: {item.ModelName, -15} - {item.Price} SEK");
            }
        }
    }
}
