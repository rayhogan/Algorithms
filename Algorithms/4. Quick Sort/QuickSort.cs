using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int pivot = SplitArray(input, left, right);

                if (pivot > 1)
                {
                    Sort(input, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(input, pivot + 1, right);
                }
            }
        }

        private static int SplitArray(int[] input, int left, int right)
        {
            int pivotPoint = input[left];
            while (true)
            {

                while (input[left] < pivotPoint)
                {
                    left++;
                }

                while (input[right] > pivotPoint)
                {
                    right--;
                }

                if (left < right)
                {
                    if (input[left] == input[right]) return right;

                    int temp = input[left];
                    input[left] = input[right];
                    input[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
