using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 15);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Beep();
            Console.WriteLine("Введите длину ноги ");
          string name =  Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
