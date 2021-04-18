using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            /*Below code gave perf issue. Total Score: 66
             Task Score: 66
             Correctness: 100
             Performance: 25*/

            //int[] distinctA = A.Distinct().ToArray();   

            //for(int i = 0; i < distinctA.Length; i++)
            //{
            //    if (A.Where(x => x == distinctA[i]).Count() % 2 != 0) return distinctA[i];
            //}

            //return 0;

            /* Total Score: 66
             Task Score: 66
             Correctness: 80
             Performance: 50
             Improved performance but no longer correct */

            //if (A.Length == 1) return A[0];

            //Array.Sort(A);

            //for(int i = 0; i < A.Length; i++)
            //{
            //    if (i == 0)
            //        if (A[i] != A[i + 1])
            //            return A[0];
            //        else
            //            continue;
            //    if (i == A.Length - 1)
            //        if (A[i - 1] != A[i])
            //            return A[i];
            //        else
            //            continue;
            //    if (A[i - 1] != A[i] && A[i] != A[i + 1]) return A[i];
            //}

            //return 0;

            /*Copied from https://codereview.stackexchange.com/questions/128605/find-the-odd-occurrences-in-an-array/128608
             */

            /* Total Score: 100
             Task Score: 100
             Correctness: 100
             Performance: 100
             Simple and clean*/

            int result = 0;
            foreach (var i in A)
                result ^= i;
            return result;
        }
    }
}
