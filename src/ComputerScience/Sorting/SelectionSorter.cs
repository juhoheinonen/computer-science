using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class SelectionSorter : ISorter
    {
        public void Sort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                var smallestIndex = i;
                
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[smallestIndex])
                    {                        
                        smallestIndex = j;
                    }
                }
                int temp = A[i];
                A[i] = A[smallestIndex];
                A[smallestIndex] = temp;
            }
        }
    }
}
