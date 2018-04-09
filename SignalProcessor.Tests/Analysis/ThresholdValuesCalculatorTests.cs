using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SignalProcessor.Analysis;

namespace SignalProcessor.Tests.Analysis
{
    [TestFixture]
    public class ThresholdValuesCalculatorTests
    {

        ThresholdValuesCalculator calculator;

        [SetUp]
        public void SetObjectsForTests()
        {
            calculator = new ThresholdValuesCalculator();
        }


        [Test]
        [TestCase(5, 10, 7, 5, 8)]
        [TestCase(-10, 1, -7, -5, 8, -10)]
        [TestCase(5025678, 15034558, 5025678, 7000000, 8658365)]
        public void ShouldReturnMinimumValueFromSet(double expectedValue, params double[] set)
        {
            var result = calculator.Min(set);

            Assert.That(expectedValue, Is.EqualTo(result));
        }


        [Test]
        [TestCase(17, 10, 17, 5, 3)]
        [TestCase(-1, -4, -7, -50, -1, -10)]
        [TestCase(8658365, 1034558, 5025678, 7000000, 8658365)]
        public void ShouldReturnMaximumValueFromSet(double expectedValue, params double[] set)
        {
            var result = calculator.Max(set);

            Assert.That(expectedValue, Is.EqualTo(result));
        }

        [Test]
        public void ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Min(null));
            Assert.Throws<ArgumentException>(() => calculator.Min(new double[] { }));

            Assert.Throws<ArgumentException>(() => calculator.Max(null));
            Assert.Throws<ArgumentException>(() => calculator.Max(new double[] { }));
        }
    }
}
