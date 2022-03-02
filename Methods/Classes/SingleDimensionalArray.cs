using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Classes
{
    public class SingleDimensionalArray //Lesson_5
    {
        public static int[] CountEvenOddElements(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            int[] count = new int[2];
            int even_sum = 0;
            int odd_sum = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0) even_sum++;
                else odd_sum++;
            }
            count[0] = even_sum;
            count[1] = odd_sum;
            return count;
        }

        public static int[] ChangeThirdElemWithSumTwoPrevios(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            for (int i = 2; i < mas.Length; i += 3)
            {
                mas[i] = mas[i - 1] + mas[i - 2];
            }
            return mas;
        }

        public static int[] ConcatenateAttays(int[] mas_one, int[] mas_two)
        {
            if (mas_one.Length == 0) throw new ArgumentException("Массив не заполнен!");
            if (mas_two.Length == 0) throw new ArgumentException("Массив не заполнен!");

            int[] newMas = new int[mas_one.Length + mas_two.Length];

            for (int i = 0; i < mas_one.Length; i++)
            {
                newMas[i] = mas_one[i];
            }
            for (int j = 0; j < mas_two.Length; j++)
            {
                newMas[j + mas_one.Length] = mas_two[j];
            }
            return newMas;
        }

        public static int[] SwapArrayHalves(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            int[] copy_mas = new int[mas.Length];

            int mid = mas.Length / 2;

            if (mas.Length % 2 == 0)
            {
                for (int i = 0; i < mid; i++)
                {
                    int tmp = mas[i];
                    mas[i] = mas[mid + i];
                    mas[i + mid] = tmp;
                }
                return mas;
            }
            else
            {
                for (int i = 0; i < mid; i++)
                {
                    copy_mas[i] = mas[mid + i + 1];
                }
                for (int i = mid; i < mas.Length; i++)
                {
                    copy_mas[i] = mas[i - mid];
                }
                return copy_mas;
            }
        }


        public static int[] ShiftArrayElemByOnePositions(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            for (int i = 0; i < 1; i++)
            {
                int last = mas[mas.Length - 1];
                {
                    for (int j = mas.Length - 1; j >= 1; j--)
                        mas[j] = mas[j - 1];
                }
                mas[0] = last;
            }
            return mas;
        }

        public static int[] ShiftArrayElemByNPositions(int[] mas, int N)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");
            if (N > mas.Length) throw new ArgumentOutOfRangeException("Значение аргумента больше, чем длина массива!");
            if (N == 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент = 0!");
            if (N < 0) throw new ArgumentException("Недопустимое значение аргумента! Аргумент < 0!");

            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < 1; i++)
                {
                    int last = mas[mas.Length - 1];
                    {
                        for (int j = mas.Length - 1; j >= 1; j--)
                            mas[j] = mas[j - 1];
                    }
                    mas[0] = last;
                }
            }
            return mas;
        }

        public static int[] ChangeEvenElemToOdd(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            for (int i = 1; i < mas.Length; i += 2)
            {
                int tmp = mas[i];
                mas[i] = mas[i - 1];
                mas[i - 1] = tmp;
            }
            return mas;
        }

        public static int[] FindMinModulElemAndSumAfterZero(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            int sum = 0;
            bool have_zero = false;
            int max_pos = 0;
            int[] res = new int[2];

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0) have_zero = true;
                if (have_zero == true) sum += mas[i];
                if (Math.Abs(mas[i]) > Math.Abs(mas[max_pos])) max_pos = i;
            }
            res[0] = mas[max_pos];
            res[1] = sum;
            return res;
        }

        public static int[] SortArrayInsert(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            for (int i = 0; i < mas.Length; i++)
            {
                int key = mas[i];
                int j = i;
                while ((j > 0) && (mas[j - 1] > key))
                {
                    int tmp = mas[j - 1];
                    mas[j - 1] = mas[j];
                    mas[j] = tmp;
                    j--;
                }
                mas[j] = key;
            }
            return mas;
        }

        public static int[] SortArraySelect(int[] mas)
        {
            if (mas.Length == 0) throw new ArgumentException("Массив не заполнен!");

            for (int j = 0; j < mas.Length - 1; j++)
            {
                int min = j;
                for (int i = j + 1; i < mas.Length; i++)
                {
                    if (mas[i] < mas[min])
                        min = i;
                }
                int temp = mas[min];
                mas[min] = mas[j];
                mas[j] = temp;
            }
            return mas;
        }

    }
}
