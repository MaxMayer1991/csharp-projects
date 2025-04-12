using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueCount = 1; // Start with the first element being unique

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
        static void main(string[] args)
        {
            _26 solution = new _26();

            int[] nums = new int[] { 1, 1, 2 };
            Console.WriteLine(solution.RemoveDuplicates(nums)); // Output: 2

            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(solution.RemoveDuplicates(nums)); // Output: 5
        }
    }
}
