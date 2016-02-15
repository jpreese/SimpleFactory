using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new SimplePizzaFactory();
            var p = f.Create("Cheese");
            Console.WriteLine(p.Name);

            Console.ReadLine();
        }
    }
}
