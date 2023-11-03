using NUnit.Framework;

namespace UnitTests2
{
    internal class Tests
    {
        [TestCase(995, 3)]

        [Test]
        public void Zalias(int number1, int number2)
        {

            int expectedResult = 0;


            double actualResult = Skaiciavimas.Dalinimas(number1, number2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
