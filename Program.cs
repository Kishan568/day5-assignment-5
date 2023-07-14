﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conday5_assignmt_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numOfEmployees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of working days for each employee: ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());  
            int[][] salaries = new int[numOfEmployees][];
            for (int i = 0; i < numOfEmployees; i++)
            {
                salaries[i] = new int[numOfDays];
                for (int j = 0; j < numOfDays; j++)
                {
                    Console.Write($"Enter the salary for Day {j + 1} of Employee {i + 1}: ");
                    salaries[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nEmployee Salaries:");
            for (int i = 0; i < numOfEmployees; i++)
            {
                int totalSalary = 0;
                Console.Write($"Employee {i + 1}: ");
                for (int j = 0; j < numOfDays; j++)
                {
                    Console.Write($"{salaries[i][j]} ");
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine($"Total Salary: {totalSalary}");
            }
        }
    }
}
        

