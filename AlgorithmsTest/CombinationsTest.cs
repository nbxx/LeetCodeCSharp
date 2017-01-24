using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationsTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int k, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution077.Combine(n, k));
        }
    }
}

