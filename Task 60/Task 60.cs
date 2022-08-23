// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во слоев: ");
int layers = Convert.ToInt32(Console.ReadLine());

int[,,] GetArray(int k, int m, int n, int minRandom, int maxRandom)
{
    int[,,] result = new int[k, m, n];
    for (int l = 0; l < result.GetLength(2); l++)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                    result[l, i, j] = new Random().Next(minRandom, maxRandom + 1);
              

            }

        }
    }
    return result;
}
void PrintArray(int[,,] matrix)
{
    for (int l = 0; l < matrix.GetLength(2); l++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {


                Console.Write(matrix[l, i, j] + $"({l},{i},{j})" + "\t");

            }

        }
        Console.WriteLine();
    }
   
}
int[,,] resultMatrix = GetArray(layers,rows, columns, 0, 10);
PrintArray(resultMatrix);