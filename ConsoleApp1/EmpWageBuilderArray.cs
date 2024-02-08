using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmpWageBuilderArray
    {
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].totalEmpWage = this.ComputeEmpWage(companyEmpWageArray[i]);
                Console.WriteLine(companyEmpWageArray[i]);
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHours = 0, totalEmpWage = 0, empHours = 0, totalWorkingDays = 0;

            while (totalEmpHours <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 1:
                        empHours = 8;
                        break;
                    case 2:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }

                totalEmpHours += empHours;
                totalEmpWage = totalEmpHours * companyEmpWage.empRatePerHour;
            }

            return totalEmpWage;

        }
    }
}
