using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();


            Student std4 = new Student();
            Student std5 = new Student();

            Console.WriteLine(std4.No);



            Console.Write("UserName: ");
            string username = Console.ReadLine();


            string password;
            do
            {
                Console.WriteLine("Password: ");
                password = Console.ReadLine();

            } while (!User.CheckPassword(password));
           

            User user = new User
            {
                UserName = username,
                Password = password
            };
            
        }
    }
}
