using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Train : IVehicle
    {
        double _millage;
        public void Drive(double km)
        {
            _millage += km;
        }
    }
}
