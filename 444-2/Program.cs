using System;
using System.Threading.Tasks;

namespace _444_2;
class zada4i()
{
    public static void Main(string[] args)
    {
        Console.WriteLine(z1.solution(2, 6));
        Console.WriteLine(z2.solution(5));
        Console.WriteLine(z3.solution("баобаб"));
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(z4.solution(nums));
        Console.WriteLine(z5.solution(5));
        Console.WriteLine(z6.solution("боби"));
        int[] nums1 = { 1, 2, 3, 4 };
        int[] nums2 = { 5, 6, 7 };
        int[] Fnums = z7.solution(nums1, nums2);
        for (int i = 0; i < Fnums.Length; i++)
        {
            Console.Write(Fnums[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(z8.solution(12));
        Console.WriteLine(z9.solution("баобаб"));
        int[][] nums3 = new int[3][];
        for (int i = 0; i < nums3.Length; i++)
        {
            nums3[i] = new int[3];
        }

        for (int i = 0; i < nums3.Length; i++)
        {
            for (int j = 0; j < nums3[i].Length; j++)
            {
                nums3[i][j] = j + i;
            }
        }
        Console.WriteLine(z10.solution(nums3));








    }
}