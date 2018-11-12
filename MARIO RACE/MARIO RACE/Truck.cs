using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIO_RACE
{
   public class Truck :Car
    {
        public event CarFinish Finish;
        public int Speed { get; set; }
        public string Name { get; set; }
        public int Displacement { get; set; }
        private Random rand;
        public override void Drive()
        {
            rand = new Random();
            int displacementInTime = rand.Next(1, Speed);
            Displacement += displacementInTime;

            if (Displacement >= 100)
            {
                Finish();
            }
        }
    }
}
