using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModul8
{
    public class Block
    {
        static public Block[] block = new Block[10];
        public int num = new int();
        public Block this[int index]
        {
            get { return block[index]; }    
            set { block[index] = new Block(value.num * value.num); }
        }
        public Block(int num)
        {
            this.num = num;
        }
    }
}
