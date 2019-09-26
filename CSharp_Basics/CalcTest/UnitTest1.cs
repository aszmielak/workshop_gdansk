using System;
using Kalkulator;
using NUnit;
using NUnit.Framework;

namespace CalcTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,4,5)]
        [TestCase(-1, -4, -5)]
        [TestCase(-4, 4, 0)]
        [TestCase(10, 10000, 10010)]
        [TestCase(int.MaxValue, int.MaxValue, 5)]
        public void AddingOperation_PositiveValue(int firstValue, int secondValue, int expectedResult)
        {
            //Arrange - przygotowujemy dane
            MathData mathData = new MathData(firstValue, secondValue, "+");

            //Act - to co testujemy
            var result = Calculations.GetResultValue(mathData);

            //Assert - robimy asercję
            Assert.AreEqual(expectedResult, result);
        }

        ////dodać do innych działań
    }
}
