﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("mewo meow");
        }
    }
}
