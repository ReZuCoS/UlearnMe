/* Expression 4
 * Найти количество чисел меньших N,
 * которые имеют простые делители X или Y.
 */

namespace SeminarTasks.Task4
{
    public static class DivisorsCounter
    {
        public static int Count(int n, int x, int y)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException($"\"{nameof(n)}\" must be more than 0!");
            
            if (!IsPrime(x))
                throw new ArgumentException($"\"{nameof(x)}\" must be a prime number!");

            if (!IsPrime(y))
                throw new ArgumentException($"\"{nameof(y)}\" must be a prime number!");

            int divisorsCount = 0;

            for (int i = 1; i < n; i++)
            {
                if ((i % x == 0) || (i % y == 0))
                    divisorsCount++;
            }

            return divisorsCount;
        }

        private static bool IsPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
