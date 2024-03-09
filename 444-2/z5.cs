using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _444_2
{
    internal class z5
    {
        public static int solution(int x)
        {
            int F = 1;
            for (int i = 1; i <= x; i++)
            {
                F *= i;
            }
            return F;
        }
    }
}