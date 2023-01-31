using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
        public Student()
        {
            TotalCount++;
        }
        public int No;
        static public int TotalCount;
        public string FullName;
        public byte Point;

        public static void Show()
        {
            Console.WriteLine();
        }

    }
}
