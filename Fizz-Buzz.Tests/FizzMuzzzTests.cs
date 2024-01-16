using FizzBuzz.Entities;
using FizzBuzz.Tests.TestData;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    internal class FizzMuzzzTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ReplaceNumbers_ShouldReturnInputListWithSwitchedNumbersAccordingConditions()
        {
            // given
            var fizzMuzz = new FizzMuzzz(FizzBuzzTestData.GetTestDataForMuzzGuzzAndGoodBoyClasses()); 
            var expected = FizzBuzzTestData.GetResultListForFizzMuzzClass();

            // when
            var actual = fizzMuzz.ReplaceNumbers();

            // then
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Count, Is.GreaterThan(0));
            Assert.That(actual.Count, Is.EqualTo(expected.Count));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
