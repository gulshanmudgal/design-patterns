using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Espresso();
            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine();

            coffee = new WithMilk(coffee);
            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine();
        }
    }
}
