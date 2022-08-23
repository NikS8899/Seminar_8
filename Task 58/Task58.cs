// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

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
            Console.Write(matrix[i, k] + "\t" );
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int[,] matrix1 , int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            Console.Write($"{matrix1[i, k] * matrix2[i, k]}" + "\t"  );
        }
        Console.WriteLine();
    }
}

int [,] resultMatrix1 = GetArray(rows,columns,0,10);
int [,] resultMatrix2 = GetArray(rows,columns,0,10);
PrintArray(resultMatrix1);
Console.WriteLine();
PrintArray(resultMatrix2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
Console.WriteLine();
MultiplicationArray(resultMatrix1,resultMatrix2);