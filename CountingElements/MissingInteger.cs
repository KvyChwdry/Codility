using System;
using System.Linq;

namespace Codility
{
    class MissingInteger
    {
        public int solution(int[] A)
        {
            /* Total Score: 55
             Task Score: 55
             Correctness: 60
             Performance: 50
             Should consider that the array can have both positive and negative.*/

            //if (A.Where(x => x > 0).Count() == 0) return 1;

            //int[] B = A.Distinct().ToArray();
            //Array.Sort(B);
            //int prev = 1;
            //for(int i = 0; i < B.Length; i++)
            //{
            //    if (B[i] != prev) return prev;
            //    prev++;
            //}

            //return B.Max()+1;

            /* Total Score: 100
             Task Score: 100
             Correctness: 100
             Performance: 100
             Read the question clearly.*/

            if (A.Where(x => x > 0).Count() == 0) return 1;

            int[] B = A.Where(x => x > 0).Distinct().ToArray();
            Array.Sort(B);
            int prev = 1;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] != prev) return prev;
                prev++;
            }

            return B.Max() + 1;
        }
    }
}
