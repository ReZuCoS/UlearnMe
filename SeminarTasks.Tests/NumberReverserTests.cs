using SeminarTasks.Task2;

namespace SeminarTasks.Tests
{
    public class NumberReverserTests
    {
        [TestCase(123, 321)]
        [TestCase(555, 555)]
        [TestCase(765, 567)]
        public void CheckNumberReverse(int number, int expectedReversedNumber)
        {
            Assert.That(NumberReverser.ReverseThreeDigitNumber(number),
                Is.EqualTo(expectedReversedNumber));
        }

        [TestCase(2)]
        [TestCase(55)]
        [TestCase(1257)]
        public void ThrowsOnNonThreeDigitsNumber(int number)
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            NumberReverser.ReverseThreeDigitNumber(number));
        }
    }
}
