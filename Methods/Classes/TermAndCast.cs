using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Classes
{
    public class TermAndCast //Lesson_2
    {
        public static int SumOfDigit(int a)
        {
            if (a < 0) a = a * (-1);
            if (a / 100 < 1 || a / 100 > 9)
                throw new ArgumentException("Аргумент не является трёхзначным числом!");
            return (a % 10 + (a / 10 % 10) + a / 100);
        }

        public static bool ReturneHit(double x, double y, double r)
        {
            if (r <= 0) throw new ArgumentException("Неверное значение радиуса!");
            return (Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(r, 2));
        }

        public static bool CompareDigOfNum(int z)
        {
            if (z < 0) z = z * (-1);
            if (z / 100 < 1 || z / 100 > 9)
                throw new ArgumentException("Аргумент не является трёхзначным числом!");

            int z1 = z % 10;
            int z2 = (z / 10) % 10;
            int z3 = z / 100;

            return (z2 > z3 && z2 <= z1);
        }

        public static int SwapDigOfNum(int num)
        {
            if (Math.Abs(num) / 100 < 1 || Math.Abs(num) / 100 > 9)
                throw new ArgumentException("Аргумент не является трёхзначным числом!");

            int n1 = num % 10;
            int n2 = (num / 10) % 10;
            int n3 = num / 100;

            int temp = n3;
            n3 = n1;
            n1 = temp;

            int newNum = n1 + (n2 * 10) + (n3 * 100);
            return newNum;
        }

        public static bool CheckZeroInFractionPart(double w)
        {
            return w == Convert.ToInt32(w);
        }
    }
}
