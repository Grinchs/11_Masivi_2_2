﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Masivi_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int garums1 = int.Parse(Console.ReadLine());  
            string[] mas1 = new string[garums1];

            Console.Write("Ievadiet otra masīva izmēru: ");
            int garums2 = int.Parse(Console.ReadLine()); 
            string[] mas2 = new string[garums2];

            for (int i = 0; i < garums1; i++)
            {
                Console.Write($"Ievadiet 1. masīva vērtību {i + 1}: ");
                mas1[i] = Console.ReadLine();
            }

            for (int i = 0; i < garums2; i++)
            {
                Console.Write($"Ievadiet 2. masīva vērtību {i + 1}: ");
                mas2[i] = Console.ReadLine();
            }

            // Pirmā masīva vērtības
            for (int i = 0; i < garums1; i++)
            {
                Console.WriteLine($"1. masīva {i + 1} vērtība ir: {mas1[i]}");
            }

            // Otrā masīva vērtības
            for (int i = 0; i < garums2; i++)
            {
                Console.WriteLine($"2. masīva {i + 1} vērtība ir: {mas2[i]}");
            }

            Console.WriteLine("\n1. un 2. masīva apvienotā simbolu virkne:");
            for (int i = 0; i < Math.Max(garums1, garums2); i++)
            {
                if (i < garums1)
                {
                    Console.Write(mas1[i]);
                }

                if (i < garums2)
                {
                    Console.Write(mas2[i]);
                }
            }
            Console.WriteLine(); 
        }
    }
}