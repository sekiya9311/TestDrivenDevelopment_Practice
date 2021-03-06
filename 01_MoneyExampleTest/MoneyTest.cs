﻿using System;
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
                Assert.Equal(new Dollar(10), five.Times(2));
            }

            {
                Assert.Equal(new Dollar(15), five.Times(3));
            }
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));

            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
