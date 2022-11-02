using SeminarTasks.Task1;

namespace SeminarTasks.Tests
{
    public class NumberExchangerTests
    {
        [TestCase(5, 6, 6, 5)]
        [TestCase(15, 50, 50, 15)]
        [TestCase(-55, 26, 26, -55)]
        [TestCase(-2, -5, -5, -2)]
        public void CheckValuesExchange(int a, int b, int expectedA, int expectedB)
        {
            NumberExcanger.Exchange(ref a, ref b);

            Assert.Multiple(() =>
            {
                Assert.That(a, Is.EqualTo(expectedA));
                Assert.That(b, Is.EqualTo(expectedB));
            });
        }
    }
}
