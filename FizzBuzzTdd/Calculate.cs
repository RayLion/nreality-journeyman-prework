using System.Globalization;

namespace FizzBuzzTdd
{
    public class Calculate
    {
        private static string _result;

        public static string CalculateOutcome(int number)
        {
            _result = string.Empty;

            AddFizzToResultIfDivisableByThree(number);
            AddBuzzToResultIfDivisableByFive(number);
            SetResultToNumberIfNotDivisableByThreeOrFive(number);

            return _result;
        }

        private static void SetResultToNumberIfNotDivisableByThreeOrFive(int number)
        {
            if (string.IsNullOrEmpty(_result))
                _result = number.ToString(CultureInfo.InvariantCulture);
        }

        private static void AddFizzToResultIfDivisableByThree(int number)
        {
            if (number%3 == 0)
                _result += "Fizz";
        }

        private static void AddBuzzToResultIfDivisableByFive(int number)
        {
            if (number%5 == 0)
                _result += "Buzz";
        }
    }
}