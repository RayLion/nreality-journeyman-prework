using System.Globalization;
using NUnit.Framework;

namespace FizzBuzzTdd
{
    [TestFixture]
    public class FizzBuzzFixture
    {
        [TestCase(3)]
        [TestCase(6)]
        public void GivenNumberThatIsDivisableByThree_WhenCalculateOutcome_FizzIsReturned(int number)
        {
            var answer = Calculate.CalculateOutcome(number);
            Assert.AreEqual("Fizz", answer);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void GivenNumberThatIsDivisableByFive_WhenCalculateOutcome_BuzzIsReturned(int number)
        {
            var answer = Calculate.CalculateOutcome(number);
            Assert.AreEqual("Buzz", answer);
        }

        [TestCase(15)]
        public void GivenNumberThatIsDivisableByThreeAndFive_WhenCalculate_ThenFizzBuzz(int number)
        {
            var answer = Calculate.CalculateOutcome(number);
            Assert.AreEqual("FizzBuzz", answer);	
        }
        
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void GivenNumberThatAreNotDivisableByThreeOrFive_WhenCalculate_ThenNumberIsReturned(int number)
        {
            var answer = Calculate.CalculateOutcome(number);
            Assert.AreEqual(number.ToString(CultureInfo.InvariantCulture), answer);	
        }
    }
}
