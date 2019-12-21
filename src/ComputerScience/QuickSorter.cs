using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class QuickSorter: ISorter
    {
        public void Sort(int[] A)
        {
            this.Sort(A, 0, A.Length - 1);
        }

        private int[] Sort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                Sort(A, p, q - 1);
                Sort(A, q + 1, r);
            }

            return A;
        }

        private int Partition(int[] A, int p, int r)
        {
            int pivot = A[r];
            int i = p - 1;

            for (int j = p; j <= r - 1; j++)
            {
                if (A[j] <= pivot)
                {
                    i += 1;
                    var y = A[i];
                    A[i] = A[j];
                    A[j] = y;
                }
            }

            var temp = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp;

            return i + 1;
        }        
    }
}
