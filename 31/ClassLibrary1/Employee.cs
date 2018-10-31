using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// 1.	Создать перечисление должностей Vacancies {Manager, Boss, Clerk, Salesman, и т.д.}
    /// </summary>
    public enum Vacancies
    {
        Manager,
        Boss,
        Clerk
    }
    /// <summary>
    /// 2.	2. Создать структуру «Employee» состоящую из:
    ///a.поля name строкового типа;
    ///b.поля vacancy типа Vacancies;
    ///c.поля зарплата целого типа;
    ///d.поля дата приема на работу типа int[3].
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public uint Salary { get; set; }
        public int[] startedToWork = new int[3]; 
        public override string ToString()
        {
            return String.Format("Имя: {0}\nДолжность: {1}\nЗарплата: {2}\nДата приема на работу: {3}-{4}-{5}\n ", Name, Vacancy.ToString(),Salary, startedToWork[0], startedToWork[1], startedToWork[2]);
        }

    }
}
