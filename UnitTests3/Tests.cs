using Skaiciuotuvas;
using NUnit.Framework;
using System;

namespace UnitTests3
{
    public class Tests
    {
        [TestCase(995, 3)]

        [Test]
        public void BeLiekanos(int number1, int number2)
        {

            int expectedResult = 0;


            int actualResult = Skaiciavimas.Liekana(number1, number2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Wednesday()
        {
            string expectedResult = DayOfWeek.Wednesday.ToString();

            string actualResult = SavaitesDienuPalyginimas.DienuPalyginimas();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Hour13()
        {
            string expectedResult = "13h";

            string actualResult = ValanduPalyginimas.Valanda();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
