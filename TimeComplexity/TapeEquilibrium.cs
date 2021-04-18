using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            /* Total Score: 15
             Task Score: 15
             Correctness: 28
             Performance: 0
             Should consider that the first value might be negative*/

            //int p = 1, output = A[0], diff = 0;
            //while(p < A.Length)
            //{
            //    diff = Math.Abs(A.Take(p).Sum() - A.Skip(p).Sum());
            //    if (diff < output) output = diff;
            //    p++;
            //}

            //return output;

            /* Total Score: 30
             Task Score: 30
             Correctness: 57
             Performance: 0
             Should consider that the length of the array is just 2*/

            //if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            //int p = 1, output = Math.Abs(A[0]), diff = 0;
            //while (p < A.Length)
            //{
            //    diff = Math.Abs(A.Take(p).Sum() - A.Skip(p).Sum());
            //    if (diff < output) output = diff;
            //    p++;
            //}

            //return output;

            /* Total Score: 38
             Task Score: 38
             Correctness: 71
             Performance: 0
             using A[0] was not a good idea*/
            // Detected time complexity: O(N * N)

            //if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            //int p = 1, output = Math.Abs(A[0]), diff = 0;
            //while (p < A.Length)
            //{
            //    diff = Math.Abs(A.Take(p).Sum() - A.Skip(p).Sum());
            //    if (diff < output) output = diff;
            //    p++;
            //}

            //return output;

            /* Total Score: 53
             Task Score: 53
             Correctness: 100
             Performance: 0
             All correct. Focus on performance now*/
            // Detected time complexity: O(N * N)

            //    if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            //    int p = 1, output = Int32.MaxValue, diff = 0;
            //    while (p < A.Length)
            //    {
            //        diff = Math.Abs(A.Take(p).Sum() - A.Skip(p).Sum());
            //        if (diff < output) output = diff;
            //        p++;
            //    }

            //    return output;

            /* Total Score: 84
             Task Score: 84
             Correctness: 71
             Performance: 100
             Copied from https://rameshere.wordpress.com/2015/08/12/c-codility-tape-equilibrium-solution/#:~:text=Problem%20Statement%3A%20The%20variable%20of,compute%20and%20compare%20the%20difference.
             Should consider that the length of the array is just 2*/
            // Detected time complexity: O(N)

            //List<int> diffs = new List<int>();
            //int left = 0;
            //int sum = A.Sum();
            //foreach (int item in A)
            //{
            //    left += item;
            //    diffs.Add(Math.Abs(sum  - 2*left));
            //}
            //return diffs.Min();

            /* Total Score: 92
             Task Score: 92
             Correctness: 85
             Performance: 100
             Copied from https://rameshere.wordpress.com/2015/08/12/c-codility-tape-equilibrium-solution/#:~:text=Problem%20Statement%3A%20The%20variable%20of,compute%20and%20compare%20the%20difference.
             Merging the copied code and mine */
            // Detected time complexity: O(N)

            //if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            //List<int> diffs = new List<int>();
            //int left = 0;
            //int sum = A.Sum();
            //foreach (int item in A)
            //{
            //    left += item;
            //    diffs.Add(Math.Abs(sum - 2 * left));
            //}
            //return diffs.Min();

            /* Total Score: 92
             Task Score: 92
             Correctness: 85
             Performance: 100
             last one should not be considered in the loop */
            // Detected time complexity: O(N)

            if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            List<int> diffs = new List<int>();
            int left = 0;
            int sum = A.Sum();
            foreach (int item in A.Take(A.Length - 1))
            {
                left += item;
                diffs.Add(Math.Abs(sum - 2 * left));
            }
            return diffs.Min();

            //Overall, very poor performance
        }
    }
}
