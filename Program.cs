﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = { 1, 2, 3, 4, 5 };
            int mult = 3;
            for (int i = 0; i < numbers.Length; i++)
            {
              num[i] *= mult; 
            }
            Console.WriteLine("Массив после умножения на " + mult + ":");
            foreach (int el in num)
            {
              Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
