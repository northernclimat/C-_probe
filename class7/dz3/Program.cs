// адача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


int[,] generate2dArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;

}

void GetAverages(int[,] matrix)
{
  int[] sum = new int[matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum[i] += matrix[j, i];
    }

  }
  foreach (double elem in sum)
            {
                
                Console.Write($"{elem/matrix.GetLength(1)} ");
            }
}

Random rand = new Random();
int m = 7; //? Просто захардкодим
int n = 7;
int[,] matrix = generate2dArray(m, n);
GetAverages(matrix);

