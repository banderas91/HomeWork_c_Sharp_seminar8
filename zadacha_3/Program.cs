/* Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
Вариант создания функции:
Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} ) */

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m * n > 50)
{
    Console.WriteLine("Количество элементов в массиве не должно быть больше 50!");
    return;
}

int[,] array = new int[m, n];
Console.WriteLine("Сформированный массив");


static void fillArray(int[,] array)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 100);
            for (int k = 0; k < j; k++)
                if (array[i, k] == array[i, j])
                    j--;

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
fillArray(array);



