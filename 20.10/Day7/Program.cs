using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyClassLib.WorldOfTanks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пришлось добавлять по пять танков по отдельности, потому что иначе не смог присвоить рандомные значения свойствам класса Tank (значения не изменялись рандомно при повторном создании объекта, и получались одинаковые статы у всех танков)

            //Для удобства создал класс Team, чтобы туда добавлять эти самые пять танков.

            //Перегрузку оператора '^' реализовал для класса Team, а не для класса Tank, как требовало этого задание, в моем случае я думаю это более подходящее решение.

            MyClassLib.WorldOfTanks.Tank t341 = new MyClassLib.WorldOfTanks.Tank("T34");
            MyClassLib.WorldOfTanks.Tank t342 = new MyClassLib.WorldOfTanks.Tank("T34");
            MyClassLib.WorldOfTanks.Tank t343 = new MyClassLib.WorldOfTanks.Tank("T34");
            MyClassLib.WorldOfTanks.Tank t344 = new MyClassLib.WorldOfTanks.Tank("T34");
            MyClassLib.WorldOfTanks.Tank t345 = new MyClassLib.WorldOfTanks.Tank("T34");

            MyClassLib.WorldOfTanks.Tank pantera1 = new MyClassLib.WorldOfTanks.Tank("Pantera");
            MyClassLib.WorldOfTanks.Tank pantera2 = new MyClassLib.WorldOfTanks.Tank("Pantera");
            MyClassLib.WorldOfTanks.Tank pantera3 = new MyClassLib.WorldOfTanks.Tank("Pantera");
            MyClassLib.WorldOfTanks.Tank pantera4 = new MyClassLib.WorldOfTanks.Tank("Pantera");
            MyClassLib.WorldOfTanks.Tank pantera5 = new MyClassLib.WorldOfTanks.Tank("Pantera");

            Console.Write("Введите название команды для танков Т34: ");
            string firstTeamName = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите название команды для танков Pantera: ");
            string secondTeamName = Console.ReadLine();
            Console.Clear();

            MyClassLib.WorldOfTanks.Team firstTeam = new MyClassLib.WorldOfTanks.Team(firstTeamName, t341, t342, t343, t344, t345);
            MyClassLib.WorldOfTanks.Team secondTeam = new MyClassLib.WorldOfTanks.Team(secondTeamName, pantera1, pantera2, pantera3, pantera4, pantera5);

            try                                                                                                                                      
            {

                Console.Write("Информация про первую команду:");
                Console.WriteLine(firstTeam.GetInfo());

                Console.ReadLine();
                Console.Clear();

                Console.Write("Информация про вторую команду:");
                Console.WriteLine(secondTeam.GetInfo());

                Console.ReadLine();
                Console.Clear();

                Console.Write("Выиграла команда " + (firstTeam ^ secondTeam).TeamName + '!');
                Console.WriteLine("\nИнформация о команде:" + (firstTeam ^ secondTeam).GetInfo()); 
                
            }
            catch (MyClassLib.PersonalExceptions exception)
            {
                Console.Clear();
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
