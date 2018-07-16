using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzzNumbers _fizzBuzzList;
        [SetUp]
        protected void SetUp()
        {
            _fizzBuzzList = new FizzBuzzNumbers();
        }

        [Test]
        public void TestMultiplesOfThree()
        {
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[3], "Fizz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[6], "Fizz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[9], "Fizz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[96], "Fizz");
        }

        [Test]
        public void TestMultiplesOfFive()
        {
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[5], "Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[10], "Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[20], "Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[95], "Buzz");
        }

        [Test]
        public void TestMultiplesOfThreeAndFive()
        {
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[15], "Fizz Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[30], "Fizz Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[45], "Fizz Buzz");
            Assert.AreEqual(_fizzBuzzList.FizzBuzzOutput()[90], "Fizz Buzz");
        }
    }
}