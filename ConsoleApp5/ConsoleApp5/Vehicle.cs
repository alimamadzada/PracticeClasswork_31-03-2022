using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class Vehicle
    {
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }
        public abstract double AverageSpeed();

        public abstract void ShowInfo();
    }
    public interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        public int LeftFuelAmount { get; set; }
    }
    public interface IWheel
    {
        public int WheelThickness { get; set; }
    }
    public interface ITransmission
    {
        public int TransmissionKind { get; set; }
    }
}
