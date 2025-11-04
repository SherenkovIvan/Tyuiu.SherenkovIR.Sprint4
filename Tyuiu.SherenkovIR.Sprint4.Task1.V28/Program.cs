using Tyuiu.SherenkovIR.Sprint4.Task1.V28.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #4                                        *");
Console.WriteLine("* Тема:Одномерные массивы (ввод с клавиатуры)      *");
Console.WriteLine("* Задание #1                                       *");
Console.WriteLine("* Вариант #26                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Дан одномерный целочисленный массив на14 элементов*");
Console.WriteLine("*заполненный значениями с клавиатуры в диапазоне от*");
Console.WriteLine("*от 2 до 6 подсчитать произведение нечетных        *");
Console.WriteLine("* элементов массива.  С клавиатуры:                *");
Console.WriteLine("*  2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4        *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int len;
Console.Write("Введите количество элементво массива:");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArry = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите значение" + i + " элемента массива");
    numsArry[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0;i <=len -1; i++)
{
    Console.Write(numsArry[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

int res = ds.Calculate(numsArry);

Console.WriteLine(res);
Console.ReadKey();