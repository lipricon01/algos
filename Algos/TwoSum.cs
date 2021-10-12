using System.Collections.Generic;

namespace Algos
{
    public class TwoSum
    {
        public int[] TwoSumHash(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i <= nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return new int[2];
        }

        public int[] TwoSumBroot(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[2];
        }
    }
}