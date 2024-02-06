// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class EmployeeWageComputation
    {
        
        public void ComputeWage(string companyName, int employeeWageRate, int maxDays, int maxHours)
        {

            int EMPLOYEE_WAGE_RATE = employeeWageRate;
            int MAX_DAYS = maxDays;
            int MAX_HOURS = maxHours;
            
            int empHrs = 0;       
            int totalMonthlyWage = 0;
            int currDay = 1;
            int currHours = 0;

            Random rnd = new Random();

            while (currDay<=MAX_DAYS && currHours<MAX_HOURS)
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
                //currDay++;
                Console.WriteLine("Day " + currDay + " Hrs Worked: " + empHrs);
                currDay++;
                currHours += empHrs;
                //totalMonthlyWage += (EMPLOYEE_WAGE_RATE * empHrs);
            }

            Console.WriteLine("Company's name : " + companyName);
            totalMonthlyWage = EMPLOYEE_WAGE_RATE * ((currHours > MAX_HOURS) ? MAX_HOURS : currHours);           
            Console.WriteLine("Total Monthly Wage: " + totalMonthlyWage); 
            Console.WriteLine("Total Days worked: " + ((currDay>MAX_DAYS)?MAX_DAYS:currDay-1));
            Console.WriteLine("Total Number of Hours: " + ((currHours>MAX_HOURS)?MAX_HOURS:currHours));
        }
    }

    class Runner
    {
        static void Main(string[] args)
        {
            EmployeeWageComputation emp = new EmployeeWageComputation();
            emp.ComputeWage("Reliance", 30, 15, 50);
            Console.WriteLine("============================================");
            emp.ComputeWage("Airtel", 20, 30, 40);
            Console.WriteLine("============================================");
            emp.ComputeWage("Videocon", 25, 25, 100);
        }
        
    }
}

