using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Fraction
    {
        public int dividend;
        public int divisor;
        public Fraction(int dividend, int divisor)
        {
            this.dividend = dividend;
            this.divisor = divisor;
        }
        public void display()
        {
            Console.WriteLine($"{dividend} / {divisor}");
        }
    }
}
