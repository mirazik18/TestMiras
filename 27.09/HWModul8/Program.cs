using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModul8
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Block.block[0] = new Block(2);
            Console.WriteLine(Block.block[0].num);
        }
    }
}
