using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static void SortArray(int[] input)
        {
            int temp;

            for(int i=0;i<=input.Length-2;i++)
            {
                for(int j=0; j<=input.Length-2;j++)
                {
                    if(input[j] > input[j+1])
                    {
                        temp = input[j+1];
                        input[j+1] = input[j];
                        input[j] = temp;
                    }
                }
            }
        }

  
    }
}
