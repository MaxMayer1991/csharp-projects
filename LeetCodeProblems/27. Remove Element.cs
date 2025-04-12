using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0; // This will track the position to place the next non-val element

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
        static void main(string[] args)
        {
            _27 solution = new _27();

            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;

            int result = solution.RemoveElement(nums, val);

            Console.WriteLine("The new length of the array is: " + result);
        }
    }
}
