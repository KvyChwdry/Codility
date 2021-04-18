namespace Codility
{
    class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            /* Total Score: 44
             Task Score: 44
             Correctness: 25
             Performance: 60*/

            //return (Y - X) / D + 1;

            /* Total Score: 100
             Task Score: 100
             Correctness: 100
             Performance: 100
             My fault for not being patient and not thinking before submitting*/

            int diff = Y - X;
            return diff / D + (diff % D == 0 ? 0 : 1);
        }
    }
}
