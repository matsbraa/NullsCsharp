using System;
using System.Collections.Generic;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void DoStuff(string? ns)            
        {
            Console.WriteLine(ns.Length);     // WARNING: may be null
            if (ns != null)
            {
                Console.WriteLine(ns.Length); // ok, not null here 
            }
            if (ns == null)
            {
                return;               // not null after this
            }
            Console.WriteLine(ns.Length);     // ok, not null here
            ns = null;                // null again!
            Console.WriteLine(ns.Length);     // WARNING: may be null
        }
        void DoStuff2(Person p)
        {
            Console.WriteLine(p.MiddleName.Length);  // WARNING: may be null
            Console.WriteLine(p.MiddleName!.Length); // ok, you know best!
        }

    }
}
