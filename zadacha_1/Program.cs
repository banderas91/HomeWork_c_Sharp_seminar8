/* Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Console.WriteLine("Сформированный массив");


Random ran = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = ran.Next(1, 15);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}


FillArray(array);

int minRowSum = int.MaxValue;
int indexMinRow = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        rowSum += array[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}

Console.WriteLine("Наименьшая сумма элементов ====> " + minRowSum);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов ====> " + (indexMinRow + 1));
Console.WriteLine();

 

