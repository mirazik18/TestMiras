using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    public struct Employee
    {
        public static int Id { get; set; }
        public string FullName { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfEmployee { get; set; }

        static Employee()
        {
            Id = 0;
        }

        public Employee(string fullName, Vacancies vacancy, int salary, DateTime dateOfEmployee)
        {
            Id++;
            this.FullName = fullName;
            this.Vacancy = vacancy;
            this.Salary = salary;
            this.DateOfEmployee = dateOfEmployee;
        }
    }
}
