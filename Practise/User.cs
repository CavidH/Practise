using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class A
    {
         static A()
        {

        }
        public virtual void T()
        {
            Console.WriteLine("A");
        }
        public int MyProperty
        {
            get { return MyProperty; }
            set { MyProperty = value; }
        }
    }
    class B : A { public override void T() { Console.WriteLine("B"); } }
    class C : B { public override void T() { Console.WriteLine("C"); } }
    internal class User
    {
        // private class Foo
        // {
        //     public Foo():this("kjkj")
        //     {

        //     }
        //     private Foo(string s) { }

        // }
        //public class Foo2
        // {

        // }
    }
}
