using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SignalProcessor.Analysis;

namespace SignalProcessor.Tests.Analysis
{
    [TestFixture]
    public class ArithmeticMeanCalculatorTests
    {

        ArithmeticMeanCalculator calculator;

        [SetUp]
        public void SetupObjectsForTests()
        {
            calculator = new ArithmeticMeanCalculator();
        }

        [Test]
        [TestCase(7, 4, 7, 10)]
        [TestCase(1451.83, 0.004, 0.0003, 0.05, 0.1, 7259)]
        public void ShouldReturnArithmeticMeanFromSet(double expectedValue, params double[] set)
        {
            var result = calculator.Calculate(set);

            Assert.That(expectedValue, Is.EqualTo(result).Within(0.001));
        }

        [Test]
        public void ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Calculate(null));
            Assert.Throws<ArgumentException>(() => calculator.Calculate(new double[] { }));
        }

    }
}
