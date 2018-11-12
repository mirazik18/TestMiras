using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SERIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир", 1488, "Абдишев", 1488);
            Book book2 = new Book("Наши отцы и братья", 1337, "Мирас", 1488);

            BinaryFormatter formatter = new BinaryFormatter();
           

            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, book1);
                formatter.Serialize(fs, book2);
                Console.WriteLine("Сериализован");
            }

            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)formatter.Deserialize(fs);
                Console.WriteLine("Десирилизация");
                Console.WriteLine("Название: {0} Цена: {1}  Автор: {2}  Год издания: {3}", newBook.Name, newBook.Cost, newBook.Author, newBook.Year);
            }

            Console.ReadLine();


        


        }
    }
}
