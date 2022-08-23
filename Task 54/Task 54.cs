// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int min = int.MaxValue;

int replaceNumber = 0;

int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return result;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write(matrix[i, k] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] Matrix)
{
    int[,] resultMatrix1 = new int[rows, columns];
    for (int k = 0; k < columns; k++)
    {
        for (int i = 0; i < resultMatrix1.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix1.GetLength(1); j++)
            {
                if (j == 0 && resultMatrix1[i, j] < min) min = resultMatrix1[i, j];
                else if (resultMatrix1[i, j] < min) replaceNumber = min; min = resultMatrix1[i, (j - 1)]; resultMatrix1[i, j] = replaceNumber;

            }

        }
    }
    return resultMatrix1;
}

int[,] resultMatrix = GetArray(rows, columns, 0, 10);
int[,] resultMatrix1 = SortArray(resultMatrix);
PrintArray(resultMatrix);
System.Console.WriteLine();
PrintArray(resultMatrix1);