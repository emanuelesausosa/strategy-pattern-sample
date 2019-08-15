using System;
using DuckApp.Console.Domain;

namespace DuckApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            
        }
    }
}