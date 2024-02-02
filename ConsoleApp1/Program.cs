// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Employee
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int status = rnd.Next(0, 3);

            int employeeWageRate = 20;
            int empHrs = 0;
            int numOfDays = 20;
            int totalMonthlyWage = 0;

            for(int day = 1; day<=numOfDays; day++)
            {
                int status = rnd.Next(0, 3);
                switch (status)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present and is Full-Time");
                        empHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present and is Part-Time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
                Console.WriteLine("Day "+ day + " Wage : " + (employeeWageRate * empHrs));
                totalMonthlyWage += (employeeWageRate * empHrs);
            }
            
            
            
            Console.WriteLine("Total Monthly Wage: " + totalMonthlyWage);
        }
    }
}

