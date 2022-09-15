/* Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел  
(размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив. 
Вариант создания функции: 
Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} ) 
Пример: 
Массив размером 3 x 3 
10 11 55 
33 41 23 
17 28 34 
*/ 
 
bool Contains(int[,] arr, int value) 
{ 
    bool result = true; 
    for(int i = 0; i < arr.GetLength(0); i++) 
    { 
        for(int j = 0; j < arr.GetLength(1); j++) 
        { 
             
            if(arr[i,j] == value) 
            { 
                result = false; 
            } 
        } 
    } 
    return result; 
} 
 
void Matrixt2D(int n, int m) 
{ 
    int[,] table = new int[n,m]; 
    int value = 0; 
    Console.WriteLine("Таблица случайных чисел: "); 
    for(int i = 0; i < n; i++) 
    { 
        for(int j = 0; j < m; j++) 
        { 
            value = new Random().Next(10,100); 
            if (i != 0 || j != 0) 
            {     
                if(Contains(table, value) == true) 
                { 
                    table[i,j] = value; 
                    Console.Write($"{table[i,j]} "); 
                } 
                else 
                { 
                    j--; 
                }   
            } 
            else 
            { 
                table[i,j] = new Random().Next(10,100); 
                Console.Write($"{table[i,j]} "); 
            } 
        } 
        Console.WriteLine(); 
    } 
} 
 
Console.Write("Укажите кол-во строк N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Укажите кол-во строк M: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 if (m * n > 50)
{
    Console.WriteLine("Количество элементов в массиве не должно быть больше 50!");
    return;
}
Matrixt2D(n,m);