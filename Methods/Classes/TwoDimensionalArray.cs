using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Classes
{
    public class TwoDimensionalArray //Lesson_6
    {
        public static int[,] ReverseSignOfTheNumberatEdgesOfMatrix(int[,] matr)
        {
            if (matr.GetLength(0) == 0 || matr.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                matr[i, 0] *= -1;
                matr[i, matr.GetLength(1) - 1] *= -1;
            }
            for (int j = 1; j < matr.GetLength(1) - 1; j++)
            {
                matr[0, j] *= -1;
                matr[matr.GetLength(0) - 1, j] *= -1;
            }
            return matr;
        }

        public static int[,] WriteInMultiplicationTable()
        {

            int[,] matr = new int[9, 9];

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = (i + 1) * (j + 1);
                }
            }
            return matr;
        }

        public static int[,] FillInLikeChessboard(int n)
        {
            if (n == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0!");
            if (n < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 0!");

            int[,] matr = new int[n, n];
            bool colore = false;

            for (int i = matr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = colore ? 1 : 0;
                    colore = !colore;
                }
                if (n % 2 == 0) colore = !colore;
            }
            return matr;
        }


        public static bool CheckSeatingRule(int[,] matr)
        {
            if (matr.GetLength(0) == 0 || matr.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            bool violation = false;

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (j < matr.GetLength(1) - 1 &&
                        matr[i, j] == 1 &&
                        matr[i, j] == matr[i, j + 1])
                    {
                        violation = true;
                        return violation;
                    }
                }
            }
            return violation;
        }

        public static double[] SumShopsProfit(double[,] profit)
        {
            if (profit.GetLength(0) == 0 || profit.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            double[] sum_profit = new double[profit.GetLength(0)];

            for (int i = 0; i < profit.GetLength(0); i++)
            {
                double sum = 0;

                for (int j = 0; j < profit.GetLength(1); j++)
                {
                    sum += profit[i, j];
                }
                sum_profit[i] = sum;
            }
            return sum_profit;
        }

        public static double[] AverageMonthlyProfit(double[,] profit)
        {
            if (profit.GetLength(0) == 0 || profit.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            double[] average_profit = new double[profit.GetLength(1)];

            for (int i = 0; i < profit.GetLength(0); i++)
            {
                for (int j = 0; j < profit.GetLength(1); j++)
                {
                    average_profit[j] += profit[i, j];
                }
            }

            for (int i = 0; i < profit.GetLength(1); i++)
            {
                average_profit[i] = average_profit[i] / profit.GetLength(0);
            }
            return average_profit;
        }

        public static double[] MinMaxProfit(double[,] profit)
        {
            if (profit.GetLength(0) == 0 || profit.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            double min_profit = profit[0, 0];
            double max_profit = profit[0, 0];
            double[] res = new double[2];

            for (int i = 0; i < profit.GetLength(0); i++)
            {

                for (int j = 0; j < profit.GetLength(1); j++)
                {
                    if (profit[i, j] < min_profit) min_profit = profit[i, j];
                    if (profit[i, j] > max_profit) max_profit = profit[i, j];
                }
            }
            res[0] = min_profit;
            res[1] = max_profit;
            return res;
        }

        public static int CountElemThatLargerThanNeighbors(int[,] matr)
        {
            if (matr.GetLength(0) == 0 || matr.GetLength(1) == 0) throw new ArgumentException("Массив не заполнен!");

            int sum = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    int x = (i > 0 ? matr[i - 1, j] : 0)
                        + (i < matr.GetLength(0) - 1 ? matr[i + 1, j] : 0)
                        + (j > 0 ? matr[i, j - 1] : 0)
                        + (j < matr.GetLength(1) - 1 ? matr[i, j + 1] : 0);
                    if (matr[i, j] > x)
                        sum++;
                }
            }
            return sum;
        }

        public static char[,] DrawAnHourglass()
        {
            char[,] picture = new char[7, 7];

            for (int i = 0; i < picture.GetLength(0); i++)
            {

                for (int j = 0; j < picture.GetLength(1); j++)
                {
                    picture[i, j] = (i <= j && i <= picture.GetLength(0) - j - 1)
                         || (i >= j && i >= picture.GetLength(0) - j - 1) ? '1' : '0';
                }
            }
            return picture;
        }

        public static int[,] MultiplyMatrix(int[,] A, int[,] B)
        {
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }

    }
}
