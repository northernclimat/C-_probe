// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputaMeasure(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}


string ShowNumbers(int n)
{

    return n == 1? "1" : n + " " + ShowNumbers(n - 1);
}

int n = InputaMeasure("Please, input upper range: ");
Console.WriteLine(ShowNumbers(n));
