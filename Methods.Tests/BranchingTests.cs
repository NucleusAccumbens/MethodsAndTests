using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    internal class BranchingTests
    {
        [TestCase(7.3, 4, 11.3)]
        [TestCase(5, 5, 25)]
        [TestCase(3.5, 7.5, -4)]
        [TestCase(-11, -26, -37)]
        [TestCase(0, 3, -3)]
        public void AddMultiplyOrSubtractTest(double a, double b, double expected)
        {
            double actual = Branching.AddMultiplyOrSubtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 1)]
        [TestCase(5, -5, 2)]
        [TestCase(-3.5, -7.5, 3)]
        [TestCase(-11, 26, 4)]
        public void DefineQuarterTest(double x, double y, int expected)
        {
            int actual = Branching.DefineQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(0, 5)]
        [TestCase(3, 0)]
        [TestCase(-7, 0)]
        [TestCase(0, -34)]
        public void DefineQuarterNegativeTest(double x, double y)
        {
            Assert.Throws<ArgumentException>(() => Branching.DefineQuarter(x, y));
        }

        [TestCase(23, -16, 78)]
        public void SortAscendingTest(double a, double b, double c)
        {
            double[] expected = { -16, 23, 78 };
            double[] actual = Branching.SortAscending(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, -4, 2, new double[] { })]
        [TestCase(1, 2, 1, new double[] { -1 })]
        [TestCase(1, -4, -5, new double[] { -1, 5 })]
        public void SolveQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Branching.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, "Двадцать пять")]
        [TestCase(11, "Одинадцать")]
        [TestCase(48, "Сорок восемь")]
        [TestCase(50, "Пятьдесят")]
        [TestCase(16, "Шестнадцать")]
        public void NameTheNumberTest(int a, string expected)
        {
            string actual = Branching.NameTheNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        [TestCase(100)]
        [TestCase(-22)]
        public void NameTheNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Branching.NameTheNumber(a));
        }

        [TestCase(6, 8, 4, true)]
        [TestCase(5, 7, 9, true)]
        [TestCase(1, 3, 6, false)]
        [TestCase(8, 3, 29, false)]
        public void DetermineTriangleExistsTest(double a, double b, double c, bool expected)
        {
            bool actual = Branching.DetermineTriangleExists(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 5)]
        [TestCase(-8, 9, 4)]
        [TestCase(15, 0, 1)]
        [TestCase(-3, 9, 0)]
        [TestCase(3, 9, 0)]
        public void DetermineTriangleExistsNegativeTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Branching.DetermineTriangleExists(a, b, c));
        }
    }
}
