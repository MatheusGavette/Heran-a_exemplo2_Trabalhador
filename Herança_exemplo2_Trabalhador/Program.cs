﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Herança_exemplo2_Trabalhador.Entities;

namespace Herança_exemplo2_Trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hte number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> paperSalary = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-------------------- \n");

                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("outsorced (Y/N)?");
                string opc = Console.ReadLine().ToUpper();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == "Y" || opc == "YES")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee x = new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    paperSalary.Add(x);
                }
                else
                {
                    Employee x = new Employee(name, hours, valuePerHour);

                    paperSalary.Add(x);
                }
            }

            Console.WriteLine(paperSalary);
            Console.ReadLine();
        }
    }
}
