/* Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
 */
 Console.Write("Введите размерность матрицы М на М ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array1 = new int[m, m];
int[,] array2 = new int[m, m];
int[,] arrayProd = new int[m, m];
Console.WriteLine("Сформированный массив");


Random ran = new Random();
void FillArray(int[,] numArray)
{
    for (int i = 0; i < numArray.GetLength(0); i++)
    {
        for (int j = 0; j < numArray.GetLength(1); j++)
        {
            numArray[i, j] = ran.Next(1, 15);
     
        }
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
FillArray(array);
ShowArray(array);



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
