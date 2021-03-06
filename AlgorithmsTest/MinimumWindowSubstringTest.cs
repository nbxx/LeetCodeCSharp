using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MinimumWindowSubstringTest
    {
        [Theory]
        [InlineData("", "", "")]
        public void TestMethod(string s, string t, string output)
        {
            Assert.Equal(output, Solution076.MinWindow(s, s));
        }
    }
}

