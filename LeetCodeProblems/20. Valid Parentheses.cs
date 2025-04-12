using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                // Push opening brackets onto the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Process closing brackets
                else
                {
                    // If stack is empty or top doesn't match the corresponding opening bracket, return false
                    if (stack.Count == 0 || !IsMatchingPair(stack.Peek(), c))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }

            // If stack is empty, all brackets are matched
            return stack.Count == 0;
        }
        private bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
        static void main(string[] args)
        {
            _20 validator = new _20();
            Console.WriteLine(validator.IsValid("()")); // True
            Console.WriteLine(validator.IsValid("()[]{}")); // True
            Console.WriteLine(validator.IsValid("(]")); // False
            Console.WriteLine(validator.IsValid("([)]")); // False
            Console.WriteLine(validator.IsValid("{[]}")); // True
        }
    }

}