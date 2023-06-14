// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//? Задача полностью аналогична 1, менять ничего не буду, помня о том, что вы снижаете оценки за произвольное изменение условий задачи

int[] GetArray(int num)
{
    int[] newArray = Enumerable.Range(1, num).Select(s => new Random().Next(-100,100)).ToArray(); //! Вообще-то, границы данных задавать не стоит по условию задачи. Но тогда проверять дико трудно. Они легко убираются, достаточно написать ... Random().Next()...
    return newArray;
}

int SumOfOddIndexedNumbers(int[] arr)
{   
    int sum = 0;
    for (int i=0; i < arr.Length; i++)
    {
       if (i % 2 != 0)
       {
        sum += arr[i];
       }
    }
    return sum;
}

Console.WriteLine("Please, input the lenght of your array:");
int lenght = int.Parse(Console.ReadLine());
int [] arr = GetArray(lenght);
Console.WriteLine($"Массив: {string.Join(" ", arr)}, сумма элементов на нечетных позициях: {SumOfOddIndexedNumbers(arr)}");