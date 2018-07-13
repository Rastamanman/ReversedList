using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class MyList<T> :List<T>
    {
        public void Swap(int i, int j)
        {
            try
            {
                if (i > j)
                    throw new ArgumentNullException();
                while (i < j)
                {
                    T temp;
                    temp = this[i-1];
                    this[i-1] = this[j-1];
                    this[j-1] = temp;

                    i++;
                    j--;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Swap arguments incorrect!");
            }
        }

        public void AskPos(int ask)
        {
            try
            {
                if (ask > this.Count)
                    throw new ArgumentNullException();
                Console.WriteLine("On position " + ask + " is the element " + this[ask-1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Asked index is too high!");
            }
            
        }

        public void ShowList()
        {
            Console.WriteLine("Current List: ");
            foreach(T item in this)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }

        public void Task(Input inp)
        {
            inp.ShowIndexes();
            Swap(inp.first, inp.last);
            ShowList();
            AskPos(inp.ask);
        }
    }
}
