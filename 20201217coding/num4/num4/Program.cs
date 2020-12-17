using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++) 
            {
                for (int f = 1; f <= 9; f++) 
                {
                    Console.WriteLine($"{i}X{f}="+ (i * f));
                }
            }

    }
        }
    }
