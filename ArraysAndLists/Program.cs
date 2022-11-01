using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            var odds = new List<int>();

            
            
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
           foreach(var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }
            foreach (var item in odds)
            {
                Console.WriteLine($"{item} is an odd number");
            }
        }
    }
}
