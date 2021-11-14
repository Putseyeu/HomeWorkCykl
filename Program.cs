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
            int numer;
            int numerMax = 100;
            int numerStep = 7;
            for(numer = 7; numer < numerMax; numer += numerStep)
            {
                Console.WriteLine(numer);
            }
        }
    }
}
