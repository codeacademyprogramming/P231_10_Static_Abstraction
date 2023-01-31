using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal abstract class Vehicle
    {
        public double Mileage;
        public abstract void Drive(double km);
    }
}
