using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Ak47 :Gun, IGun,IFireable
    {
        public Ak47(int capacity):base(capacity)
        {

        }

        int _currentMagazine;
        public int MagazineCapacity => _magazineCapacity;

        public int CurrentMagazine 
        {
            get => _currentMagazine;
            set
            {
                if (_magazineCapacity >= value)
                    _currentMagazine = value;
            }
        }

        public void Fire()
        {
            if (_currentMagazine > 1)
                _currentMagazine -= 2;
        }
        public void ReloadMagazine()
        {
            _currentMagazine = _magazineCapacity;
        }


    }
}
