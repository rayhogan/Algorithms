using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms
{
    public class MergeSort
    {
        public static List<int> Sort(List<int> input)
        {
            return Merge_Sort(input);
        }

        private static List<int> Merge_Sort(List<int> input)
        {
            if (input.Count <= 1)
                return input;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = input.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(input[i]);
            }

            for (int i = middle; i < input.Count; i++)
            {
                right.Add(input[i]);
            }

            left = Merge_Sort(left);
            right = Merge_Sort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> sorted = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        sorted.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        sorted.Add(right.First());
                        right.Remove(right.First());
                    }

                }
                else if (left.Count > 0)
                {
                    sorted.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    sorted.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return sorted;
        }
    }
}
