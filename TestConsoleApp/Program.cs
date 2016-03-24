﻿using Samples.Engine.Core;
using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p0 = new Person("User0");

            Person p1 = new Person(p =>
            {
                p.LastName = "Smith";
                return p.FirstName + " " + p.LastName;
            });
            p1.FirstName = "Foo";

            Func<Person, string> toStringMethod = p => p.FirstName?.ToString() + " " + p.LastName?.ToString();

            Person p2 = new Person(toStringMethod);

            System.Console.WriteLine(p0.ToString());
            System.Console.WriteLine(p1.ToString());
            System.Console.WriteLine(p2.ToString());

            System.Console.ReadLine();
        }
    }
}
