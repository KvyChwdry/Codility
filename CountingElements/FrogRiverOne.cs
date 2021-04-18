using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            /* Total Score: 63
             Task Score: 63
             Correctness: 66
             Performance: 60
             IndexOf returns -1 when element is not found*/

            //int[] indexes = new int[X];
            //int i = 0;

            //while(i < A.Length && i < X)
            //{
            //    indexes[i] = Array.IndexOf(A, i + 1);
            //    i++;
            //}

            //return (indexes.Where(y => y == 0).Count() > 1) ? -1 : indexes.Max();

            /* Total Score: 81
             Task Score: 81
             Correctness: 100
             Performance: 60
             All correct but need to improve performance*/
            // Detected time complexity: O(N)

            //int[] indexes = new int[X];
            //int i = 0;

            //while (i < A.Length && i < X)
            //{
            //    indexes[i] = Array.IndexOf(A, i + 1);
            //    i++;
            //}

            //return indexes.Contains(-1) ? -1 : indexes.Max();

            /* Total Score: 100
             Task Score: 100
             Correctness: 100
             Performance: 100
             Copied from https://stackoverflow.com/questions/19459197/java-codility-frog-river-one/25860700#25860700
             Smart.Unnecessary loops avoided and the initial check helps. */
            // Detected time complexity: O(N)

            int[] B = A.Distinct().ToArray();
            return (B.Length != X) ? -1 : Array.IndexOf(A, B[B.Length - 1]);
        }
    }
}
