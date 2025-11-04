using Tyuiu.SherenkovIR.Sprint4.Task2.V10.Lib;
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
Random rnd = new Random();
Console.WriteLine("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArry = new int[len];

for(int i = 0; i < len -1; i++)
{
    numsArry[i] = rnd.Next(1,6);
}
Console.WriteLine("Массив");
for(int i = 0;i < len -1; i++)
{
    Console.Write(numsArry[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

int res = ds.Calculate(numsArry);

Console.WriteLine("Сумма элементов больше 10 = " + res);
Console.ReadKey();