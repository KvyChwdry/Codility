using System.Linq;

namespace Codility
{
    class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            /* Total Score: 66
             Task Score: 66
             Correctness: 100
             Performance: 40
             Performance.*/

            //int[] output = new int[N];

            //foreach (var item in A)
            //{
            //    if (1 <= item && item <= N)
            //    {
            //        output[item - 1]++;
            //    }
            //    else if (item == N + 1)
            //    {
            //        call the function here for tracking purpose, adding the function
            //        int max = output.Max();
            //        for (int i = 0; i < output.Length; i++)
            //        {
            //            output[i] = max;
            //        }
            //    }
            //}

            //return output;

            /* Total Score: 66
             Task Score: 66
             Correctness: 100
             Performance: 40
             Didn't improve performance.*/

            //int[] output = new int[N];
            //int maxValue = 0;

            //foreach (var item in A)
            //{
            //    if (1 <= item && item <= N)
            //    {
            //        output[item - 1]++;
            //    }
            //    else if (item == N + 1)
            //    {
            //        maxValue += output.Max();
            //        output = new int[N];
            //    }
            //}

            //if(maxValue > 0)
            //{
            //    call the function here for tracking purpose, adding the function
            //    //setArrayValue(output, maxValue);
            //    for (int i = 0; i < output.Length; i++)
            //    {
            //        output[i] += maxValue;
            //    }
            //}

            //return output;

            /* Total Score: 66
             Task Score: 66
             Correctness: 100
             Performance: 40
             Try later.*/

            int[] output = new int[N];
            int maxValue = 0;

            foreach (var item in A)
            {
                if (1 <= item && item <= N)
                {
                    output[item - 1]++;
                }
                else if (item == N + 1)
                {
                    maxValue += output.Max();
                    output = new int[N];
                }
            }

            if (maxValue > 0)
            {
                setArrayValue(output, maxValue);
            }

            return output;
        }

        public int[] setArrayValue(int[] array, int value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] += value;
            }
            return array;
        }
    }
}
