using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCycl
{
    class Program
    {
        static void Main(string[] args)
        {
            // используем цикл for, оптимален при условии что есть чётки границы цикла.  
            for( int i = 7; i < 100; i += 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
