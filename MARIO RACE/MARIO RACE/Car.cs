using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIO_RACE
{
    public delegate void CarFinish();
    public abstract class Car
    {
        public event CarFinish Finish;
        public int Speed { get; set; }
        public string Name { get; set;}
        public int Displacement { get; set; }
        public abstract void Drive();
    }
}
