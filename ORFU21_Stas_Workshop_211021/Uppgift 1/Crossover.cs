using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class Crossover : UppGift_1_Vehicle
    {
      
        public Crossover() : this("XC40 Recharge", 2021, "7J1CB23L9P5808432", "5982578631", "Torslanda, SE", "Crossover") {}

        public Crossover(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType)
            {Console.WriteLine("\n---------------------------------------------\nNew Crossover initailising...");}
    }
}
