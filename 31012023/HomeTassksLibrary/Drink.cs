using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTassksLibrary
{
    public class Drink:Product
    {
        public Drink(double alchPercent)
        {
            _price = 5;

            if(alchPercent>=0 && alchPercent<=100)
                AlcoholPercent = alchPercent;
        }
        public readonly double AlcoholPercent;

        public override double Price
        {
            set
            {
                if (value >= 5)
                    _price = value;
            }
            get
            {
                return _price;
            }
        }
    }
}
