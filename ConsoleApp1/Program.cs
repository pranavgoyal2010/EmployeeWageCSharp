// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class EmployeeWageComputation
    {
        
        public void ComputeWage()
        {
            const int EMPLOYEE_WAGE_RATE = 20;
            const int MAX_DAYS = 20;
            const int MAX_HOURS = 100;
            
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


            totalMonthlyWage = EMPLOYEE_WAGE_RATE * ((currHours > MAX_HOURS) ? 100 : currHours);
            Console.WriteLine("Total Monthly Wage: " + totalMonthlyWage); 
            Console.WriteLine("Total Days worked: " + ((currDay>MAX_DAYS)?20:currDay-1));
            Console.WriteLine("Total Number of Hours: " + ((currHours>MAX_HOURS)?100:currHours));
        }
    }

    class Runner
    {
        static void Main(string[] args)
        {
            EmployeeWageComputation emp = new EmployeeWageComputation();
            emp.ComputeWage();
        }
        
    }
}

