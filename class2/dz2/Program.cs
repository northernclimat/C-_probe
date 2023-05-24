// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Please, input a number: ");
string num = Console.ReadLine();
int lenght = num.Length;
if (lenght < 3)
    {
        Console.WriteLine("The number doesn't have third digit");
    }
else
    {
        Console.WriteLine($"The 3rd digit of your number is {num[2]}");
    }
