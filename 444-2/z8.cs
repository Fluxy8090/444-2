using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _444_2
{
    internal class z8
    {
        public static bool solution(int x)
        {
            int count = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;

        }
    }
}