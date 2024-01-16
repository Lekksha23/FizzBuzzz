namespace FizzBuzz.Tests.TestData
{
    internal class FizzBuzzTestData
    {
        internal static List<int> GetTestDataForFizzBuzzClass() => new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        internal static List<object> GetResultListForFizzBuzzClass() => new List<object>() { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizz-buzz" };

        internal static List<int> GetTestDataForMuzzGuzzAndGoodBoyClasses() => new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

        internal static List<object> GetResultListForFizzMuzzClass() => new List<object>() { 1, 2, "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", 11, "fizz-muzz", 13, "guzz", "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };

        internal static List<object> GetResultListForGoodBoyClass() => new List<object>() { 1, 2, "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", 11, "fizz-muzz", 13, "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };
    }
}
