// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Employee
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int status = rnd.Next(0, 2);

            int employeeWageRate = 20;
            int empHrs = 0;

            if(status == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }

            int totalDailyWage = employeeWageRate * empHrs;
            Console.WriteLine("Total Daily Wage: " + totalDailyWage);
        }
    }
}

