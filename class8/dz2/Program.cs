// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void CheckMinSum(int[,] arr)
{
    int minSum = 0;
    int row = 0;
    for (int i=0; i<arr.GetLength(0); i++)
    {   
        int tempMinSum = 0;
        for (int j=0; j < arr.GetLength(1); j++)
        {
            tempMinSum += arr[i, j];
        }
        if (i == 0)
        {
            minSum = tempMinSum;
        }
        else if (tempMinSum < minSum)
        {
            minSum = tempMinSum;
            row = i;
        }
    }
    Console.WriteLine($"Min sum is located in {row} row");
}

int m = InputaMeasure("please, input number of rows");
int n = InputaMeasure("please, input number of columns");
int[,] matrix = Generate2dArray(m, n);
Console.WriteLine("############");
CheckMinSum(matrix);