/* Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
 */
 Console.Write("Введите размерность матрицы М на М ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array1 = new int[m, m];
int[,] array2 = new int[m, m];
int[,] arrayProd = new int[m, m];

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

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
FillArray(array1);
FillArray(array2);
Console.WriteLine("Сформированный массив - 1 ");
ShowArray(array1);
Console.WriteLine("Сформированный массив - 2 ");
ShowArray(array2);


for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < arrayProd.GetLength(0); k++)
        {
            arrayProd[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine("Результат произведения квадратных массивов");
ShowArray(arrayProd);