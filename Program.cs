﻿using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Clear();
            Random nmr = new Random();
            Console.WriteLine("Gissa vilket nummer datorn tänker skriva, tal mellan 1-100");
            int answer = int.Parse(Console.ReadLine());*/

            Random nmr = new Random();
            int tal = nmr.Next(1, 101);
            Console.WriteLine("Gissa vilket tal datorn väljer, tal mellan 1 och 100");
            int försök = 1;
            while (true)
            {
                 int svar = int.Parse(Console.ReadLine());

                 if (svar < tal){
                     Console.WriteLine("För lågt, gissa igen!");
                     försök++;
                 }

                 else if (svar > tal){
                     Console.WriteLine("Talet är för högt, gissa igen!");
                     försök++;
                 }

                 else if (svar == tal){
                     Console.WriteLine($"du gissade rätt efter {försök} försök");
                     försök++;
                 }
            }
        }
    }
}
