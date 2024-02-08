// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
   
    class Runner
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Dhart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
        }

    }
}

