// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder(5);
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();            
        }

    }
}

