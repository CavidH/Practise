using System;
using Tools;

namespace Practise
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 45, b = 55;
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(a, b));

        }
    }
}
