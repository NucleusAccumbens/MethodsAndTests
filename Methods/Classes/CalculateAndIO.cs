using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Classes
{
    public class CalculateAndIO //Lesson_1
    {
        static double Sum(int a, double b)
        {
            return a + b;
        }

        public static string GlueString(int a, double b)
        {
            string res = $"привет, {a}!\n" +
                         $"{a} + {b} = {CalculateAndIO.Sum(a, b)}\n" +
                         $"пока, {b}...";
            return res;
        }

        public static double Calculate(double a, double b)
        {
            if (a == 0 && b == 0) throw new DivideByZeroException("Деление на 0!");
            if (b - a == 0) throw new DivideByZeroException("Деление на 0!");
            double res = (5 * a + Math.Pow(b, 4)) / (b - a);
            return res;
        }

        public static string[] SwapStringValues(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) throw new ArgumentException("Вы ввели пустую строку!");

            string tmp = a;
            a = b;
            b = tmp;
            return new string[] { a, b };
        }

        public static double CalculateEquation(double a, double b, double c)
        {
            if (a == 0) throw new DivideByZeroException("Деление на 0!");
            return (c - b) / a;
        }

    }
}
