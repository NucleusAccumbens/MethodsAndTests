using Methods.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    public class TermAndCastTests
    {

        [TestCase(-123, 6)]
        [TestCase(123, 6)]
        [TestCase(-100, 1)]
        [TestCase(100, 1)]
        [TestCase(999, 27)]
        public void SumOfDigitTest(int a, int expected)
        {
            int actual = TermAndCast.SumOfDigit(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(001)]
        [TestCase(1000)]
        [TestCase(-9999)]
        [TestCase(099)]
        [TestCase(15)]
        public void SumOfDigitNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => TermAndCast.SumOfDigit(a));
        }

        [TestCase(5, 4, 89, false)]
        [TestCase(12, 34, 8, true)]
        [TestCase(0, 0, 3, false)]
        [TestCase(56, 24, 67, false)]
        [TestCase(-35, 12, 44, false)]
        public void ReturneHitTest(double x, double y, double r, bool expected)
        {
            bool actual = TermAndCast.ReturneHit(x, y, r);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 4, 0)]
        public void ReturneHitNegativeTest(double x, double y, double r)
        {
            Assert.Throws<ArgumentException>(() => TermAndCast.ReturneHit(x, y, r));
        }

        [TestCase(345, true)]
        [TestCase(-123, true)]
        [TestCase(321, false)]
        [TestCase(100, false)]
        [TestCase(-443, false)]
        public void CompareDigOfNumTest(int z, bool expected)
        {
            bool actual = TermAndCast.CompareDigOfNum(z);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-29)]
        public void CompareDigOfNumNegativeTest(int z)
        {
            Assert.Throws<ArgumentException>(() => TermAndCast.CompareDigOfNum(z));
        }

        [TestCase(123, 321)]
        [TestCase(-546, -645)]
        [TestCase(101, 101)]
        [TestCase(-222, -222)]
        [TestCase(456, 654)]
        public void SwapDigOfNumTest(int num, int expected)
        {
            int actual = TermAndCast.SwapDigOfNum(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4567)]
        public void SwapDigOfNumNegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => TermAndCast.SwapDigOfNum(num));
        }

        [TestCase(56.6, true)]
        [TestCase(34.01, true)]
        [TestCase(78.00, false)]
        [TestCase(100, false)]
        [TestCase(-5.0, false)]
        public void CheckZeroInFractionPartTest(double w, bool expected)
        {
            bool actual = TermAndCast.CheckZeroInFractionPart(w);
            Assert.AreEqual(expected, actual);
        }
    }
}
