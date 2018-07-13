using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Input
    {
        public int first, last, ask;

        public Input(int f, int l, int a)
        {
            first = f;
            last = l;
            ask = a;
        }

        public void ShowIndexes()
        {
            Console.WriteLine("Swap from index " + first + " to index " + last);
        }
    }
}
