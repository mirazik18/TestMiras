using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEFHW
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        public Player()
        {
            Teams = new List<Team>();
        }
    }
}
