using Methods.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    internal class SingleDimensionalarrayTests
    {
        [Test]
        public void CountEvenOddElementsTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };

            int[] expected = { 2, 3 };
            int[] actual = SingleDimensionalArray.CountEvenOddElements(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountEvenOddElementsNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.CountEvenOddElements(mas));
        }

        [Test]
        public void ChangeThirdElemWithSumTwoPreviosTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] expected = { 1, 2, 3, 4, 5, 9 };
            int[] actual = SingleDimensionalArray.ChangeThirdElemWithSumTwoPrevios(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeThirdElemWithSumTwoPreviosNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ChangeThirdElemWithSumTwoPrevios(mas));
        }

        [Test]
        public void ConcatenateAttaysTest()
        {
            int[] mas_one = new int[] { 1, 2, 3, 4, 5 };
            int[] mas_two = new int[] { 6, 7, 8, 9, 0 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] actual = SingleDimensionalArray.ConcatenateAttays(mas_one, mas_two);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConcatenateAttaysNegativeTes_1()
        {
            int[] mas_one = new int[] { };
            int[] mas_two = new int[] { 6, 7, 8, 9, 0 };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ConcatenateAttays(mas_one, mas_two));
        }

        [Test]
        public void ConcatenateAttaysNegativeTes_2()
        {
            int[] mas_one = new int[] { 6, 7, 8, 9, 0 };
            int[] mas_two = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ConcatenateAttays(mas_one, mas_two));
        }

        [Test]
        public void SwapArrayHalvesTest_1()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] expected = { 4, 5, 6, 1, 2, 3 };
            int[] actual = SingleDimensionalArray.SwapArrayHalves(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapArrayHalvesTest_2()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int[] expected = { 5, 6, 7, 1, 2, 3, 4 };
            int[] actual = SingleDimensionalArray.SwapArrayHalves(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapArrayHalvesNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.SwapArrayHalves(mas));
        }

        [Test]
        public void ShiftArrayElemByOnePositionsTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int[] expected = { 7, 1, 2, 3, 4, 5, 6 };
            int[] actual = SingleDimensionalArray.ShiftArrayElemByOnePositions(mas);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ShiftArrayElemByOnePositionsNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ShiftArrayElemByOnePositions(mas));
        }

        [TestCase(2)]
        public void ShiftArrayElemByNPositionsTest(int N)
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int[] expected = { 6, 7, 1, 2, 3, 4, 5 };
            int[] actual = SingleDimensionalArray.ShiftArrayElemByNPositions(mas, N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        public void ShiftArrayElemByNPositionsNegativeTest_1(int N)
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ShiftArrayElemByNPositions(mas, N));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ShiftArrayElemByNPositionsNegativeTest_2(int N)
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ShiftArrayElemByNPositions(mas, N));
        }

        [TestCase(10)]
        public void ShiftArrayElemByNPositionsNegativeTest_3(int N)
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Throws<ArgumentOutOfRangeException>(() => SingleDimensionalArray.ShiftArrayElemByNPositions(mas, N));
        }

        [Test]
        public void ChangeEvenElemToOddTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int[] expected = { 2, 1, 4, 3, 6, 5, 7 };
            int[] actual = SingleDimensionalArray.ChangeEvenElemToOdd(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeEvenElemToOddNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.ChangeEvenElemToOdd(mas));
        }

        [Test]
        public void FindMinModulElemAndSumAfterZeroTest()
        {
            int[] mas = new int[] { -1, 2, 3, 4, 0, 5, 6, -7, -10, 12, -35 };

            int[] expected = { -35, -29 };
            int[] actual = SingleDimensionalArray.FindMinModulElemAndSumAfterZero(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindMinModulElemAndSumAfterZeroNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.FindMinModulElemAndSumAfterZero(mas));
        }

        [Test]
        public void SortArrayInsertTest()
        {
            int[] mas = { -1, 2, 3, 4, 0, 5, 6, -7, -10, 12, -35 };

            int[] expected = { -35, -10, -7, -1, 0, 2, 3, 4, 5, 6, 12 };
            int[] actual = SingleDimensionalArray.SortArrayInsert(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SortArrayInsertTestNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.SortArrayInsert(mas));
        }

        [Test]
        public void SortArraySelectTest()
        {
            int[] mas = { -1, 2, 3, 4, 0, 5, 6, -7, -10, 12, -35 };

            int[] expected = { -35, -10, -7, -1, 0, 2, 3, 4, 5, 6, 12 };
            int[] actual = SingleDimensionalArray.SortArraySelect(mas);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SortArraySelectNegativeTest()
        {
            int[] mas = new int[] { };
            Assert.Throws<ArgumentException>(() => SingleDimensionalArray.SortArraySelect(mas));
        }

    }
}
