using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class PlusOneTest
    {
        [Theory]
        [InlineData(new int[]{0}, new int[]{1})]
        public void TestMethod(int[] digits, int[] output)
        {
            Assert.Equal(output, Solution066.PlusOne(digits));
        }
    }
}

