using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            var underTest = new StringCalculator();

            var result = underTest.Add("");

            Assert.Equal(0, result);
        }
    }
}
