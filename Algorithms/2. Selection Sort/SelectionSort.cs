using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class SelectionSort
    {

        public static void SortArray(int[] input)
        {
            int smallest;

            for(int i= 0; i < input.Length-1;i++)
            {
                smallest = i;

                for(int j= i+1;j<input.Length;j++)
                {
                    if (input[j] < input[smallest])
                    {
                        smallest = j;
                    }
                }

                //Swap values
                int temp = input[smallest];
                input[smallest] = input[i];
                input[i] = temp;

            }

        }

    }
}
