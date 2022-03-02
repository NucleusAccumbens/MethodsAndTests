using Methods.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    internal class CalculateAndIOTests
    {
        public enum GlueStringForMockVariants { for_0_and_5, for_0_and_minus5, for_minus5_and_5, for_0_and_6dot5, for_0_and_0 };
        public string GlueStringForMock(GlueStringForMockVariants variant)
        {
            switch (variant)
            {
                case GlueStringForMockVariants.for_0_and_5:
                    return $"привет, 0!\n" +
                           $"0 + 5 = 5\n" +
                           $"пока, 5...";
                case GlueStringForMockVariants.for_0_and_minus5:
                    return $"привет, 0!\n" +
                           $"0 + -5 = -5\n" +
                           $"пока, -5...";
                case GlueStringForMockVariants.for_minus5_and_5:
                    return $"привет, -5!\n" +
                           $"-5 + 5 = 0\n" +
                           $"пока, 5...";
                case GlueStringForMockVariants.for_0_and_6dot5:
                    return $"привет, 0!\n" +
                           $"0 + 6,5 = 6,5\n" +
                           $"пока, 6,5...";
                case GlueStringForMockVariants.for_0_and_0:
                    return $"привет, 0!\n" +
                           $"0 + 0 = 0\n" +
                           $"пока, 0...";
                default: return null;
            }
        }

        [TestCase(0, 5, GlueStringForMockVariants.for_0_and_5)]
        [TestCase(0, -5, GlueStringForMockVariants.for_0_and_minus5)]
        [TestCase(-5, 5, GlueStringForMockVariants.for_minus5_and_5)]
        [TestCase(0, 6.5, GlueStringForMockVariants.for_0_and_6dot5)]
        [TestCase(0, 0, GlueStringForMockVariants.for_0_and_0)]
        public void GlueStringTest(int a, double b, GlueStringForMockVariants variant)
        {
            string expected = GlueStringForMock(variant);
            string actual = CalculateAndIO.GlueString(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 0, -5)]
        [TestCase(10, 0, -5)]
        [TestCase(0, 10, 1000)]
        [TestCase(1, 2, 21)]
        public void CalculateTest(double a, double b, double expected)
        {
            double actual = CalculateAndIO.Calculate(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0)]
        [TestCase(5, 5)]
        public void CalculateNegativeTest(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => CalculateAndIO.Calculate(a, b));
        }

        [TestCase("поменяй", "местами", new string[] { "местами", "поменяй" })]
        [TestCase("начало", "конец", new string[] { "конец", "начало" })]
        [TestCase("старт", "финиш", new string[] { "финиш", "старт" })]
        [TestCase("я", "есть", new string[] { "есть", "я" })]
        [TestCase("1", "2", new string[] { "2", "1" })]
        public void SwapStringValuesTest(string a, string b, string[] expected)
        {
            string[] actual = CalculateAndIO.SwapStringValues(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("", "abc")]
        [TestCase("abc", "")]
        public void SwapStringValuesNegativeTest(string a, string b)
        {
            Assert.Throws<ArgumentException>(() => CalculateAndIO.SwapStringValues(a, b));
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(1, 2, 0, -2)]
        [TestCase(1, 0, 3, 3)]
        [TestCase(1, 0, 0, 0)]
        [TestCase(427, 0, 0, 0)]
        public void CalculateEquationTest(double a, double b, double c, double expected)
        {
            double actual = CalculateAndIO.CalculateEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 2)]
        public void CalculateEquationNegativeTest(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => CalculateAndIO.CalculateEquation(a, b, c));
        }
    }
}
