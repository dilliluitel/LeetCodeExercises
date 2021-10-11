using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    public class TwoSum
    {
        /*public int[] TwoSum1(int[] nums, int target)
        {

            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = j;
                        result[1] = i;
                    }
                }
            }
            return result;
        }*/

        //O(N) time complexity
        public int[] TwoSum2(int[] nums, int target)
        {
            // [2, 7, 8, 10, 11]
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = i;
                    dict.TryGetValue(target-nums[i], out result[1]);
                }
                dict.TryAdd(nums[i], i);
            }
            return result;    
        }
    }
}
