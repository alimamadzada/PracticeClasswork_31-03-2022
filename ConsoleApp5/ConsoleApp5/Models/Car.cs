using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Models
{
    class Car : Vehicle, IEngine, ITransmission
    {
        public int DoorCount { get; set; }
        public string Wincode { get; set; }
        private int _horsepower;
        private int _tanksize; 
        private int _currentoil;
        private string _fueltype;
        private int _leftfuelamount;
        public int HorsePower
        {
            get { return _horsepower; }
            set
            {
                if (value > 0)
                    _horsepower = value;
            }
        }
        public int TankSize
        {
            get { return _tanksize; }
            set
            {
                if (value > 0)
                    _tanksize = value;
            }
        }
        public int CurrentOil
        {
            get { return _currentoil; }
            set
            {
                if (value > 0)
                    _currentoil = value;
            }
        }
        public string FuelType
        {
            get { return _fueltype; }
            set
            {
                _fueltype = value;
            }
        }
        public int LeftFuelAmount
        {
            get { return _leftfuelamount; }
            set
            {
                if (value > 0)
                    _leftfuelamount = value;
            }
        }
        private int _transmissionkind;
        public int TransmissionKind
        {
            get { return _transmissionkind; }
            set
            {
                if (value > 0)
                {
                    _transmissionkind =
                }

            }
        }
        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
        }
    }
}
