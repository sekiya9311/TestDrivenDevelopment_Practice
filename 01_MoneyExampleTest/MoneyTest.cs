using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using _01_MoneyExample;

namespace _01_MoneyExampleTest
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.amount);
        }
    }
}
