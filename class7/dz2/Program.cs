// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

//? Где брать массив - не указано. Также не указан вид чисел, которые будут заполнять массив. Вывод - генерируем простейший массив случайных целых чисел.
int InputaMeasure(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

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

void ifIndexesEsxist(int[,] arr, int x, int y)
{
    try{
        Console.WriteLine($"Value of the element is: {arr[x, y]}");
    }
    catch{
       Console.WriteLine("Indexes ate not exist in the matrix presented");
    }
}

Random rand = new Random();
int m = rand.Next(10); //? Просто сгенерируем для разнообразия хоть какого-то
int n = rand.Next(10);
int[,] matrix = generate2dArray(m, n);
int x = InputaMeasure("Input x");
int y = InputaMeasure("Input y");
ifIndexesEsxist(matrix, x, y);

