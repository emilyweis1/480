using System;
using System.Collections.Generic;
using quotable.core;

namespace quotable.console
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();
            //DefaultRandomQuoteGenerator defaultRand = new DefaultRandomQuoteGenerator({ "quote 1", "quote 2" });

            foreach(var s in simple.getQuotes(7))
            {
                Console.WriteLine(s);
            }
        }
    }
}