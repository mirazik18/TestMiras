using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    class Show
    {
        public void GetInfoCompany(Company company)
        {
            Console.Clear();
            for (int i = 0; i < company.EmployeeList.Count; i++)
            {
                Console.WriteLine(i+1 + ")");
                Console.WriteLine("Имя: " + company.EmployeeList[i].FullName);
                Console.WriteLine("Должность: " + company.EmployeeList[i].Vacancy);
                Console.WriteLine("Зарплата: " + company.EmployeeList[i].Salary);
                Console.WriteLine("Дата приема на работу: " + company.EmployeeList[i].DateOfEmployee);
                Console.WriteLine();
            }
        }

        public void GetInfoList(List<Employee> list)
        {
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + 1 + ")");
                Console.WriteLine("Имя: " + list[i].FullName);
                Console.WriteLine("Должность: " + list[i].Vacancy);
                Console.WriteLine("Зарплата: " + list[i].Salary);
                Console.WriteLine("Дата приема на работу: " + list[i].DateOfEmployee);
                Console.WriteLine();
            }
        }

        public void GetInfoUniversity(List<Student> list)
        {
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + 1 + ")");
                Console.WriteLine("Имя: " + list[i].FullName);
                Console.WriteLine("Группа: " + list[i].Group);
                Console.WriteLine("Средний балл: " + list[i].AverageMark);
                Console.WriteLine("Доход на одного члена семьи: " + list[i].IncomePerPerson);
                Console.WriteLine("Пол: " + list[i].Gender);
                Console.WriteLine("Форма обучения: " + list[i].FormOfStudy);
                Console.WriteLine();
            }
        }

        public int MenuFirst()
        {
            Console.WriteLine("1. Посмотреть всех работников компании");
            Console.WriteLine("2. Посмотреть работников, у которых зарплата больше, чем средняя зарплата клерков");
            Console.WriteLine("3. Посмотреть работников, которые поступили на работу позднее, чем босс");
            Console.WriteLine("4. Выйти");
            Console.Write("\nВыберите нужный пункт: ");
            int menuItem = Convert.ToInt32(Console.ReadLine());
            return menuItem;
        }

        public int MenuSecond()
        {
            Console.WriteLine("1. Посмотреть всех студентов университета");
            Console.WriteLine("2. Посмотреть список очередности предоставления мест в общежитии");
            Console.WriteLine("3. Выйти");
            Console.Write("\nВыберите нужный пункт: ");
            int menuItem = Convert.ToInt32(Console.ReadLine());
            return menuItem;
        }

        public int MainMenu()
        {
            Console.WriteLine("1. Запустить первую программу");
            Console.WriteLine("2. Запустить вторую программу");
            Console.WriteLine("3. Выйти");
            Console.Write("\nВыберите нужный пункт: ");
            int menuItem = Convert.ToInt32(Console.ReadLine());
            return menuItem;
        }
    }
}
