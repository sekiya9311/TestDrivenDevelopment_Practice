using System;
using System.Collections.Generic;
using System.Text;

namespace _01_MoneyExample
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var other = (Dollar)obj;
            return this.amount == other.amount;
        }

        public override int GetHashCode()
        {
            return this.amount.GetHashCode();
        }
    }
}
