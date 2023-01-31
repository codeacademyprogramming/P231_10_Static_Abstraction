using System;
using HomeTassksLibrary;



namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink(10)
            {
                Name = "Coca Cola 1L",
                Price = 4,
            };

            drink.Price = 40;
            drink.Name = "           ";

            Console.WriteLine(drink.Price);
            Console.WriteLine(drink.Name);
        }

    }
}
