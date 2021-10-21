using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class Truck : UppGift_1_Vehicle
    {
      
        public Truck() : this("VNL 300", 2019, "1C9EB23L9P5805743", "5873014298", "Torslanda, SE", "Truck") {}

        public Truck(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType)
            { Console.WriteLine("\n---------------------------------------------\nNew Truck initailising..."); }
    }
}
