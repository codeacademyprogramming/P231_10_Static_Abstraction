using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student.Show();

            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();

            std1.FullName = "Hikmet";
            std2.FullName = "Nermin";
            std3.FullName = "Tofiq";



            Student.Show();

            Console.WriteLine(Student.TotalCount);


        }
    }
}
