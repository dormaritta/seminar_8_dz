/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

PS: делала не по примеру в задаче, а по теории:
"Результатом умножения матрицы Am×n на матрицу Bn×k будет матрица Cm×k такая, 
что элемент матрицы C, стоящий в i-той строке и j-том столбце (cij), 
равен сумме произведений элементов i-той строки матрицы A на соответствующие элементы j-того столбца матрицы B.
Две матрицы можно перемножить если количество столбцов первой матрицы равно количеству строк второй матрицы."  */

int rows = 2; int columns = 2; int secondRows = 2; int min = 0; int max = 10;

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] firstMartrix = new int[rows, columns];
GetArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[columns, secondRows];
GetArray(secondMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMartrix);

void productMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] productMtrx)
{
    for (int i = 0; i < productMtrx.GetLength(0); i++)
    {
        for (int j = 0; j < productMtrx.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            productMtrx[i, j] = sum;
        }
    }
}

int[,] productMtrx = new int[rows, secondRows];
productMatrix(firstMartrix, secondMartrix, productMtrx);
Console.WriteLine("Произведение матриц:");
PrintArray(productMtrx);