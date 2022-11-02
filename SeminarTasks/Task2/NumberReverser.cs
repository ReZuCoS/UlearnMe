/* Expression 2
 * Задается натуральное трехзначное число (гарантируется, что трехзначное).
 * Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
 */

namespace SeminarTasks.Task2
{
    public static class NumberReverser
    {
        public static int ReverseThreeDigitNumber(int number)
        {
            if(number.ToString().Length != 3)
                throw new ArgumentOutOfRangeException($"\"{nameof(number)}\" value must be a three-digit number!");

            char[] ch = number.ToString().ToCharArray();

            return int.Parse($"{ch[2]}{ch[1]}{ch[0]}");
        }
    }
}
