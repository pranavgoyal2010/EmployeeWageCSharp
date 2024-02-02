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
            int totalDays = 20;
            int totalHours = 100;
            int totalMonthlyWage = 0;
            int currDay = 1;
            int currHours = 0;
            
            while(currDay<=totalDays && currHours<=totalHours)
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
                Console.WriteLine("Day " + currDay + " Wage : " + (employeeWageRate * empHrs));
                currDay++;
                currHours += empHrs;
                totalMonthlyWage += (employeeWageRate * empHrs);
            }
            
            
            
            Console.WriteLine("Total Monthly Wage: " + totalMonthlyWage); 
            Console.WriteLine("Total Days worked: " + ((currDay>totalDays)?20:currDay));
            Console.WriteLine("Total Number of Hours: " + ((currHours>totalHours)?100:currHours));
        }
    }
}

