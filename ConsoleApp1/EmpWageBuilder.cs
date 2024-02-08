using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private CompanyEmpWage[] companyEmpWageArray;
        private int numOfCompanies;
        private static int companyNum = 0;

        public EmpWageBuilder(int numOfCompanies)
        {
            this.numOfCompanies = numOfCompanies;
            this.companyEmpWageArray = new CompanyEmpWage[this.numOfCompanies];            
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpwage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageArray[companyNum] = companyEmpwage;
            companyNum++;
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWageArray)
            {
                if (companyEmpWage != null)
                {
                    companyEmpWage.SetTotalEmpWage(ComputeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.ToString());
                }
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hr: " + empHrs);
            }

            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

        public int GetTotalWage(string company)
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWageArray)
            {
                if (companyEmpWage != null && companyEmpWage.company.Equals(company))
                {
                    return companyEmpWage.totalEmpWage;
                }
            }
            return 0;
        }
    }
}
