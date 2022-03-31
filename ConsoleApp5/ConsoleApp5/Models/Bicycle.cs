using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Models
{
    class Bicycle : Vehicle,IWheel
    {
        public int PedalKind { get; set; }
        public int WheelThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double AverageSpeed()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {

        }
    }
}
