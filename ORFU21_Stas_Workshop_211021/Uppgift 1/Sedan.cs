using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class Sedan : UppGift_1_Vehicle
    {
      
        public Sedan() : this("V60", 2020, "1G1YZ23J9P5803427", "1698726450", "Torslanda, SE", "Sedan"){}

        public Sedan(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType) 
            { Console.WriteLine("\n---------------------------------------------\nNew Sedan initailising..."); }
    }
}
