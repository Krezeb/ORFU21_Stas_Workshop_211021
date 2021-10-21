using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class V40 : UppGift_2_Vehicle
    {
      
        public V40() : this("V40", 2020, "5Y6A23J9P5805973", "2574395014", "Torslanda, SE", "Hatchback", 150000){}

        public V40(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType, int price) 
            : base (modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType, price) 
            {}
    }
}
