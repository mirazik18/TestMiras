using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task10();
        }
        static void Task1()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(rnd.Next(0, 11) + " ");
            }
        }
        static void Task2()
        {
            int[] nums = new int[3] { 5, 10, 21};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void Task3()
        {
            Console.Write("Введите размер в сатиметрах:");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Метры:" + (s/100));
        }
        static void Task4()
        {
            Console.Write("Недель:" + (234 / 7));
        }
        static void Task5()
        {
            int num = 32;
            Console.WriteLine(num);
            Console.WriteLine(num/10);
            Console.WriteLine(num-(num / 10)*10);
            Console.WriteLine((num / 10) + (num - (num / 10) * 10));
            Console.WriteLine((num / 10) * (num - (num / 10) * 10));
        }
        static void Task6()
        {
            bool A = true, B = false, C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
        }
        static void Task7()
        {
            Console.Write("Введите радиус круга:");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата:");
            double s1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга:" + (s*s*3.14));
            Console.WriteLine("Площадь квадрата:" + (s1*s1));
        }
        static void Task8()
        {
            Console.Write("Введите объем первого материала:");
            double S1 = double.Parse(Console.ReadLine());
            Console.Write("Введите массу первого материала:");
            double M1 = double.Parse(Console.ReadLine());
            Console.Write("Введите объем второго материала:");
            double S2 = double.Parse(Console.ReadLine());
            Console.Write("Введите массу второго материала:");
            double M2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Плотность первого материала:" + (M1/S1));
            Console.WriteLine("Плотность второго материала:" + (M2 / S2));
            if((M1 / S1)> (M2 / S2))
            {
                Console.WriteLine("Первого плотность больше:");
            }
            else
            {
                Console.WriteLine("Второго плотность больше:");
            }
        }
        static void Task9()
        {
            Console.Write("Введите сопротивление первой цепи:");
            double S1 = double.Parse(Console.ReadLine());
            Console.Write("Введите напряжение первой цепи:");
            double M1 = double.Parse(Console.ReadLine());
            Console.Write("Введите сопротивление второй цепи:");
            double S2 = double.Parse(Console.ReadLine());
            Console.Write("Введите напряжение второй цепи:");
            double M2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сила тока первой цепи:" + (M1 / S1));
            Console.WriteLine("Сила тока второй цепи:" + (M2 / S2));
            if ((M1 / S1) > (M2 / S2))
            {
                Console.WriteLine("Меньший ток во втором:");
            }
            else
            {
                Console.WriteLine("Меньший ток в первом:");
            }
        }
        static void Task10()
        {
            Console.Write("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
            for (int i = 10; i < b; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
            for (int i = a; i < 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
