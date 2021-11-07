using System;

namespace ConsoleAppDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing Singleton design pattern
            Console.WriteLine("Singleton One Test!");
            var obj1 = SingletonOne.CreateSingletonObject;
            var obj2 = SingletonOne.CreateSingletonObject;
            //Following console outputs show the same hashcode which means both objects use a single instance.
            //Simply, we have implemented singleton design pattern here!!
            Console.WriteLine("Object 1 hash value :"+obj1.GetHashCode());
            Console.WriteLine("Object 2 hash value :"+obj2.GetHashCode());
        }
    }
}
