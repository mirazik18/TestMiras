using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = Init();
            Print(employees);
            Console.ReadLine();
            Console.Clear();
            AverageSalary(employees);
            Console.ReadLine();
            Console.Clear();
            BeforeBoss(employees);
            Console.ReadLine();
            Console.Clear();

        }
        /// <summary>
        /// 1.	Создать массив сотрудников. Длина массива задается пользователем, заполнение массива производится им же.
        /// </summary>
        static public Employee[] Init()
        {
            int count = new int();
            do
            {
                Console.Write("Введите число сотрудников: ");
                int.TryParse(Console.ReadLine(), out count);
                Console.Clear();
                if (count == 0)
                    Console.WriteLine("Ошибка");
            } while (count == 0);
            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                employees[i] = new Employee();
                int post = new int();
                Console.Write("Введите имя: ");
                employees[i].Name = Console.ReadLine();
                Console.Clear();
                do
                {
                    Console.Write("Введите должность сотрудника: \n1.Босс\n2.Менеджер\n3.Клерк\n");
                    int.TryParse(Console.ReadLine(), out post);
                    Console.Clear();
                    if (!(1 <= post && post <= 3))
                        Console.WriteLine("Ошибка");
                } while (!(1 <= post && post <= 3));
                switch (post)
                {
                    case 1:
                        employees[i].Vacancy = Vacancies.Boss;
                        break;
                    case 2:
                        employees[i].Vacancy = Vacancies.Manager;
                        break;
                    case 3:
                        employees[i].Vacancy = Vacancies.Clerk;
                        break;
                }
                uint salary = new int();
                bool case1;
                do
                {
                    Console.Write("Введите зарплату: ");
                    case1 = !uint.TryParse(Console.ReadLine(), out salary);
                    Console.Clear();
                    if (case1)
                        Console.WriteLine("Ошибка");
                } while (case1);
                employees[i].Salary = salary;
                int d, m, y;
                do
                {
                    Console.Write("Введите год начало работы сотрудника: ");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.Clear();
                    if (!(2000 <= y && y <= DateTime.Now.Year))
                        Console.WriteLine("Ошибка");
                } while (!(2000 <= y && y <= DateTime.Now.Year));
                bool case2, case3;
                do
                {
                    Console.Write("Введите месяц начало работы сотрудника: "); //Не ругайтесь у вас в условиях было написано использовать массив
                    int.TryParse(Console.ReadLine(), out m);
                    Console.Clear();
                    if (y == DateTime.Now.Year)
                    {
                        case2 = !(1 <= m && m <= DateTime.Now.Month);
                        if (case2)
                            Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        case2 = !(1 <= m && m <= 12);
                        if (case2)
                            Console.WriteLine("Ошибка");
                    }
                } while (case2);
                do
                {
                    Console.Write("Введите день начало работы сотрудника: ");
                    int.TryParse(Console.ReadLine(), out d);
                    Console.Clear();
                    if (y == DateTime.Now.Year && m == DateTime.Now.Month)
                    {
                        case3 = !(1 <= d && d <= DateTime.Now.Day);
                        if (case3)
                            Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        case3 = !(1 <= d && d <= DateTime.DaysInMonth(y, m));
                        if (case3)
                            Console.WriteLine("Ошибка");
                    }
                } while (case3);
                employees[i].startedToWork[0] = d;
                employees[i].startedToWork[1] = m;
                employees[i].startedToWork[2] = y;
            }
            return employees;
        }
        /// <summary>
        /// a.	вывести полную информацию обо всех сотрудниках;
        /// </summary>
        /// <param name="employees">Массив сотрудников</param>
        static public void Print(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString()); 
            }
        }
        /// <summary>
        /// b.	найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
        /// </summary>
        /// <param name="employees">Массив сотрудников</param>
        static public void AverageSalary(Employee[] employees)
        {
            Double avsalary = employees.Where(a => a.Vacancy == Vacancies.Clerk).Average(a=> a.Salary);
            foreach (var item in employees.Where(a => a.Vacancy == Vacancies.Manager).Where(a => a.Salary >= avsalary))
            {
                Console.WriteLine(item.ToString());
            }
        }
        /// <summary>
        /// c.	распечатать информацию обо всех сотрудниках, принятых на работу позже босса, отсортированную в алфавитном порядке по фамилии сотрудника.
        /// </summary>
        /// <param name="employees">Массив сотрудников</param>
        static public void BeforeBoss(Employee[] employees)
        {
            
            int index = -1;
            employees.First(n => { index++; return n.Vacancy == Vacancies.Boss; });
            Employee[] employees2 = new Employee[index];
            Array.Copy(employees, employees2, index);
            employees2 = employees2.OrderBy(a => a.Name).ToArray();
            foreach (var item in employees2)
            {
                Console.WriteLine(item.ToString()); 
            }
        }

    }
}
