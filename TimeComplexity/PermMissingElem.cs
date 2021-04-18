using System;

namespace Codility
{
    class PermMissingElem
    {
        public int solution(int[] A)
        {
            int x = 1;
            Array.Sort(A);
            foreach (var item in A)
            {
                if(x < item)
                    return x;
                else
                    x++;
            }
            return x;
        }
    }
}
