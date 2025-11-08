using Tyuiu.SherenkovIR.Sprint4.Task7.V30.Lib;
DataService ds = new DataService();

string str = "684259137159648";
int rows = 5;
int cols = 3;

Console.Title = "Спринт #4 | Выполнил: Шеренков И. Р. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСб-25-1                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте ее  *");
Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;
Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(rows, cols, str);
Console.WriteLine("Произведение чётных элементов массива: " + res);

Console.ReadKey();