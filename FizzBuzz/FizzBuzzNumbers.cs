using System.Collections.Generic;


namespace FizzBuzz
{
    public class FizzBuzzNumbers
    {
        private const int NumberOfFizzBuzzNumbers = 100;

        public List<string> FizzBuzzOutput()
        {
            List<string> fizzBuzzNumbers = new List<string>();
            for (int i = 0; i < NumberOfFizzBuzzNumbers; i++)
            {
                string element = "";

                if (i % 3 == 0 && i % 5 == 0)
                {
                    element += "Fizz Buzz";
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    element += "Buzz";
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    element += "Fizz";
                }
                else
                {
                    element += i;
                }
                fizzBuzzNumbers.Add(element);
            }
            return fizzBuzzNumbers;
        }
    }
}