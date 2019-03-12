/*Name: Vikramjeet Singh
  Purpose: odd or even*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number and i will tell you if it's odd or even");
            int result;
            if (int.TryParse(Console.ReadLine(), out result))
        { 
            if (result % 2 == 0)
                    Console.WriteLine($"{result} is an even number.");
                else
                    Console.WriteLine($"{result} is an odd number.");
        }
        else
        Console.WriteLine("ERROR, that was not a valid number");
        }
    }
}
