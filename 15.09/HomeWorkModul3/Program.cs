using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5();
        }

        static public void Task1()
        {
            //1.Написать программу, которая считывает символы с 
            //    клавиатуры, пока не будет введена точка.Программа 
            //    должна сосчитать количество введенных пользователем пробелов.
            int count_space = 0;
            char sym = new char();
            while (true)
            {
                sym = Console.ReadKey().KeyChar;
                if(sym == ' ')
                {
                    count_space++;
                }
                else if (sym == '.')
                {
                    break;
                }
            }
            Console.WriteLine("Количество пробелов: {0}", count_space);
        }
        static public void Task2()
        {
            //3.Числовые значения символов нижнего регистра в коде ASCII 
            //    отличаются от значений символов верхнего регистра на величину 32.
            //    Используя эту информацию, написать программу, которая считывает с 
            //    клавиатуры и конвертирует все символы нижнего регистра в символы 
            //    верхнего регистра и наоборот.
            string str = "HeLlo WoRlD";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) >= 'a' && str.ElementAt(i) <= 'z')
                {
                    Console.Write((char)(str.ElementAt(i) - 32));
                }
                else if (str.ElementAt(i) >= 'A' && str.ElementAt(i) <= 'Z')
                {
                    Console.Write((char)(str.ElementAt(i) + 32));
                }
                else Console.Write(str.ElementAt(i));
            }
        }
        static public void Task3()
        {
            //4.Даны целые положительные числа A и B(A<B). 
            //Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз, 
            //    равное его значению. Например: если А = 3, а В = 7

            int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int f = 0; f < i; f++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
        }
        static public void Task4()
        {
            //5.Дано целое число N(> 0), 
            //найти число, полученное при прочтении числа 
            //N справа налево. Например, если было введено число 345, 
            //то программа должна вывести число 543.
            int A = int.Parse(Console.ReadLine());
            if (A > 0)
            {
                Char[] strA = A.ToString().ToCharArray();
                Array.Reverse(strA);
                Console.WriteLine(strA);
            }
            else
            {
                Console.WriteLine("Введите число больше 0");
            }
          
        }
        static public void Task5()
        {
            //2.Ввести с клавиатуры номер трамвайного билета(6 - значное число)
            //    и про-верить является ли данный билет счастливым
            //    (если на билете напечатано шестизначное число, 
            //    и сумма первых трёх цифр равна сумме последних трёх, 
            //    то этот билет считается счастливым).
            int[] digitArray = new int[6];
            for (int i = 0; i < 6; i++)
            {
                digitArray[i] = int.Parse(Console.ReadKey().KeyChar.ToString());
            }
           
            if(digitArray.Take(3).Sum() == digitArray.Take(6).Sum() - digitArray.Take(3).Sum())
            {
               Console.WriteLine("\nЧисло счастливое"); 
            }
            else
            {
                Console.WriteLine("\nЧисло как число");
            }


        }
    }
    
}
