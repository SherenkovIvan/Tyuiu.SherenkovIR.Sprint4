using Tyuiu.SherenkovIR.Sprint4.Task4.V12.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #4                                        *");
Console.WriteLine("*Тема:Двумерные массивы(Ввод с клавиатуры)         *");
Console.WriteLine("* Задание #4                                       *");
Console.WriteLine("* Вариант #12                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Дан двумерный целочисленный массив 5 на5 элементов*");
Console.WriteLine("*заполненный значениями с клавиатуры в диапазоне от*");
Console.WriteLine("*от 2 до 8 заменить четные элементы массива на 1.  *");
Console.WriteLine("*                                                  *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество Столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];
Console.WriteLine("****************************************************");

for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        Console.Write($"Введите{i},{j} элемент массива:");
        mtrx[i,j] = Convert.ToInt32(Console.ReadLine() );
    }
}

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
int[,] res = ds.Calculate(mtrx);

Console.WriteLine("Преобразованный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.ReadKey();
