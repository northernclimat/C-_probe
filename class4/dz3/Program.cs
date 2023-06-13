

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] GetArrayFromConsole()
{
  Console.WriteLine("Please, input the numbers via space, e.g. 1 3 5 6:");
  int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
  return nums;
}

Console.WriteLine($"[{string.Join(", ", GetArrayFromConsole())}]");
