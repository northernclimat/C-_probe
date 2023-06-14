// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//? Снова аналогичная задача

int[] GetArray(int num)
{
    int[] newArray = Enumerable.Range(1, num).Select(s => new Random().Next(-1000,1000)).ToArray(); //! Вообще-то, границы данных задавать не стоит по условию задачи. Но тогда проверять дико трудно. Они легко убираются, достаточно написать ... Random().Next()...
    return newArray;
}

int QuantityOfRelatedElements(int[] arr, int min, int max)
{
    int quantity = 0;
    foreach (int num in arr)
    {
        if (num <= max && num >= min)
        {
            quantity ++;
        }
    }
    return quantity;
}

int lenght = 123;
int min = 10;
int max = 99;
int [] arr = GetArray(lenght);
Console.WriteLine($"Массив: {string.Join(" ", arr)}, кол-во элементов, принадлежащих указанному отрезку: {QuantityOfRelatedElements(arr, min, max)}");