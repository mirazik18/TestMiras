using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    public class Company
    {
        public static int Id { get; set; }
        public List<Employee> EmployeeList { get; set; }
        
        static Company()
        {
            Id = 0;
        }

        public Company()
        {
            Id++;
            EmployeeList = new List<Employee>();
        }

        public void AddEmployee(Employee emolyee)
        {
            this.EmployeeList.Add(emolyee);
        }

        public List<Employee> MoreThanClerks()
        {
            int clerksSalary = 0;
            int clerksCount = 0;

            for(int i=0;i<this.EmployeeList.Count; i++)
            {
                if (this.EmployeeList[i].Vacancy == Vacancies.Clerk)
                {
                    clerksSalary += EmployeeList[i].Salary;
                    clerksCount++;
                }
            }

            int clerksAverageSalary = clerksSalary / clerksCount;

            List<Employee> infoList = new List<Employee>();

            for (int i = 0; i < this.EmployeeList.Count; i++)
            {
                if (this.EmployeeList[i].Salary > clerksAverageSalary)
                {
                    infoList.Add(EmployeeList[i]);
                }
            }

            return infoList;
        }

        public List<Employee> LaterThanBoss()
        {
            List<Employee> infoList = new List<Employee>();

            Employee boss = new Employee();

            for (int i = 0; i < this.EmployeeList.Count; i++)
            {
                if (this.EmployeeList[i].Vacancy == Vacancies.Boss)
                {
                    boss = EmployeeList[i];
                }
            }

            for (int i = 0; i < this.EmployeeList.Count; i++)
            {
                if (this.EmployeeList[i].DateOfEmployee > boss.DateOfEmployee)
                {
                    infoList.Add(EmployeeList[i]);
                }
            }

            return infoList;
        }
    }
}
