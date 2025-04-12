using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _13
    {
        public int RomanToInt(string s)
        {
            // Словарь для сопоставления римских цифр с их значениями
            var romanToDigit = new Dictionary<char, int>()
            {
                { 'I', 1},
                { 'V', 5},
                { 'X' , 10},
                { 'L' , 50},
                { 'C' , 100},
                { 'D' , 500},
                { 'M' , 1000}
            };

            int sum = 0;
            int currentNumeral, nextNumeral;

            // Проходим по всем символам строки
            for (int i = 0; i < s.Length; i++)
            {
                // Текущее значение римской цифры
                currentNumeral = romanToDigit[s[i]];

                // Если это не последний символ, получаем значение следующей римской цифры
                if (i < s.Length - 1)
                {
                    nextNumeral = romanToDigit[s[i + 1]];

                    // Если текущее значение меньше следующего, вычитаем текущее значение из суммы
                    if (currentNumeral < nextNumeral)
                    {
                        sum -= currentNumeral;
                    }
                    // В противном случае добавляем текущее значение к сумме
                    else
                    {
                        sum += currentNumeral;
                    }
                }
                else
                {
                    // Если это последний символ, просто добавляем его значение к сумме
                    sum += currentNumeral;
                }
            }
            return sum;
        }
        void main(string[] args)
        {
            string romanNumber = "III";
            Console.WriteLine(RomanToInt(romanNumber));
        }
    }
        
}
        
    
