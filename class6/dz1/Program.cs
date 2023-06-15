// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void GetArrayLenght()
{   
    Console.WriteLine("Please, input the numbers via spaces, e.g. 1 2 3");
    int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).Where(s => s > 0).ToArray();
    Console.WriteLine($"Quantity of numbers which are greater than 0 are: {nums.Length}");
}

GetArrayLenght();