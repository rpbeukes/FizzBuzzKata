using System;
using Xunit;
using Shouldly;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzzKata
    {
        private IEnumerable<string> FuzzBuzz(int upperBound)
        {
            for (int i = 1; i < upperBound + 1; i++)
            {
                if (i % 15 == 0)
                    yield return "FizzBuzz";

                else if (i % 3 == 0)
                    yield return "Fizz";

                else if (i % 5 == 0)
                    yield return "Buzz";

                else
                    yield return i.ToString();
            }
        }

        [Fact]
        public void Print_numbers_from_1_100()
        {
            int size = 100;
            var result = FuzzBuzz(size).ToList();
            result.Count.ShouldBe(size);
        }

        //[Fact]
        //public void Print_numbers_one_through_two()
        //{
        //    int size = 2;
        //    TestCase(size, new[] { "1", "2" });
        //}

        //[Fact]
        //public void Print_numbers_one_through_three()
        //{
        //    int size = 3;
        //    TestCase(size, new[] { "1", "2", "Fizz" });

        //}

        //[Fact]
        //public void Print_numbers_one_through_five()
        //{
        //    int size = 5;
        //    TestCase(size, new[] { "1", "2", "Fizz", "4", "Buzz" });
        //}

        [Fact]
        public void Print_numbers_one_through_15()
        {
            int size = 15;
            TestCase(size, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" });
        }

        [Fact]
        public void Print_numbers_spot_check_60()
        {
            int size = 100;
            var result = FuzzBuzz(size).ToList();
            result.ElementAt(59).ShouldBe("FizzBuzz");
        }

        [Fact]
        public void Print_numbers_spot_check_100()
        {
            int size = 100;
            var result = FuzzBuzz(size).ToList();
            result.ElementAt(99).ShouldBe("Buzz");
        }

        [Theory]
        [InlineData(2, new[] { "1", "2" })]
        [InlineData(3, new[] { "1", "2", "Fizz" })]
        [InlineData(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
        private void TestCase(int size, string[] expectedValues)
        {
            var result = FuzzBuzz(size).ToList();
            result.ShouldBe(expectedValues);
        }

    }
}
