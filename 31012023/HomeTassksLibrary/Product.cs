using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTassksLibrary
{
    public class Product
    {
        private string _name;
        public string Name
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2 && value.Length <= 20)
                    _name = value;
            }
            get => _name;
        }

        protected double _price;

        public virtual double Price
        {
            set
            {
                if(value>=0)
                 _price = value;
            }
            get => _price;
        }
    }
}
