﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(Power(3,2));
            Console.ReadLine();
        }
        static int Power(int baze, int power)
        {
            if (power > 0) // (power == 0)
            {
                return baze * Power(baze, power - 1);
                //return 1;
            }
            else
            {
                //return baze * Power(baze, power - 1);
                return 1;
            }

        }
    }
}
