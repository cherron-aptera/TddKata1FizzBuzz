using System;
using Xunit;

namespace TddKata1FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fb = new FizzBuzz();
            var output = fb.Print(1);

            Assert.Equal(output, "1");
        }

        [Fact]
        public void Test2()
        {
            var fb = new FizzBuzz();
            var output = fb.Print(2);

            Assert.Equal(output, "1\n2");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "1\n2")]
        [InlineData(3, "1\n2\nFizz")]
        [InlineData(5, "1\n2\nFizz\n4\nBuzz")]
        [InlineData(15, "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz")]
        public void TestX(int limit, string expected)
        {
            var fb = new FizzBuzz();
            var output = fb.Print(limit);

            Assert.Equal(output, expected);
        }

    }
}
