using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class _88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;  // Указатель на последний элемент в nums1, который не ноль
            int p2 = n - 1;  // Указатель на последний элемент в nums2
            int p = m + n - 1;  // Указатель на последний элемент в массиве nums1

            // Пока есть элементы для сравнения
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
                p--;
            }

            // Если остались элементы в nums2, копируем их в nums1
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p--;
                p2--;
            }
        }
    }
}
