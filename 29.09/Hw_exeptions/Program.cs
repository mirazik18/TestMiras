using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func2();
        }
        static public void Func1()
        {
            //1.реализовать метод деления двух чисел. Внутри метода проверять входящие параметры.Если они не заданы, то генерировать исключение ArgumentNullException.Если делитель равен нулю, то генерировать исключение ArgumentException.
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int d = a / b;
            }
            catch (FormatException)
            {
                ArgumentNullException ex = new ArgumentNullException();
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                ArgumentException ex = new ArgumentException();
                Console.WriteLine(ex.Message);
            }
            
        }

        static public void Func2()
        {
            //2.Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            int[] mass = new int[10];
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    Console.WriteLine(mass[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("завершении обработки массива");
            }
        }
    }
}
