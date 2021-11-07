using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDesignPatterns
{
    class SingletonOne
    {
        private static SingletonOne _instance;
        //Private constructor
        private SingletonOne()
        {
        }

        public static SingletonOne CreateSingletonObject
        {
            get 
            { 
                if (_instance == null) {
                    _instance = new SingletonOne();
                }
                return _instance;
            }
        }
    }
}
