using SeminarTasks.Task3;

namespace SeminarTasks.Tests
{
    public class ClocksDegreeCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(2, 60)]
        [TestCase(6, 180)]
        [TestCase(20, 120)]
        [TestCase(120, 0)]
        public void CheckNumberReverse(int hours, int expectedDegrees)
        {
            Assert.That(ClocksDegreeCalculator.DegreesFromHours(hours),
                Is.EqualTo(expectedDegrees));
        }

        [TestCase(-15)]
        [TestCase(-2)]
        public void ThrowsOnHoursLowerThanZero(int hours)
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            ClocksDegreeCalculator.DegreesFromHours(hours));
        }
    }
}
