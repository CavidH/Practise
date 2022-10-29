using System;
using Tools;

namespace Practise
{

    internal class Program
    {
        int k;
        public int k2 { get; set; }

        static void Main(string[] args)
        {
            Program t = new Program();
            Console.WriteLine(t.k);
            Console.WriteLine(t.k2);

            //Tuple<int, string, bool> t = new Tuple<int, string, bool>(45, "salam", true);
            //Console.WriteLine(t.Item3);

            //Console.WriteLine(k.Length);
            //Console.WriteLine("Hello World!");
            //int a = 45, b = 55;
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Sum(a, b));

        }
    }
}
