using System;

namespace LeetCodeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSum();

            int[] nums = new int[] { 3, 4, 5 };
            int target = 8;

            Console.WriteLine(twoSum.TwoSum2(nums, target).ToString());
        }
    }
}
