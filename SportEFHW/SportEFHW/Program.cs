using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEFHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new Sportcontext())
            {
                Player player = new Player
                {
                    FullName = "Neymar"
                };
                Team team = new Team
                {
                    Name = "PSG"
                };

                context.Players.Add(player);
                context.Teams.Add(team);
                player.Teams.Add(team);
                team.Players.Add(player);
                context.SaveChanges();
            }
        }
    }
}
