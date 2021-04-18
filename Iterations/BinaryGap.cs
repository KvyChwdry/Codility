using System;
using System.Linq;

namespace Codility
{
    class BinaryGap
    {
        public int solution(int N)
        {
            int maxBGap = 0;
            int previousIndex = 0;
            int currentBGap = 0;

            char[] bArray = Convert.ToString(N, 2).ToArray();

            for (int i = 0; i < bArray.Length; i++)
            {
                if (bArray[i] == '0')
                {
                    currentBGap = i - previousIndex;
                    if (maxBGap < currentBGap)
                        maxBGap = currentBGap;
                }
                else if (bArray[i] == '1')
                {
                    previousIndex = i;
                    if (Array.LastIndexOf(bArray, '1') == i)
                        return maxBGap;
                }
            }

            return maxBGap;
        }
    }
}
