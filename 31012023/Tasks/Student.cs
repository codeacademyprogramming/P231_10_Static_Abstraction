using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student
    {
        static int _totalCount;
        static Student()
        {
            _totalCount = 100;
        }
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No;
        public string FullName;
        public byte Point;
    }
}
