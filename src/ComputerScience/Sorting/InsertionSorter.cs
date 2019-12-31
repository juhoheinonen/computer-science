using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class InsertionSorter : ISorter
    {
        public void Sort(int[] A)
        {
            for (int j = 1; j < A.Length; j++)
            {
                var key = A[j];
                int i = j - 1;
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i--;
                }
                A[i + 1] = key;
            }
        }
    }
}
