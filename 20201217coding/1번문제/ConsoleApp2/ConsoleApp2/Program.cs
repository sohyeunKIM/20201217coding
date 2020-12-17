using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;
            for (int i=0; i<100; i++)
            {
                if ((i+1) % 3 == 0)
                    hap = hap + (i + 1);
            }
            Console.WriteLine("1~100까지의 합 : =" + hap);
        }
    }
}
