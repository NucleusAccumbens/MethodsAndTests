using Methods.Classes;
using Methods.Helpers;
using System;
using System.Collections.Generic;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculateAndIO 

            int a = 6;
            double b = 6.8;
            Console.WriteLine(CalculateAndIO.GlueString(a, b));
            IOHelper.PaintLine();

            double num_first = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            double num_second = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            try
            {
                Console.WriteLine($"(5 * {num_first} + {num_second}^4) / ({num_second} - {num_first}) " +
                              $"= {CalculateAndIO.Calculate(num_first, num_second)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            string string_one = IOHelper.InputText("Введи первую строку: string one = ");
            string string_two = IOHelper.InputText("Введи вторую строку: string two = ");
            string[] swap_value = CalculateAndIO.SwapStringValues(string_one, string_two);
            try
            {
                Console.WriteLine("Поменять введённые значения перемнных местами. Результат: ");
                Console.Write($"string one = {swap_value[0]}, string two = {swap_value[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            Console.WriteLine();
            IOHelper.PaintLine();

            double num_a = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            double num_b = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            double num_c = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи третье число: ");
            try
            {
                Console.WriteLine($"В уравнении [{num_a} * X + {num_b} = {num_c}] " +
                              $"X = {CalculateAndIO.CalculateEquation(num_a, num_b, num_c)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            //TermAndCast

            const int number = 543;
            try
            {
                Console.WriteLine($"Сумма цифр числа {number} = {TermAndCast.SumOfDigit(number)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            double x = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи координату выстрела по оси x: ");
            double y = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи координату выстрела по оси y: ");
            double r = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи радиус мишени: ");
            bool res = TermAndCast.ReturneHit(x, y, r);
            try
            {
                if (res == false) Console.WriteLine("Попал");
                else Console.WriteLine("Не попал");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}");
            }
            IOHelper.PaintLine();



            int collation_number = IOHelper.SaveInputNum(100, 999, "Введи трёхзначное число: ");
            bool compare = TermAndCast.CompareDigOfNum(collation_number);
            try
            {
                if (compare == false) Console.WriteLine($"Cредняя цифра числа {collation_number} меньше или равна первой (левой)" +
                $" и одновременно больше последней? Ответ: НЕТ.");
                else Console.WriteLine($"Cредняя цифра числа {collation_number} меньше или равна первой (левой)" +
                $" и одновременно больше последней? Ответ: ДА.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}");
            }
            IOHelper.PaintLine();



            int change_number = IOHelper.SaveInputNum(100, 999, "Введи трёхзначное число: ");
            try
            {
                Console.WriteLine($"Зеркальное отображение числа {change_number}: {TermAndCast.SwapDigOfNum(change_number)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}");
            }
            IOHelper.PaintLine();


            const double w = 48.1;
            bool notEqual = TermAndCast.CheckZeroInFractionPart(w);
            if (notEqual == true) Console.WriteLine($"У числа {w} дробная часть равна нулю? Ответ: ДА.");
            else Console.WriteLine($"У числа {w} дробная часть равна нулю? Ответ: НЕТ.");
            IOHelper.PaintLine();

            //Branching

            double num_one = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            double num_two = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            Console.WriteLine($"Ответ: {Branching.AddMultiplyOrSubtract(num_one, num_two)}");
            IOHelper.PaintLine();

            double num_x = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи координату по оси x: ");
            double num_y = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи координату выстрела по оси y: ");
            try
            {
                Console.WriteLine($"Точка находится в {Branching.DefineQuarter(num_x, num_y)}-ой четверти координатной плосости.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();

            double number_a = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            double number_b = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            double number_c = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи третье число: ");
            double[] answ = Branching.SortAscending(number_a, number_b, number_c);
            Console.WriteLine($"Данные числа в порядке возрастания: {answ[0]} {answ[1]} {answ[2]}");
            IOHelper.PaintLine();

            double number_d = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            double number_e = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            double number_f = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи третье число: ");
            double[] roots = Branching.SolveQuadraticEquation(number_d, number_e, number_f);
            if (roots.Length == 0) Console.WriteLine("Корней нет!");
            else if (roots.Length == 1) Console.WriteLine($"Один корень: {roots[0]}");
            else Console.WriteLine($"Два корня: {roots[0]} и {roots[1]}");
            IOHelper.PaintLine();

            int twoDig_number = IOHelper.SaveInputNum(10, 99, "Введи двухзначное число: ");
            try
            {
                Console.WriteLine($"Название числа {twoDig_number}: {Branching.NameTheNumber(twoDig_number)}");
            }
            catch (Exception exс)
            {
                Console.WriteLine($"Возникла ошибка: {exс.Message}!");
            }
            IOHelper.PaintLine();

            double lengh_one = IOHelper.SaveInputNum(1, int.MaxValue, "Введи первое число: ");
            double lengh_two = IOHelper.SaveInputNum(1, int.MaxValue, "Введи второе число: ");
            double lengh_three = IOHelper.SaveInputNum(1, int.MaxValue, "Введи третье число: ");
            bool exist = Branching.DetermineTriangleExists(lengh_one, lengh_two, lengh_three);
            try
            {
                if (exist == true) Console.WriteLine($"Треугольник со сторонами {lengh_one}, {lengh_two} и {lengh_three} существует.");
                else Console.WriteLine($"Треугольника со сторонами {lengh_one}, {lengh_two} и {lengh_three} не существует.");
            }
            catch (Exception exс)
            {
                Console.WriteLine($"Возникла ошибка: {exс.Message}!");
            }
            IOHelper.PaintLine();

            //Loop

            int dil = IOHelper.SaveInputNum(1, 999, "Введи число: ");
            List<int> resul = Loop.FindDivisorsUpToThousand(dil);
            try
            {
                Console.Write($"Числа от 1 до 1000, которые делятся на {dil}: ");
                for (int i = 0; i < resul.Count; i++) { Console.Write($"{resul[i]} "); }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_one = IOHelper.SaveInputNum(1, 999, "Введи число: ");
            try
            {
                IOHelper.Output(Loop.SumOfNumbersWithSquareLess(numb_one),
                    $"Количество положительных целых чисел, квадрат которых меньше {numb_one}: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_two = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи число: ");
            try
            {
                IOHelper.Output(Loop.CalculateMaxDivisor(numb_two), $"Наибольший делитель числа {numb_two}: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_three = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            int numb_four = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            IOHelper.Output(Loop.SumOfNumberDivisibleBySeven(ref numb_three, ref numb_four),
               $"Сумма всех чисел из диапазона от {numb_three} до {numb_four},  которые делятся на 7: ");
            IOHelper.PaintLine();


            int numb_five = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи первое число: ");
            int numb_six = IOHelper.SaveInputNum(int.MinValue, int.MaxValue, "Введи второе число: ");
            try
            {
                IOHelper.Output(Loop.CalculateMaxCommonDivisor(numb_five, numb_six), $"Наибольший общий делитель {numb_five} и {numb_six}: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int num_cube = IOHelper.SaveInputNum(1, int.MaxValue, "Введи число, которое является кубом числа N: ");
            try
            {
                IOHelper.Output(Loop.ToExtractCubeRoot(num_cube), "N = ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_seven = IOHelper.SaveInputNum(11111, 99999999, "Введи число: ");
            try
            {
                IOHelper.Output(Loop.CountAmountOddDig(numb_seven), $"Количество нечетных цифр числа {numb_seven}: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_mirror = IOHelper.SaveInputNum(11111, 99999999, "Введи число: ");
            try
            {
                IOHelper.Output(Loop.FindMirrorNumber(numb_mirror), $"Число, которое является зеркальным отображением числа {numb_mirror}: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_eight = IOHelper.SaveInputNum(10, 10000, "Введи число: ");
            List<int> answer = Loop.CompareOddAndEvenSumOfDig(numb_eight);
            try
            {
                Console.Write($"Числа в диапазоне от 1 до {numb_eight}, " +
               $"сумма четных цифр которых больше суммы нечетных: ");
                for (int i = 0; i < answer.Count; i++) { Console.Write($"{answer[i]} "); }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int numb_nine = IOHelper.SaveInputNum(111, 99999, "Введи первое число: ");
            int numb_ten = IOHelper.SaveInputNum(111, 99999, "Введи второе число: ");
            bool no = Loop.FindCommonDigit(numb_nine, numb_ten);
            Console.Write($"Есть ли в написании {numb_nine} и {numb_ten} одинаковые цифры?\n" +
               $"Ответ: ");
            if (no == false) Console.WriteLine("НЕТ");
            else Console.WriteLine("ДА");
            IOHelper.PaintLine();

            //HomeWork_5

            int[] mas = ArrayHelper.GenerateIntArray(11, 1, 50);
            ArrayHelper.PrintArray(mas);

            Console.WriteLine();
            int[] count = SingleDimensionalArray.CountEvenOddElements(mas);
            try
            {
                Console.WriteLine($"Количество четных элементов массива: {count[0]}\nКоличество нечётных элементов массива: {count[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            try
            {
                Console.WriteLine($"Каждый третий элемент массива заменён на сумму двух предыдущих.\nНовый массив: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.ChangeThirdElemWithSumTwoPrevios(mas));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int[] mas_one = ArrayHelper.GenerateIntArray(7, 1, 100);
            Console.WriteLine($"Слить два целочисленных массива в один: ");
            ArrayHelper.PrintArray(mas);
            ArrayHelper.PrintArray(mas_one);
            Console.WriteLine();
            try
            {
                Console.WriteLine("Результат слияния: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.ConcatenateAttays(mas, mas_one));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int[] newMas = SingleDimensionalArray.ConcatenateAttays(mas, mas_one);
            Console.WriteLine($"Поменять местами половины массива: ");
            ArrayHelper.PrintArray(newMas);
            Console.WriteLine();
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.SwapArrayHalves(newMas));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Сместить данный массив на один элемент вправо: ");
            ArrayHelper.PrintArray(newMas);
            Console.WriteLine();
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.ShiftArrayElemByOnePositions(newMas));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Сместить данный массив на шесть элементов вправо: ");
            ArrayHelper.PrintArray(newMas);
            Console.WriteLine();
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.ShiftArrayElemByNPositions(newMas, 6));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Преобразовать массив, заменяя элементы на чётных позициях на элементы нечётных позиций: ");
            ArrayHelper.PrintArray(newMas);
            Console.WriteLine();
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(SingleDimensionalArray.ChangeEvenElemToOdd(newMas));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            int[] mas_two = ArrayHelper.GenerateIntArray(15, -100, 100);
            ArrayHelper.PrintArray(mas_two);
            Console.WriteLine();
            Console.WriteLine($"В данном массиве найти:\n1) максимальный по модулю элемент массива\n" +
                              $"2) сумму элементов расположеных после первого элемента, равного нулю");
            Console.WriteLine();
            int[] result = SingleDimensionalArray.FindMinModulElemAndSumAfterZero(mas_two);
            try
            {
                Console.WriteLine($"Максимальный по модулю элемент массива: {result[0]}\n" +
                                  $"Сумма элементов расположеных после первого элемента, равного нулю: {result[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Отсортировать данный массив алгоритмом вставок: ");
            ArrayHelper.PrintArray(newMas);
            Console.WriteLine();
            int[] sortInsertArray = SingleDimensionalArray.SortArrayInsert(newMas);
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(sortInsertArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Отсортировать данный массив алгоритмом выборки: ");
            ArrayHelper.PrintArray(mas_two);
            Console.WriteLine();
            int[] sortSelectArray = SingleDimensionalArray.SortArraySelect(mas_two);
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(sortSelectArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();

            //HomeWork_6

            Console.WriteLine($"Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива: ");
            int[,] matrix = ArrayHelper.GenerateIntMatrix(4, 8, 1, 99);
            ArrayHelper.PrintArray(matrix);
            Console.WriteLine();
            int[,] reverseMatrix = TwoDimensionalArray.ReverseSignOfTheNumberatEdgesOfMatrix(matrix);
            try
            {
                Console.WriteLine("Результат: ");
                ArrayHelper.PrintArray(reverseMatrix);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            Console.WriteLine($"Заполнить матрицу 9x9 таблицей умножения: ");
            int[,] multiplicationTable = TwoDimensionalArray.WriteInMultiplicationTable();
            ArrayHelper.PrintArray(multiplicationTable);
            IOHelper.PaintLine();



            Console.WriteLine($"Заполнить квадратную матрицу произвольного размера нулями и единицами так,\n" +
                              $"как расположены клетки на шахматной доске, где 0 - черное, 1 - белое: ");
            int[,] chessboard = TwoDimensionalArray.FillInLikeChessboard(7);
            try
            {
                ArrayHelper.PrintArray(chessboard);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            Console.WriteLine($"В данном массиве проверить, чтобы не было занято два соседних места в одном ряду: ");
            int[,] auditorium = new int[4, 6]
              { { 0, 1, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 1, 0 } };
            ArrayHelper.PrintArray(auditorium);
            bool violation = TwoDimensionalArray.CheckSeatingRule(auditorium);
            try
            {
                Console.WriteLine("Результат: ");
                if (violation == true) Console.WriteLine("Правило нарушено!");
                else Console.WriteLine("Правило соблюдено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            double[,] profit = ArrayHelper.GenerateDoubleMatrix(10, 6, 1111111111.00, 999999999.00);
            ArrayHelper.PrintArray(profit);
            double[] sumProfit = TwoDimensionalArray.SumShopsProfit(profit);
            double[] averageMonthlyProfit = TwoDimensionalArray.AverageMonthlyProfit(profit);
            double[] minMaxProfit = TwoDimensionalArray.MinMaxProfit(profit);
            try
            {
                for (int i = 0; i < sumProfit.Length; i++)
                {
                    Console.WriteLine($"Суммарный доход по {i + 1}-му магазину = {sumProfit[i]}");
                }
                Console.WriteLine();
                for (int i = 0; i < averageMonthlyProfit.Length; i++)
                {
                    Console.WriteLine($"Средний доход по {i + 1}-му месяцу = {averageMonthlyProfit[i]}");
                }
                Console.WriteLine();
                Console.WriteLine($"Минимальный доход = {minMaxProfit[0]}\n" +
                                  $"Максимальный доход = {minMaxProfit[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            Console.WriteLine($"В данном массиве найти количество элементов массива, которые больше всех своих соседей одновременно: ");
            ArrayHelper.PrintArray(matrix);
            int sum = TwoDimensionalArray.CountElemThatLargerThanNeighbors(matrix);
            try
            {
                Console.WriteLine($"Результат: {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();



            Console.WriteLine($"Вывести массив символов, с изображением песочных часов: ");
            char[,] hourglass = TwoDimensionalArray.DrawAnHourglass();
            try
            {
                Console.WriteLine($"Результат: ");
                ArrayHelper.PrintArray(hourglass);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.WriteLine($"Реализовать перемножение данных матриц: ");
            int[,] matrix_one = ArrayHelper.GenerateIntMatrix(2, 3, 1, 99);
            ArrayHelper.PrintArray(matrix_one);
            int[,] matrix_two = ArrayHelper.GenerateIntMatrix(3, 2, 1, 99);
            ArrayHelper.PrintArray(matrix_two);
            int[,] mult = TwoDimensionalArray.MultiplyMatrix(matrix_one, matrix_two);
            try
            {
                Console.WriteLine($"Результат: ");
                ArrayHelper.PrintArray(mult);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}!");
            }
            IOHelper.PaintLine();


            Console.ReadKey();
        }
    }
}

