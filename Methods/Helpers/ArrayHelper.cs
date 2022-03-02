using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Helpers
{
    public class ArrayHelper
    {
        public static int[] GenerateIntArray(int size, int min = int.MinValue, int max = int.MaxValue)
        {
            int[] mas = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = rnd.Next(min, max);
            }
            return mas;
        }

        public static double[] GenerateDoubleArray(int size, double min, double max)
        {
            double[] mas = new double[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
            }
            return mas;
        }

        public static int[,] GenerateIntMatrix(int rows, int cols, int min = int.MinValue, int max = int.MaxValue)
        {
            int[,] matr = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matr[i, j] = rnd.Next(min, max);
                }
            }
            return matr;
        }

        public static double[,] GenerateDoubleMatrix(int rows, int cols, double min, double max)
        {
            double[,] matr = new double[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matr[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
                }
            }
            return matr;
        }

        public static void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }

        public static void PrintArray(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }

        public static void PrintArray(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{Math.Round(mas[i], 2)} ");
            Console.WriteLine();
        }

        public static void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{Math.Round(matr[i, j], 2)}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintArray(char[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
