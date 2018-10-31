using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    class Program
    {
        static void CompanyInitializer(ref Company realibeats)
        {
            Employee alibi = new Employee("Дуйсеналиев Алиби", Vacancies.Boss, 1000000, new DateTime(2018, 10, 01));
            Employee amir = new Employee("Абдрахманов Амирхан", Vacancies.Manager, 800000, new DateTime(2018, 10, 02));
            Employee aknur = new Employee("Тажибек Акнур", Vacancies.Salesman, 600000, new DateTime(2018, 10, 03));
            Employee miras = new Employee("Абдишев Мирас", Vacancies.Clerk, 400000, new DateTime(2018, 10, 04));
            Employee dimash = new Employee("Абдимаш Динмухамед", Vacancies.Clerk, 400000, new DateTime(2018, 10, 05));

            realibeats.AddEmployee(alibi);
            realibeats.AddEmployee(amir);
            realibeats.AddEmployee(aknur);
            realibeats.AddEmployee(miras);
            realibeats.AddEmployee(dimash);
        }

        static void UniversityInitializer(ref University MGU)
        {
            Student alibi = new Student("Дуйсеналиев Алиби", "SEP-172", 5, 60000, Gender.Male, FormOfStudy.Free);
            Student amir = new Student("Абдрахманов Амирхан", "SEP-172", 6, 100000, Gender.Male, FormOfStudy.Free);
            Student aknur = new Student("Тажибек Акнур", "SEP-172", 3, 90000, Gender.Female, FormOfStudy.Free);
            Student miras = new Student("Абдишев Мирас", "SEP-172", 4, 200000, Gender.Male, FormOfStudy.Free);
            Student dimash = new Student("Абдимаш Динмухамед", "SEP-172", 7, 80000, Gender.Male, FormOfStudy.Free);

            MGU.AddStudent(alibi);
            MGU.AddStudent(amir);
            MGU.AddStudent(aknur);
            MGU.AddStudent(miras);
            MGU.AddStudent(dimash);
        }

        static void FirstTask(Show show)
        {
            Company realibeats = new Company();

            CompanyInitializer(ref realibeats);

            while (true)
            {
                Console.Clear();
                int menuItem = show.MenuFirst();

                switch (menuItem)
                {
                    case (int)MenuFirstTask.CompanyInfo:
                        show.GetInfoCompany(realibeats);
                        Console.ReadLine();
                        break;

                    case (int)MenuFirstTask.MoreThanClerk:
                        show.GetInfoList(realibeats.MoreThanClerks());
                        Console.ReadLine();
                        break;
                    case (int)MenuFirstTask.LaterThanBoss:
                        show.GetInfoList(realibeats.LaterThanBoss());
                        Console.ReadLine();
                        break;
                    case (int)MenuFirstTask.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void SecondTask(Show show)
        {
            int minimalSalary = 200000;

            University MGU = new University(minimalSalary);

            UniversityInitializer(ref MGU);

            while (true)
            {
                Console.Clear();
                int menuItem = show.MenuSecond();

                switch (menuItem)
                {
                    case (int)MenuSecondTask.UniversityInfo:
                        show.GetInfoUniversity(MGU.StudentList);
                        Console.ReadLine();
                        break;
                    case (int)MenuSecondTask.Obshaga:
                        show.GetInfoUniversity(MGU.StudentList);
                        Console.ReadLine();
                        break;
                    case (int)MenuSecondTask.Exit:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        static void Main(string[] args)
        {
            Show show = new Show();

            int menuItem = show.MainMenu();

            switch (menuItem)
            {
                case (int)MainMenu.FirstTask:
                    FirstTask(show);
                    Console.ReadLine();
                    break;
                case (int)MenuSecondTask.Obshaga:
                    SecondTask(show);
                    Console.ReadLine();
                    break;
                case (int)MenuSecondTask.Exit:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
