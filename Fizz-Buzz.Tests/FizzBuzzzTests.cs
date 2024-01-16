using FizzBuzz.Entities;
using FizzBuzz.Tests.TestData;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzzTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ReplaceNumbers_ShouldReturnInputListWithSwitchedNumbersAccordingConditions()
        {
            // given
            var fizzBuzz = new FizzBuzzz(FizzBuzzTestData.GetTestDataForFizzBuzzClass());
            var expected = FizzBuzzTestData.GetResultListForFizzBuzzClass();

            // when
            var actual = fizzBuzz.ReplaceNumbers();

            // then
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Count, Is.GreaterThan(0));
            Assert.That(actual.Count, Is.EqualTo(expected.Count));
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}