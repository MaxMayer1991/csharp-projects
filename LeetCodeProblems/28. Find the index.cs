using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _28
    {

        public int StrStr(string haystack, string needle)
        {
            // Handle the edge case where needle is an empty string
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            // Use the IndexOf method to find the first occurrence of needle in haystack
            return haystack.IndexOf(needle);
        }
    }
}