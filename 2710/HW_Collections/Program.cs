using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 1, 3, 2, 6, 4, 2 };

            int maxElementPosition = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == collection.Max())
                {
                    maxElementPosition = i;
                    collection.Remove(collection[i]);
                }
            }

            int resultElementPos = 0;
            int resultElement = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == collection.Max())
                {
                    resultElementPos = i;
                    resultElement = collection[i];
                }
            }

            if (maxElementPosition > resultElementPos)
            {
                Console.WriteLine("Второй максимальный элемент в Листе: " + resultElement + "\nЕго позиция: " + resultElementPos + " (Отсчет с нуля)");
            }
            else
            {
                Console.WriteLine("Второй максимальный элемент в Листе: " + resultElement + "\nЕго позиция: " + (resultElementPos+1) + " (Отсчет с нуля)");
            }

            Console.ReadLine();
        }
    }
}
