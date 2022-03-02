using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Classes
{
    public class Loop //Lesson_4
    {
        public static List<int> FindDivisorsUpToThousand(int a)
        {
            if (a > 1000) throw new ArgumentException("Недопустимое значение аргумента! Аргумент > 1000");
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (a < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 0");

            List<int> res = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }

        public static int SumOfNumbersWithSquareLess(int a)
        {
            if (a < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 0");
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");

            int sum = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (Math.Pow(i, 2) < a)
                    sum++;
            }
            return sum;
        }

        public static int CalculateMaxDivisor(int a)
        {
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (a < 0) a *= -1;

            int maxDiv = 1;
            for (int j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    maxDiv = a / j;
                    return maxDiv;
                }
            }
            return maxDiv;
        }

        private static void SwapValues(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static int SumOfNumberDivisibleBySeven(ref int a, ref int b)
        {
            if (a > b) Loop.SwapValues(ref a, ref b);

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0) sum += i;
            }
            return sum;
        }

        public static int CalculateMaxCommonDivisor(int a, int b)
        {
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (b == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return b;
        }

        private static bool DetermineIfNumberIsPerfectCube(int n)
        {
            double cubeRoot = Math.Pow(n, 1.0 / 3.0);
            int c = (int)Math.Round(cubeRoot);
            return c * c * c == n;
        }

        public static int ToExtractCubeRoot(int n)
        {
            if (n < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 0");
            if (n == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (DetermineIfNumberIsPerfectCube(n) == false)
                throw new ArgumentException("Аргумент не является совершенным кубом!");

            int l = 0;
            int r = n;
            int m = -1;
            while (l != m)
            {
                m = (l + r) / 2;

                if ((int)Math.Pow(m, 3) == n) return m;

                if ((int)Math.Pow(m, 3) > n)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return m;
        }

        public static int CountAmountOddDig(int a)
        {
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (a < 0) a *= -1;

            int sum = 0;

            while (a > 0)
            {
                if ((a % 10) % 2 > 0)
                    sum++;
                a /= 10;
            }
            return sum;
        }

        public static int FindMirrorNumber(int num)
        {
            if (num == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (num < 0) num *= -1;

            int degree = num.ToString().Length;
            int p = 0;
            int newNum = 0;

            while (num > 0)
            {
                newNum = newNum + (num % 10)
                    * ((int)Math.Pow(10, degree - p - 1));
                p++;
                num /= 10;
            }
            return newNum;
        }


        private static int CompareEvOdSum(int a)
        {
            if (a == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент == 0");
            if (a < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 10");

            int sum_even = 0;
            int sum_odd = 0;
            bool pos = false;

            for (int i = a; a > 0; a /= 10)
            {
                int last_pos = a % 10;
                pos = !pos;

                if (pos == true) sum_odd += last_pos;
                else sum_even += last_pos;
            }
            if (sum_even > sum_odd) return 1;
            else return 0;
        }

        public static List<int> CompareOddAndEvenSumOfDig(int a)
        {
            List<int> res = new List<int>();

            for (int i = 10; i < a; i++)
            {
                int comp = Loop.CompareEvOdSum(i);
                if (comp == 1) res.Add(i);
            }
            return res;
        }

        public static bool FindCommonDigit(int a, int b)
        {
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            bool om = false;

            for (int i = a; i > 0; i /= 10)
            {
                int c = i % 10;
                for (int j = b; j > 0; j /= 10)
                {
                    int d = j % 10;
                    if (d == c)
                    {
                        om = true;
                        return om;
                    }
                }
            }
            return om;
        }
    }
}
