using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Start with the first string as the prefix
            string prefix = strs[0];

            // Compare the prefix with each string in the array
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Shorten the prefix by one character each time
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If we shorten it to an empty string, return ""
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }
            return prefix;
        }
        void main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}


