using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class CheckerForIsogram
    {
        [Fact]
        public void TrueForTestString()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
    }
}
