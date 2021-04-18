using System;

namespace Codility
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            int prev = 1;
            Array.Sort(A);

            foreach(var item in A)
            {
                if (item != prev) return 0;
                prev++;
            }

            return 1;
        }
    }
}
