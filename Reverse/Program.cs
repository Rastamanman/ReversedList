using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Launch();
        }

        public static void Launch()
        {
            Random rnd = new Random();
            MyList<int> lista = new MyList<int>();
            int n = 30;
            int m = 5;

            for (int i = 1; i <= n; i++)
            {
                lista.Add(i);
            }
            lista.ShowList();

            for (int it = 0; it < m; it++)
            {
                int j = rnd.Next(1, n);
                Input inp = new Input(rnd.Next(1, j), j, rnd.Next(1, n));
                lista.Task(inp);
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
        
    }
}
