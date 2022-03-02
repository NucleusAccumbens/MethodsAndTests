using Methods.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests
{
    public class TwoDimensionalArrayTests
    {
        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixTest_1()
        {
            int[,] matr = new int[,] { { 4, 7, 3, 8, 5 },
                                       { 1, 3, 3, 4, 9 },
                                       { 3, 2, 3, 4, 5 },
                                       { 9, 0, 3, 6, 3 } };

            int[,] actual = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matr);

            int[,] expected = new int[,] { { -4, -7, -3, -8, -5 },
                                           { -1,  3,  3,  4, -9 },
                                           { -3,  2,  3,  4, -5 },
                                           { -9, -0, -3, -6, -3 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixTest_2()
        {
            int[,] matr = new int[,] { { -4, 7,  3,  8 },
                                       { 1,  3,  3,  4 },
                                       { 3,  2,  3,  4 },
                                       { 9,  0, -3,  6 } };

            int[,] actual = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matr);

            int[,] expected = new int[,] { {  4, -7, -3,  -8 },
                                           { -1,  3,  3,  -4 },
                                           { -3,  2,  3,  -4 },
                                           { -9, -0,  3,  -6 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixTest_3()
        {
            int[,] matr = new int[,] { { -4, -7, -3, -8, -5 },
                                       { -1,  3,  3,  4, -9 },
                                       { -3, -2, -3, -4, -5 } };

            int[,] actual = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matr);

            int[,] expected = new int[,] { { 4,  7,  3,  8, 5 },
                                           { 1,  3,  3,  4, 9 },
                                           { 3,  2,  3,  4, 5 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixTest_4()
        {
            int[,] matr = new int[,] { { 0, 0, 0, 0, 0 },
                                       { 0, 3, 3, 4, 0 },
                                       { 0, 0, 0, 0, 0 } };

            int[,] actual = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matr);

            int[,] expected = new int[,] { { 0, 0, 0, 0, 0 },
                                           { 0, 3, 3, 4, 0 },
                                           { 0, 0, 0, 0, 0 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixTest_5()
        {
            int[,] matr = new int[,] { { -0, -0, -0, -0, -0 },
                                       { -0,  3,  3,  4, -0 },
                                       { -0, -0, -0, -0, -0 } };

            int[,] actual = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matr);

            int[,] expected = new int[,] { { 0, 0, 0, 0, 0 },
                                           { 0, 3, 3, 4, 0 },
                                           { 0, 0, 0, 0, 0 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSignOfTheNumberatEdgesOfMatrixNegativeTest()
        {
            int[,] actual = new int[,] { };
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(actual));
        }

        [Test]
        public void WriteInMultiplicatioTableTest()
        {
            int[,] actual = TwoDimensionalArray.WriteInMultiplicationTable();


            int[,] expected = new int[,] { { 1,  2,  3,  4,  5,  6,  7,  8,  9  },
                                           { 2,  4,  6,  8,  10, 12, 14, 16, 18 },
                                           { 3,  6,  9,  12, 15, 18, 21, 24, 27 },
                                           { 4,  8,  12, 16, 20, 24, 28, 32, 36 },
                                           { 5,  10, 15, 20, 25, 30, 35, 40, 45 },
                                           { 6,  12, 18, 24, 30, 36, 42, 48, 54 },
                                           { 7,  14, 21, 28, 35, 42, 49, 56, 63 },
                                           { 8,  16, 24, 32, 40, 48, 56, 64, 72 },
                                           { 9,  18, 27, 36, 45, 54, 63, 72, 81 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FillInLikeChessboardTest_1()
        {
            int[,] expected = new int[,] { { 1, 0 },
                                           { 0, 1 } };

            int[,] actual = TwoDimensionalArray.FillInLikeChessboard(2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FillInLikeChessboardTest_2()
        {
            int[,] expected = new int[,] { { 0, 1, 0 },
                                           { 1, 0, 1 },
                                           { 0, 1, 0 } };

            int[,] actual = TwoDimensionalArray.FillInLikeChessboard(3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FillInLikeChessboardTest_3()
        {
            int[,] expected = new int[,] { { 1, 0, 1, 0 },
                                           { 0, 1, 0, 1 },
                                           { 1, 0, 1, 0 },
                                           { 0, 1, 0, 1 } };

            int[,] actual = TwoDimensionalArray.FillInLikeChessboard(4);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FillInLikeChessboardTest_4()
        {
            int[,] expected = new int[,] { { 0, 1, 0, 1, 0 },
                                           { 1, 0, 1, 0, 1 },
                                           { 0, 1, 0, 1, 0 },
                                           { 1, 0, 1, 0, 1 },
                                           { 0, 1, 0, 1, 0 } };

            int[,] actual = TwoDimensionalArray.FillInLikeChessboard(5);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FillInLikeChessboardTest_5()
        {
            int[,] expected = new int[,] { { 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1 } };

            int[,] actual = TwoDimensionalArray.FillInLikeChessboard(6);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void FillInLikeChessboardNegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.FillInLikeChessboard(x));
        }


        [Test]
        public void CheckSeatingRuleTest_1()
        {
            int[,] matr = new int[,] { { 0, 1, 0, 0, 1, 0 },
                                       { 0, 0, 1, 0, 1, 0 },
                                       { 0, 1, 0, 0, 0, 0 },
                                       { 0, 1, 0, 0, 1, 0 } };

            bool expected = false;

            bool actual = TwoDimensionalArray.CheckSeatingRule(matr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSeatingRuleTest_2()
        {
            int[,] matr = new int[,] { { 0, 1, 1, 0, 1, 0 },
                                       { 0, 0, 1, 0, 1, 0 },
                                       { 0, 1, 0, 0, 0, 0 },
                                       { 0, 1, 0, 0, 1, 0 } };

            bool expected = true;

            bool actual = TwoDimensionalArray.CheckSeatingRule(matr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSeatingRuleTest_3()
        {
            int[,] matr = new int[,] { { 0, 0, 0, 0, 0, 0 },
                                       { 0, 0, 0, 0, 0, 0 },
                                       { 0, 0, 0, 0, 0, 0 },
                                       { 0, 0, 0, 0, 0, 0 } };

            bool expected = false;

            bool actual = TwoDimensionalArray.CheckSeatingRule(matr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSeatingRuleTest_4()
        {
            int[,] matr = new int[,] { { 0, 1, 1, 0, 0, 1 },
                                       { 1, 0, 0, 0, 1, 0 },
                                       { 0, 1, 0, 0, 0, 0 },
                                       { 0, 1, 0, 0, 1, 0 } };

            bool expected = true;

            bool actual = TwoDimensionalArray.CheckSeatingRule(matr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSeatingRuleTest_5()
        {
            int[,] matr = new int[,] { { 0, 1 },
                                       { 1, 0 } };

            bool expected = false;

            bool actual = TwoDimensionalArray.CheckSeatingRule(matr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSeatingRuleNegativeTest()
        {
            int[,] actual = new int[,] { };
            Assert.Throws<ArgumentException>(() => TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(actual));
        }

        [Test]
        public void SumShopsProfitTest()
        {
            double[,] profit = new double[,] { { 15.5, 18.5, 19.00, 20.00, 15.5, 16.00 },
                                               { 10.5, 18.5, 13.00, 20.00, 14.5, 16.00 },
                                               { 17.5, 18.5, 16.00, 21.00, 15.5, 17.00 },
                                               { 15.1, 16.5, 17.00, 22.00, 15.5, 13.00 },
                                               { 16.5, 17.5, 19.00, 23.00, 11.5, 19.00 },
                                               { 15.5, 13.5, 14.00, 10.00, 12.5, 16.00 },
                                               { 15.0, 11.5, 19.00, 20.00, 19.5, 16.00 },
                                               { 15.5, 18.5, 14.00, 20.00, 17.5, 23.00 },
                                               { 18.5, 13.5, 15.00, 10.00, 15.5, 16.00 },
                                               { 10.5, 12.5, 16.00, 18.00, 20.5, 16.00 } };

            double[] expected = new double[] { 104.5, 92.5, 105.5, 99.1, 106.5, 81.5, 101, 108.5, 88.5, 93.5 };

            double[] actual = TwoDimensionalArray.SumShopsProfit(profit);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AverageMonthlyProfitTest()
        {
            double[,] profit = new double[,] { { 15.5, 18.5, 19.00, 20.00, 15.5, 16.00 },
                                               { 10.5, 18.5, 13.00, 20.00, 14.5, 16.00 },
                                               { 17.5, 18.5, 16.00, 21.00, 15.5, 17.00 },
                                               { 15.1, 16.5, 17.00, 22.00, 15.5, 13.00 },
                                               { 16.5, 17.5, 19.00, 23.00, 11.5, 19.00 },
                                               { 15.5, 13.5, 14.00, 10.00, 12.5, 16.00 },
                                               { 15.0, 11.5, 19.00, 20.00, 19.5, 16.00 },
                                               { 15.5, 18.5, 14.00, 20.00, 17.5, 23.00 },
                                               { 18.5, 13.5, 15.00, 10.00, 15.5, 16.00 },
                                               { 10.5, 12.5, 16.00, 18.00, 20.5, 16.00 } };

            double[] expected = new double[] { 15.01, 15.9, 16.2, 18.4, 15.8, 16.8 };


            double[] actual = TwoDimensionalArray.AverageMonthlyProfit(profit);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MinMaxProfitTest()
        {
            double[,] profit = new double[,] { { 15.5, 18.5, 19.00, 20.00, 15.5, 16.00 },
                                               { 10.5, 18.5, 13.00, 20.00, 14.5, 16.00 },
                                               { 17.5, 18.5, 16.00, 21.00, 15.5, 17.00 },
                                               { 15.1, 16.5, 17.00, 22.00, 15.5, 13.00 },
                                               { 16.5, 17.5, 19.00, 23.00, 11.5, 19.00 },
                                               { 15.5, 13.5, 14.00, 10.00, 12.5, 16.00 },
                                               { 15.0, 11.5, 19.00, 20.00, 19.5, 16.00 },
                                               { 15.5, 18.5, 14.00, 20.00, 17.5, 23.00 },
                                               { 18.5, 13.5, 15.00, 10.00, 15.5, 16.00 },
                                               { 10.5, 12.5, 16.00, 18.00, 20.5, 16.00 } };

            double[] expected = new double[] { 10.00, 23.00 };

            double[] actual = TwoDimensionalArray.MinMaxProfit(profit);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DrawAnHourglassTest()
        {
            char[,] expected = new char[,] { { '1', '1', '1', '1', '1', '1', '1' },
                                             { '0', '1', '1', '1', '1', '1', '0' },
                                             { '0', '0', '1', '1', '1', '0', '0' },
                                             { '0', '0', '0', '1', '0', '0', '0' },
                                             { '0', '0', '1', '1', '1', '0', '0' },
                                             { '0', '1', '1', '1', '1', '1', '0' },
                                             { '1', '1', '1', '1', '1', '1', '1' } };

            char[,] actual = TwoDimensionalArray.DrawAnHourglass();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyMatrixTest()
        {
            int[,] one = new int[,] { { 1, 2, 3 },
                                      { 3, 2, 1 } };

            int[,] two = new int[,] { { 1, 2 },
                                      { 3, 2 },
                                      { 4, 2 } };

            int[,] expected = new int[,] { { 19, 12 },
                                           { 13, 12 } };

            int[,] actual = TwoDimensionalArray.MultiplyMatrix(one, two);
            Assert.AreEqual(expected, actual);
        }
    }
}
