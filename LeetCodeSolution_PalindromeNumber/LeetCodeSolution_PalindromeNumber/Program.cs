using System;

namespace LeetCodeSolution_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check if its palindrome");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your entered number is pallindrome - ");
            Console.WriteLine(Solution.IsPalindrome(userInput));

            System.Threading.Thread.Sleep(30000);
        }
    }

    public static class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x <= 0 ) //Check for negative numbers
                return false;

            if (x >= Int32.MaxValue) //Check for overflow
                return false;

            int temp = x; //Storing the value temporarily
            int inverted = 0;

            while(temp != 0) //Inverting an integer
            {
                int y = temp % 10;
                inverted = (10 * inverted) + y;
                temp /= 10;
            }

            if (x == inverted)
                return true;

            else
                return false;
            
        }
    }
}
