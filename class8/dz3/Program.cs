// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//! Я не буду усложнять код и коммутировать умножение на возможный случай матриц разной размерности. Умножение все равно возможно.
//! Чтобы решить задание быстро, генерируемые матрицы будут квадратными(простейший частный случай), как в примере

int InputaMeasure(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,] Generate2dArray(int m, int n)
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

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo, int m)
    {
        int [,] resultMatrix = new int[m, m];

        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                for (int k = 0; k < matrixTwo.GetLength(0); k++)
                {
                    resultMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                }
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        return resultMatrix;
    }

int m = InputaMeasure("please, input needed size of matrixes:");
int [,] matrixOne = Generate2dArray(m, m);
Console.WriteLine("-------------");
int [,] matrixTwo = Generate2dArray(m, m);
Console.WriteLine("############");
MultiplicationMatrix(matrixOne, matrixTwo, m);

