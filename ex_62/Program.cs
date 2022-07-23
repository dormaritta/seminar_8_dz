/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

 1   2   3  4
12  13  14  5
11  16  15  6
10   9   8  7 
*/

int n = 4;
int[,] spiralMatrix = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i, j] = num;

    num++;

    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(spiralMatrix);