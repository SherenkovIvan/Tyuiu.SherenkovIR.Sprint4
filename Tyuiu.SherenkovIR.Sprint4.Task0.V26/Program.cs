using Tyuiu.SherenkovIR.Sprint4.Task0.V26.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #4                                        *");
Console.WriteLine("* Тема:Одномерные массивы                          *");
Console.WriteLine("* Задание #0                                       *");
Console.WriteLine("* Вариант #26                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Дан одномерный целочисленный массив на10 элементов*");
Console.WriteLine("*заполненный статическими значениями в диапазоне от*");
Console.WriteLine("*от 0 до 9 подсчитать сумму нечетных элементов     *");
Console.WriteLine("* элементов массива.                               *");
Console.WriteLine("* {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
Console.WriteLine("Исходный массив");
for (int i = 0; i < numsArray.Length; i++)
{
    Console.WriteLine(numsArray[i]);
}
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
Console.WriteLine("Результирующий массив:");
int sum = ds.GetSumOddArrEl(numsArray);
for (int i = 0; i < numsArray.Length; i++)
{
    if (numsArray[i] % 2 != 0)
    {
        Console.WriteLine(numsArray[i] + "\t");
    }
}

Console.WriteLine();
Console.ReadKey();