//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.




//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Output: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3, 3], target = 6
//Output: [0,1]


//Constraints:

//2 <= nums.length <= 103
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int J = 0;

            Console.WriteLine("Enter How long you want your array to be");
            int HowMany = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if(HowMany == 1)
            {
                goto Invaid;
            }

            var ToSumArray = new int[HowMany];
            Console.WriteLine("Enter the array of Lenghth {0} After each entry press enter", HowMany);
            for(int a = 0; a<HowMany; a++)
            {
                ToSumArray[a] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Enter your target");
            int Target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i<ToSumArray.Length; i++)
            {
                for(int j = i+1; j<ToSumArray.Length; j++ )
                {
                    var result = ToSumArray[i] + ToSumArray[j];

                    if(result == Target)
                    {
                        I = i;
                        J = j;

                        goto ProperExit;
                    }
                }
            }

            Invaid:
            Console.WriteLine("Invalid");

            ProperExit:
            Console.WriteLine();
            Console.WriteLine("Values were found at {0} and {1}", I, J);

            System.Threading.Thread.Sleep(30000); //Just To hold The Console Screen

        }
    }
}

//Solution By Siddhant Purohit in C#
