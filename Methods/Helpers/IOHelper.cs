using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Helpers
{
    public class IOHelper
    {
        public static void PaintLine(int len = 50)
        {
            {
                for (int i = 1; i <= len; i++)
                    Console.Write('_');
            }
            Console.WriteLine("\n");
        }


        public static void SayHello(string name = "Незнакомец", string hello = "Привет, ")
        {
            Console.WriteLine($"{hello}{name}!");
        }

        public static void SayHello(int name = 0, string hello = "Привет, ")
        {
            Console.WriteLine($"{hello}{name}!");
        }

        public static void SayHello(double name = 0.0, string hello = "Привет, ")
        {
            Console.WriteLine($"{hello}{name}!");
        }



        public static void SayGoodbye(string name = "Незнакомец", string bye = "Пока, ")
        {
            Console.WriteLine($"{bye}{name}...");
        }

        public static void SayGoodbye(int name, string bye = "Пока, ")
        {
            Console.WriteLine($"{bye}{name}...");
        }

        public static void SayGoodbye(double name, string bye = "Пока, ")
        {
            Console.WriteLine($"{bye}{name}...");
        }



        public static double SaveInputNum(double min, double max, string message)
        {
            double num;
            do
            {
                Console.Write($"{message} [от {min} до {max}]: ");
                num = Convert.ToDouble(Console.ReadLine());
            }
            while (num < min || num > max);
            return num;
        }

        public static int SaveInputNum(int min, int max, string message)
        {
            int num;
            do
            {
                Console.Write($"{message} [от {min} до {max}]: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num < min || num > max);
            return num;
        }

        public static (double, double) InputPoint(double x, double y)
        {
            (double, double) point = (x, y);
            return point;
        }

        public static string InputText(string message = "Введите строку: ")
        {
            Console.Write(message);
            string text = Console.ReadLine();
            return text;
        }



        public static void Output(int a, string message)
        {
            Console.WriteLine($"{message}{a}");
        }

        public static void Output(int a, int b, string message)
        {
            Console.WriteLine($"{message}{a} и {b}");
        }

        public static void Output(int a, int b, int c, string message)
        {
            Console.WriteLine($"{message}{a}, {b} и {c}");
        }


        public static void Output(double a, string message)
        {
            Console.WriteLine($"{message}{a}");
        }

        public static void Output(double a, double b, string message)
        {
            Console.WriteLine($"{message}{a} и {b}");
        }

        public static void Output(double a, double b, double c, string message)
        {
            Console.WriteLine($"{message}{a}, {b} и {c}");
        }

    }
}
