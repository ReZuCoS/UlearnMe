using SeminarTasks.Task4;

namespace SeminarTasks.Tests
{
    public class DivisorsCounterTests
    {
        [TestCase(-45, 12, 2)]
        [TestCase(-5, 13, 1)]
        [TestCase(-12, 0, 0)]
        public void ThrowsOnLowerOrEqualZero(int n, int x, int y)
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            DivisorsCounter.Count(n, x, y));
        }

        [TestCase(24, 4, 11)]
        [TestCase(58, 6, 2)]
        [TestCase(9, 12, 3)]
        public void ThrowsOnNotPrimeX(int n, int x, int y)
        {
            Assert.Throws(typeof(ArgumentException), () =>
            DivisorsCounter.Count(n, x, y));
        }

        [TestCase(829, 11, 15)]
        [TestCase(60, 13, 25)]
        [TestCase(7, 3, 4)]
        public void ThrowsOnNotPrimeY(int n, int x, int y)
        {
            Assert.Throws(typeof(ArgumentException), () =>
            DivisorsCounter.Count(n, x, y));
        }

        [TestCase(20, 3, 5, 8)]
        [TestCase(30, 5, 7, 9)]
        [TestCase(10, 3, 5, 4)]
        public void CheckDivisorsCount(int n, int x, int y, int expectedDivisiorsCount)
        {
            Assert.That(DivisorsCounter.Count(n, x, y), Is.EqualTo(expectedDivisiorsCount));
        }
    }
}
