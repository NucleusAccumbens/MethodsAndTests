using Methods.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    public class LoopTests
    {

        public enum FindDivisorsUpToThousandForAMockVariants { On50, On100, On300 };

        public List<int> FindDivisorsUpToThousandForAMock(FindDivisorsUpToThousandForAMockVariants variant)
        {
            switch (variant)
            {
                case FindDivisorsUpToThousandForAMockVariants.On50:
                    return new List<int>(
                        new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600,
                        650, 700, 750, 800, 850, 900, 950, 1000 });
                case FindDivisorsUpToThousandForAMockVariants.On100:
                    return new List<int>(
                        new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
                case FindDivisorsUpToThousandForAMockVariants.On300:
                    return new List<int>(new int[] { 300, 600, 900 });
                default: return null;
            }
        }

        [TestCase(50, FindDivisorsUpToThousandForAMockVariants.On50)]
        [TestCase(100, FindDivisorsUpToThousandForAMockVariants.On100)]
        [TestCase(300, FindDivisorsUpToThousandForAMockVariants.On300)]
        public void FindDivisorsUpToThousandTest(int A, FindDivisorsUpToThousandForAMockVariants variant)
        {
            List<int> expected = FindDivisorsUpToThousandForAMock(variant);
            List<int> actual = Loop.FindDivisorsUpToThousand(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1005)]
        [TestCase(0)]
        [TestCase(-28)]
        public void FindDivisorsUpToThousandNegativeTest(int A)
        {
            Assert.Throws<ArgumentException>(() => Loop.FindDivisorsUpToThousand(A));
        }

        [TestCase(5, 2)]
        [TestCase(15, 3)]
        [TestCase(25, 4)]
        [TestCase(30, 5)]
        [TestCase(40, 6)]
        [TestCase(250, 15)]
        public void SumOfNumbersWithSquareLessTest(int a, int expected)
        {
            int actual = Loop.SumOfNumbersWithSquareLess(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-6)]
        public void SumOfNumbersWithSquareLessNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Loop.SumOfNumbersWithSquareLess(a));
        }

        [TestCase(10, 5)]
        [TestCase(-10, 5)]
        [TestCase(25, 5)]
        [TestCase(-25, 5)]
        [TestCase(1000, 500)]
        public void CalculateMaxDivisorTest(int a, int expected)
        {
            int actual = Loop.CalculateMaxDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void CalculateMaxDivisorNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Loop.CalculateMaxDivisor(a));
        }

        [TestCase(13, 50, 189)]
        [TestCase(-2, 15, 21)]
        [TestCase(0, 29, 70)]
        [TestCase(7, 0, 7)]
        [TestCase(-11, 10, 0)]
        public void SumOfNumberDivisibleBySevenTest(ref int a, ref int b, int expected)
        {
            int actual = Loop.SumOfNumberDivisibleBySeven(ref a, ref b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(45, 50, 5)]
        [TestCase(1000, 10, 10)]
        [TestCase(64, 128, 64)]
        [TestCase(35, 6, 1)]
        [TestCase(-20, 10, 10)]
        public void CalculateMaxCommonDivisorTest(int a, int b, int expected)
        {
            int actual = Loop.CalculateMaxCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 6)]
        [TestCase(249, 0)]
        public void CalculateMaxCommonDivisorNegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Loop.CalculateMaxCommonDivisor(a, b));
        }

        [TestCase(8, 2)]
        [TestCase(27, 3)]
        [TestCase(64, 4)]
        [TestCase(125, 5)]
        [TestCase(1000, 10)]
        [TestCase(531441, 81)]
        public void ToExtractCubeRootTest(int n, int expected)
        {
            int actual = Loop.ToExtractCubeRoot(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-125)]
        [TestCase(0)]
        [TestCase(127)]
        public void ToExtractCubeRootNegativeTest(int n)
        {
            Assert.Throws<ArgumentException>(() => Loop.ToExtractCubeRoot(n));
        }

        [TestCase(2312345, 4)]
        [TestCase(2317345, 5)]
        [TestCase(2312342, 3)]
        [TestCase(1312345, 5)]
        [TestCase(2222242, 0)]
        public void CountAmountOddDigTest(int a, int expected)
        {
            int actual = Loop.CountAmountOddDig(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void CountAmountOddDigNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Loop.CountAmountOddDig(a));
        }

        [TestCase(125, 521)]
        [TestCase(876, 678)]
        [TestCase(4567, 7654)]
        [TestCase(1234567, 7654321)]
        [TestCase(12, 21)]
        public void FindMirrorNumberTest(int num, int expected)
        {
            int actual = Loop.FindMirrorNumber(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindMirrorNumberNegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => Loop.FindMirrorNumber(num));
        }


        public enum CompareOddAndEvenSumOfDigForMockVariants { For40, For50, For70 };

        public List<int> CompareOddAndEvenSumOfDigForMock(CompareOddAndEvenSumOfDigForMockVariants variant)
        {
            switch (variant)
            {
                case CompareOddAndEvenSumOfDigForMockVariants.For40:
                    return new List<int>
                    { 10, 20, 21, 30, 31, 32 };

                case CompareOddAndEvenSumOfDigForMockVariants.For50:
                    return new List<int>
                    { 10, 20, 21, 30, 31, 32, 40, 41, 42, 43};

                case CompareOddAndEvenSumOfDigForMockVariants.For70:
                    return new List<int>
                    { 10, 20, 21, 30, 31, 32, 40, 41, 42, 43, 50, 51, 52, 53, 54, 60, 61, 62, 63, 64, 65 };
                default: return null;

            }
        }

        [TestCase(40, CompareOddAndEvenSumOfDigForMockVariants.For40)]
        [TestCase(50, CompareOddAndEvenSumOfDigForMockVariants.For50)]
        [TestCase(70, CompareOddAndEvenSumOfDigForMockVariants.For70)]
        public void CompareOddAndEvenSumOfDigTest(int a, CompareOddAndEvenSumOfDigForMockVariants variant)
        {
            List<int> expected = CompareOddAndEvenSumOfDigForMock(variant);
            List<int> actual = Loop.CompareOddAndEvenSumOfDig(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(125, 521, true)]
        [TestCase(876, 678, true)]
        [TestCase(123, 456, false)]
        [TestCase(789, 1, false)]
        [TestCase(111, 21, true)]
        public void FindCommonDigitTest(int a, int b, bool expected)
        {
            bool actual = Loop.FindCommonDigit(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
