/* Expression 1
 * Как поменять местами значения двух переменных?
 * Можно ли это сделать без ещё одной временной переменной.
 * Стоит ли так делать?
 */

namespace SeminarTasks.Task1
{
    public static class NumberExcanger
    {
        public static void Exchange(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}
