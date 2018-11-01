using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HomeWorkModul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib(1);
            Task2();
        }
     static int Fib(int number)
        {
            string path = @"C:\data\1.txt";

            try
            {
                Console.WriteLine("******считываем весь файл********");
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                Console.WriteLine();
                Console.WriteLine("******считываем построчно********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("******считываем блоками********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    char[] array = new char[4];
                    // считываем 4 символа
                    sr.Read(array, 0, 4);

                    Console.WriteLine(array);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (number < 1)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }

            string readPath = @"C:\data\1.txt";
            string writePath = @"C:\data\1.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write( Fib(number - 1) + Fib(number - 2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Fib(number - 1) + Fib(number - 2);
            }  
        static void Task2()
        {
            int v, c;
            string path = @"C:\data\2.txt";

            try
            {
                Console.WriteLine("******считываем весь файл********");
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                Console.WriteLine();
                Console.WriteLine("******считываем построчно********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("******считываем блоками********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    char[] array = new char[4];
                    // считываем 4 символа
                     sr.Read(array, 0, 1);
                       sr.Read(array, 0, 2);
                    Console.WriteLine(array);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string readPath = @"C:\data\2.txt";
            string writePath = @"C:\data\2.txt";

            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    
                    sw.Write(7);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
