using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Bicycle:Vehicle
    {
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}
