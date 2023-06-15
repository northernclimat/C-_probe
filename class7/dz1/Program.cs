// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int InputaMeasure(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

double[,] generate2dArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.NextDouble() * 100;
            Console.Write("{0,6:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
    return matrix;

}

int m = InputaMeasure("Please, input number of rows");
int n = InputaMeasure("Please, input number of columns");
generate2dArray(m, n);
