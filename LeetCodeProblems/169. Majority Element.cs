using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _169
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int majorityCount = nums.Length / 2;

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }

                if (counts[num] > majorityCount)
                {
                    return num;
                }
            }

            return -1;
        }
    }
}
