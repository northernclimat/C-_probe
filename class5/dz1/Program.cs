// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int num)
{
    int[] newArray = Enumerable.Range(100, num).Select(s => new Random().Next(100, 999)).ToArray();
    return newArray;
}

Console.WriteLine(string.Join(" ", GetArray(10)));

int SumOfOddNumbers(int[] arr)
{   
    int sum = 0;
    foreach (int el in arr)
    {
       if (el % 2 == 0)
       {
        sum += 1;
       }
    }
    return sum;
}

Console.WriteLine("Please, input the lenght of your array:");
int lenght = int.Parse(Console.ReadLine());
int [] arr = GetArray(lenght);
Console.WriteLine($"Массив: {string.Join(" ", arr)}, кол-во четных элементов: {SumOfOddNumbers(arr)}");