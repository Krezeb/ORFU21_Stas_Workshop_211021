using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Stas_Workshop_211021
{
    public class UppGift_2_Vehicle
    {
        private string _modelName;
        private int _yearOfManufacture;
        private string _VIN;
        private string _engineSerial;
        private string _manufactureLocation;
        private string _vehicleType;
        private int _price;

        public virtual string ModelName { get { return _modelName; } init { _modelName = value; } }
        public virtual int YearOfManufacture { get { return _yearOfManufacture; } init { _yearOfManufacture = value; } }
        public virtual string VIN { get { return _VIN; } init { _VIN = value; } }
        public virtual string EngineSerial { get { return _engineSerial; } init { _engineSerial = value; } }
        public virtual string ManufactureLocation { get { return _manufactureLocation; } init { _manufactureLocation = value; } }
        public virtual string VehicleType { get { return _vehicleType; } init { _vehicleType = value; } }
        public virtual int Price { get { return _price; } init { _price = value; } }

        protected UppGift_2_Vehicle(string modelName, int yearOfManufacture, string VIN, string engineSerial, string manufactureLocation, string vehicleType, int price)
        {
            _modelName = modelName;
            _yearOfManufacture = yearOfManufacture;
            _VIN = VIN;
            _engineSerial = engineSerial;
            _manufactureLocation = manufactureLocation;
            _vehicleType = vehicleType;
            _price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine(_modelName);
            Console.WriteLine(_vehicleType);
            Console.WriteLine(_yearOfManufacture);
            Console.WriteLine(_VIN);
            Console.WriteLine(_engineSerial);
            Console.WriteLine(_manufactureLocation);
            Console.WriteLine(_price);
        }
    }
}
