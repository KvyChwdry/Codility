using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            /* Total Score: 50
             Task Score: 50
             Correctness: 100
             Performance: 0
             Performance.*/
            // Detected time complexity: O(B - A)

            //if (A == B && B == K) return 1;
            //int result = 0;

            //for(int i = A; i <= B; i++)
            //{
            //    if (i % K == 0) result++;
            //}

            //return result;

            /* Total Score: 100
             Task Score: 100
             Correctness: 100
             Performance: 0
             Performance.*/
            // Detected time complexity: O(1)

            if (A == B && B == K) return 1;
            int result = 0;

            int firstDiv = A;
            int lastDiv = B;

            while(firstDiv % K != 0)
            {
                firstDiv = firstDiv + 1;
            }

            while (lastDiv % K != 0)
            {
                lastDiv = lastDiv - 1;
            }

            result = ((lastDiv - firstDiv) / K) + 1;

            return result;
        }
    }
}
