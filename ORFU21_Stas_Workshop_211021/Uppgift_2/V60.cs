using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
     class V60 : UppGift_2_Vehicle
    {
      
        public V60() : this("V60", 2020, "1G1YZ23J9P5803427", "1698726450", "Torslanda, SE", "Sedan", 200000){}

        public V60(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType, int price) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType, price) 
            {}
    }
}
