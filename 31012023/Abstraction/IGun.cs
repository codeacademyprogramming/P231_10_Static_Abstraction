using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal interface IGun
    {
        int MagazineCapacity { get; }
        int CurrentMagazine { get; set; }

        void ReloadMagazine();
    }
}
