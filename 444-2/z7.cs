using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _444_2
{
    internal class z7
    {
        public static int[] solution(int[] nums1, int[] nums2)
        {
            int count = 0;
            int[] Fnums = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                Fnums[count] = nums1[i];
                count++;
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                Fnums[count] = nums2[i];
                count++;
            }
            return Fnums;
        }
    }
}