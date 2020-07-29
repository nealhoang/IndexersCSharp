﻿using System;

namespace IndexersDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            Employee employee = new Employee
            {
                ID = 1,
                Name = "Toai",
                Department = "IT",
                Gender = Gender.Male,
                Salary = 1000,
                Job = "Dev",
                Location = "Ha Noi"
            };

            Console.WriteLine($"My name is {employee["Name"]} working in {employee["Department"]} department.");
            Console.ReadKey();

        }
    }
}
