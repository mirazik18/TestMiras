using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Tank> tanks = new List<Tank>();

        public Team(string teamName, Tank first, Tank second, Tank third, Tank fourth, Tank fifth)
        {
            this.TeamName = teamName;
            tanks.Add(first);
            tanks.Add(second);
            tanks.Add(third);
            tanks.Add(fourth);
            tanks.Add(fifth);
        }

        public static Team operator ^(Team firstTeam, Team secondTeam)
        {
            int t34Points = 0, panteraPoints = 0;

            for (int i = 0; i < 5; i++)
            {
                if (firstTeam.tanks[i].AmmunitionLevel > secondTeam.tanks[i].AmmunitionLevel)
                    t34Points++;
                else
                    panteraPoints++;

                if (firstTeam.tanks[i].ArmorLevel > secondTeam.tanks[i].ArmorLevel)
                    t34Points++;
                else
                    panteraPoints++;

                if (firstTeam.tanks[i].ManeuverabilityLevel > secondTeam.tanks[i].ManeuverabilityLevel)
                    t34Points++;
                else
                    panteraPoints++;
            }

            if (t34Points == panteraPoints)
                throw new PersonalExceptions("Равное преимущество танков!");

            if (t34Points > panteraPoints)
                return firstTeam;
            else
                return secondTeam;
        }

        public string GetInfo()
        {
            string result = "";

            for (int i = 0; i < this.tanks.Count; i++)
            {
                result += "\n\nНазвание танка: " + this.tanks[i].Name + "\nУровень боекомплекта: " + this.tanks[i].AmmunitionLevel + "\nУровень брони: " + this.tanks[i].ArmorLevel + "\nУровень маневренности: " + this.tanks[i].ManeuverabilityLevel;
            }

            return result;
        }
    }
}
