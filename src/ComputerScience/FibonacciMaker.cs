using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class FibonacciMaker
    {
        public int RecursiveSlowFibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return RecursiveSlowFibonacci(n - 1) + RecursiveSlowFibonacci(n - 2);
        }

        public int RecursiveEffectiveFibonacci(int n, int[] memo = null)
        {
            if (memo == null)
            {
                memo = new int[Math.Max(2, n + 1)];
                memo[0] = 0;
                memo[1] = 1;
            }

            if (n <= 0)
            {
                return memo[0];
            }
            else if (n == 1)
            {
                return memo[1];
            }
            else
            {
                if (memo[n] == 0)
                {
                    memo[n] = RecursiveEffectiveFibonacci(n - 1, memo) + RecursiveEffectiveFibonacci(n - 2, memo);

                }
            }

            return memo[n];
        }
    }
}
