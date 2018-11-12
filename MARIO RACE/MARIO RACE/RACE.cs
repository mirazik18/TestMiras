using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIO_RACE
{
    class RACE
    {
        public void Start()
        {
         

            Truck truck = new Truck() { Speed = 3, Displacement = 0 };
            minibus bus = new minibus() { Speed = 6, Displacement = 0 };

         
       
            truck.Finish += () =>
            {
                Console.WriteLine("Сказал триста, и тракторит приехал первый");
            };
            bus.Finish += () =>
            {
                Console.WriteLine("Маршрутка доехала первая, так как в нем сидела баба зина");
            };

            int countSec = 1;
            Console.WriteLine("seconds\tTruck\tMinibus");
     
            while (true)
            {
                truck.Drive();
                bus.Drive();
                Console.WriteLine("{0}\t{1}m\t{2}m", countSec++, truck.Displacement, bus.Displacement);

                if ( truck.Displacement >= 100 || bus.Displacement >= 100)
                {
                    break;
                }
            }






        }
    }
}
