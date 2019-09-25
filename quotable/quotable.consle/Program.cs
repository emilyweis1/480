using System;
using System.Collections.Generic;
using quotable.core;

namespace quotable.console
{
    class Program 
    {
        /// <summary>
        /// Main creates an instance of SimpleRandomQuoteProvider named simple that
        /// then creates 7 simple quotes in SimpleRandomQuoteProvider from quotable.core
        /// 
        /// Main then creates a DefaultRandomQuoteGenerator that prints out quotes 
        /// from DefaultRandomQuoteGenerator in quotable.core
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();

            foreach (var s in simple.getQuotes(7))
            {
                Console.WriteLine(s);
            }

            string[] quotes = new string[4] { "one", "two", "three", "four" };

            DefaultRandomQuoteGenerator defaultRand = new DefaultRandomQuoteGenerator(quotes);
        }
    }
}