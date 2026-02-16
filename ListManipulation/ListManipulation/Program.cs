using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();          

            switch (cmd[0])
            {
                case "add":
                    break;
                case "ins":
                    break;
                case "contains":                    
                    break;
                case "delete":
                    break;
                case "remove":
                    break;
                case "print":
                    break;
                case "countOdds": 
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
