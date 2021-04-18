using System;
using System.Linq;

/* Check edge cases
 * 1. empty arrays
 * 2. K greater than arrays length
 */

namespace Codility
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0) return A;
            int lenA = A.Length;
            K = K % lenA;

            if (lenA == K || A.Distinct().Count() == 1) return A;

            int[] output = new int[lenA];

            for (int i = 0; i < lenA; i++)
            {
                if (i + K < lenA)
                {
                    output[i + K] = A[i];
                }
                else
                {
                    output[Math.Abs(lenA - i - K)] = A[i];
                }
            }

            return output;
        }
    }
}
