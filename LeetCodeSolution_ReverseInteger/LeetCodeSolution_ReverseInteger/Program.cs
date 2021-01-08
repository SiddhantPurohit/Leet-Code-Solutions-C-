//Given a 32-bit signed integer, reverse digits of an integer.

//Note:
//Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

//Example 1:
//Input: x = 123
//Output: 321

//Example 2:
//Input: x = -123
//Output: -321


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LeetCodeSolution_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 32 bit int to reverse"); //−2,147,483,648 to 2,147,483,647 is the range of 32bit int
            int IntToReverse = Convert.ToInt32(Console.ReadLine());

            var solution = new Solution();

            int Result = solution.Reverse(IntToReverse);

            Console.WriteLine(Result);

            Thread.Sleep(30000);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            var result = 0;
            var max = Int32.MaxValue / 10;

            while (x != 0)
            {
                if (result > max || result < -max) return 0; // check for overflow
                result = result * 10 + (x % 10);
                x /= 10;
            }

            return result;
        }
    }
}
