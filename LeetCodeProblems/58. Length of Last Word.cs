using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _58
    {
        public int LengthOfLastWord(string s)
        {
            int counter = 0;
            string reversed = new string(s.Reverse().ToArray());
            foreach(char i in reversed)
            {

                if (i == ' ' && counter == 0)
                {
                    continue;
                }
                else if (i != ' ' && counter == 0)
                {
                    counter++;
                    continue;
                }
                else if(i != ' ' && counter != 0)
                {
                    counter++;
                    continue;
                }
                else if(i == ' ' && counter != 0)
                {
                     return counter;
                }


            }
            return counter;
        }
    }
}

