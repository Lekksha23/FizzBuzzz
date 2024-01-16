using FizzBuzz.Entities;
using FizzBuzz.Tests.TestData;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    internal class GoodBoyTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ReplaceNumbers_ShouldReturnInputListWithSwitchedNumbersAccordingConditions()
        {
            // given
            var goodBoy = new GoodBoy(FizzBuzzTestData.GetTestDataForMuzzGuzzAndGoodBoyClasses());
            var expected = FizzBuzzTestData.GetResultListForGoodBoyClass();

            // when
            var actual = goodBoy.ReplaceNumbers();

            // then
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Count, Is.GreaterThan(0));
            Assert.That(actual.Count, Is.EqualTo(expected.Count));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
