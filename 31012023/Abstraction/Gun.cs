﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal abstract class Gun
    {
        protected int _magazineCapacity;
        public Gun(int capacity)
        {
            _magazineCapacity = capacity;
        }
    }
}
