using System;
using System.Collections;
using System.Globalization;
using Tools;

namespace Practise
{
    //class T
    //{
    //    string s;
    //    public T(string s)
    //    {
    //        this.s = s;
    //    }
    //    public void SetS(string s) => this.s = s;

    //    public string GetS() => this.s;
    //}
    //class A
    //{

    //}
    //class B : A { }
    //class C : B { }

    internal class Program
    {
        //int k;
        //public int k2 { get; set; }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;

                if (dateTime.Second != DateTime.Now.Second)
                {
                    dateTime = DateTime.Now;
                    Console.Clear();
                    Console.WriteLine(DateTime.Now);
 
                }
                //else
                //{
                //    Console.BackgroundColor = ConsoleColor.White;
                //}
            }


            //double a = 2144447483643933378;
            //ArrayList t = new ArrayList();
            //for (; ; )
            //{
            //    t.Add(new Program());
            //    t.AddRange(t);
            //    for (; ; )
            //    {
            //        t.Add(new Program());
            //        t.AddRange(t);
            //        for (; ; )
            //        {
            //            t.Add(new Program());
            //            t.AddRange(t);
            //            for (; ; )
            //            {
            //                t.Add(new Program());
            //                t.AddRange(t);
            //                for (; ; )
            //                {
            //                    t.Add(new Program());
            //                    t.AddRange(t);
            //                };
            //            };
            //        };
            //    };
            //};
            //for (; ; )
            //{
            //    t.Add(new Program());
            //    t.AddRange(t);
            //};
            //checked
            //{
            //    int b = (int)a;
            //    Console.WriteLine(b);

            //}
            //dynamic t = 45;
            //C c = new C();
            //object u = c;
            //t = u;
            //B b = (B)u;
            //int kt = 45;
            //object o = kt;
            //double e = (double)o;
            //Console.WriteLine(e.GetType());
            //T t= new T("salam");
            //T t1 = t;
            //T t2 = t;

            //t.SetS("Fuck");


            //Console.WriteLine(t.GetS());
            //Console.WriteLine(t1.GetS());
            //Console.WriteLine(t2.GetS());



            //string s = "Salam";
            //string t = s;
            //string k = t;


            //s = "Fuck";


            //Console.WriteLine(s);
            //Console.WriteLine(t);
            //Console.WriteLine(k);






            //Program t = new Program();
            //Console.WriteLine(t.k);

            //Console.WriteLine(t.k2);

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
