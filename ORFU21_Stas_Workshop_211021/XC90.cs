using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class XC90 : UppGift_2_Vehicle
    {
      
        public XC90() : this("XC90", 2019, "1C9EB23L9P5805743", "5873014298", "Torslanda, SE", "Truck", 250000) {}

        public XC90(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType, int price) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType, price)
            {}
    }
}
