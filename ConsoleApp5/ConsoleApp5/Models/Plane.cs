using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Models
{
    class Plane : Vehicle
    {
        public int WingLenth { get; set; }
        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {

        }
    }
}
