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

            {
                var product = five.Times(2);
                Assert.Equal(10, product.amount);
            }

            {
                var product = five.Times(3);
                Assert.Equal(15, product.amount);
            }
        }
    }
}
