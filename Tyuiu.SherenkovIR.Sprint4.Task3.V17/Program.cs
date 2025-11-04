using Tyuiu.SherenkovIR.Sprint4.Task3.V17.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #4                                        *");
Console.WriteLine("*Тема:Одномерные массивы(генератор случайных чисел)*");
Console.WriteLine("* Задание #2                                       *");
Console.WriteLine("* Вариант #10                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Дан одномерный целочисленный массив на13 элементов*");
Console.WriteLine("*заполненный значениями с клавиатуры в диапазоне от*");
Console.WriteLine("*от 1 до 6 подсчитать произведение нечетных        *");
Console.WriteLine("* элементов массива.                               *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
Console.WriteLine("Массив:");
int[,] mas4 = new int[5, 5] {{ 6, 4, 2, 2, 1 },
            { 3, 6, 5, 4, 1},
            { 5, 2, 3, 1, 6},
            { 8, 8, 4, 5, 3},
            { 7, 4, 5, 1, 6}};
for (int i = 0; i < mas4.GetLength(0); i++)
{
    for (int j = 0; j < mas4.GetLength(1); j++)
    {
        Console.Write(mas4[i, j] + "\t");
    }
}

Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
int res = ds.Calculate(mas4);
Console.WriteLine("Cумму элементов в четвертом столбце массива = " + res);
Console.ReadKey();
