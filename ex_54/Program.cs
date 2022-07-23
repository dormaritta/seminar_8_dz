/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
   по убыванию элементы каждой строки двумерного массива.

   Например, задан массив:                 В итоге получается вот такой массив:

   1 4 7 2                                 7 4 2 1              
   5 9 2 3                                 9 5 3 2
   8 4 2 4                                 8 4 4 2                              
*/

int rows = 3; int columns = 4; int min = 1; int max = 10;

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[rows, columns];
GetArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированные по убыванию строки массива: ");
SortArrayRows(array);
PrintArray(array);
