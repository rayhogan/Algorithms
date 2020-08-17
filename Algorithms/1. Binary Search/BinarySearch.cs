using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// Find index of a number in a sorted array using binary search
        /// </summary>
        /// <param name="input"></param>
        /// <param name="searchNumber"></param>
        /// <returns></returns>
        public static int FindIndex(int[] input, int searchNumber)
        {
            int low = 0;
            int high = input.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = input[mid];

                if(guess == searchNumber)
                {
                    return mid;
                } 
                else if(guess > searchNumber)
                {
                    high = mid - 1;
                }
                else if(guess < searchNumber)
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
