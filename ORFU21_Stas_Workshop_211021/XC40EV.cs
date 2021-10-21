using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class XC40EV : UppGift_2_Vehicle
    {
      
        public XC40EV() : this("XC40 Recharge", 2021, "7J1CB23L9P5808432", "5982578631", "Torslanda, SE", "Crossover", 300000) {}

        public XC40EV(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType, int price)
            : base(modelName, yearOfManufacture, VIN, engineSerial, manufactureLocation, vehicleType, price)
            {}
    }
}
