using System;
using System.Collections.Generic;

/************************************************************************************
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 *
 * Example 1:
 * Input: nums = [2,7,11,15], target = 9
 * Output: [0,1]
 * Output: Because nums[0] + nums[1] == 9, we return [0, 1].
 ************************************************************************************/

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(new[] { 2, 7, 11, 15 }, 18);
            Console.ReadKey();
        }

        private static void Print(int[] nums, int target)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = Solution.TwoSum(nums, target);
            watch.Stop();
            if (results.Length == 2)
            {
                Console.WriteLine($"1. Two Sums\n" +
                                  $"Input Array = {PrintInputArray(nums)} target = {target}\n" +
                                  $"Result: [{results[0]}, {results[1]}] \n" +
                                  $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
            }
        }

        private static string PrintInputArray<T>(T[] input)
        {
            string result = "[ ";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                result += $"{input[i]} ";
            }

            result += "]";
            return result;
        }
    }

    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new[] { i, dict[diff] };
                dict.TryAdd(nums[i], i);
            }

            return new[] { 0, 0 };
        }
    }
}