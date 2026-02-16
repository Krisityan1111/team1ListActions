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
                    nums.Add(int.Parse(cmd[1]));
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "ins":
                    break;
                case "contains":   
                    if (nums.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine(string.Join(" ", nums));
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
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
                    break;
            }
        }
    }
}
