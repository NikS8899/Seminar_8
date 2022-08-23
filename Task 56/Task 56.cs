// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Кол-во строк и столбцов в массиве: ");
int rowsAndColumns = Convert.ToInt32(Console.ReadLine());

int resultSum = int.MaxValue;
int sum = 0;
int rowIndex = 0;
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1);
            sum+= result[i, j];
        }
         if (sum < resultSum) resultSum = sum; 
        sum = 0;
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
            sum+= matrix[i, k];
        }
        if (sum == resultSum) rowIndex = i; 
        sum = 0;
        Console.WriteLine();
    }
}

int [,] resultMatrix = GetArray(rowsAndColumns, rowsAndColumns,0,10);
PrintArray(resultMatrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов под индексом {rowIndex}");