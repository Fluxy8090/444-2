using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _444_2 
{
    internal class z6
    {
        public static String solution(String x)
        {
            bool flag = true;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != x[x.Length - 1 - i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                return "Строка является палиндромом";
            }
            return "Строка не является палиндромом";
        }
    }
}