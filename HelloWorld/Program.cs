using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the Value of a : ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Class1.Add(5, 6);
        }
    }
}
