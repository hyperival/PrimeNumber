﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            int count = 0;
            for (int i = 1; i <=number; i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Prime Number");
            }
            else 
            {
                Console.WriteLine("Not a Prime Number"); 
            }
            Console.ReadLine();
        }
    }
}
