using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Branching //Lesson_3
    {
        public static double AddMultiplyOrSubtract(double a, double b)
        {
            double ab_sum = a + b;
            double ab_mult = a * b;
            double ab_sub = a - b;

            if (a > b) return ab_sum;
            if (a == b) return ab_mult;
            else return ab_sub;
        }

        public static int DefineQuarter(double x, double y)
        {

            if (x == 0 && y != 0) throw new ArgumentException("Точка лежит на оси Y");
            if (x != 0 && y == 0) throw new ArgumentException("Точка лежит на оси X");
            if (x == 0 && y == 0) throw new ArgumentException("Точка находится в центре координатной плоскости");
            if (x > 0 && y > 0) return 1;
            if (x > 0 && y < 0) return 2;
            if (x < 0 && y < 0) return 3;
            else return 4;

        }

        public static double[] SortAscending(double a, double b, double c)
        {
            double min = a < b ? (a < c ? a : c) : (b < c ? b : c);
            double max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            double middle = a + b + c - min - max;

            return new double[] { min, middle, max };
        }

        private static double CalculateDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double dis = Branching.CalculateDiscriminant(a, b, c);

            if (dis < 0) return new double[] { };
            if (dis == 0)
            {
                double roots = (-b - Math.Sqrt(dis)) / 2 * a;
                return new double[] { roots };
            }
            else
            {
                double roots_1 = (-b - Math.Sqrt(dis)) / 2 * a;
                double roots_2 = (-b + Math.Sqrt(dis)) / 2 * a;
                return new double[] { roots_1, roots_2 };
            }
        }

        public static string NameTheNumber(int num)
        {
            string answer = "";

            if (num < 10 || num > 99) throw new ArgumentException("Число не соответствует заданному условию!");
            if (num < 20 && num > 9)
            {
                switch (num)
                {
                    case 10: return "Десять";
                    case 11: return "Одинадцать";
                    case 12: return "Двенадцать";
                    case 13: return "Тринадцать";
                    case 14: return "Четырнадцать";
                    case 15: return "Пятнадцать";
                    case 16: return "Шестнадцать";
                    case 17: return "Семнадцать";
                    case 18: return "Восемнадцать";
                    case 19: return "Девятнадцать";
                }
                return answer;
            }
            if (num / 10 > 1)
            {
                switch (num / 10)
                {
                    case 2: answer += "Двадцать"; break;
                    case 3: answer += "Тридцать"; break;
                    case 4: answer += "Сорок"; break;
                    case 5: answer += "Пятьдесят"; break;
                    case 6: answer += "Шестьдесят"; break;
                    case 7: answer += "Семьдесят"; break;
                    case 8: answer += "Восемьдесят"; break;
                    case 9: answer += "Девяносто"; break;

                }
                switch (num % 10)
                {
                    case 1: answer += " один"; break;
                    case 2: answer += " два"; break;
                    case 3: answer += " три"; break;
                    case 4: answer += " четыре"; break;
                    case 5: answer += " пять"; break;
                    case 6: answer += " шесть"; break;
                    case 7: answer += " семь"; break;
                    case 8: answer += " восемь"; break;
                    case 9: answer += " девять"; break;

                }
                return answer;
            }
            return answer;
        }

        public static bool DetermineTriangleExists(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина стороны треугольника не может быть отрицательной или 0!");
            return (a < b + c && b < a + c && c < b + a);
        }

    }
}
