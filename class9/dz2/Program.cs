// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int InputaMeasure(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int SumOfNumbers(int m, int n)
{

    return m == n? m : n + SumOfNumbers(m, n - 1);
}


int m = InputaMeasure("Please, input lower range: ");
int n = InputaMeasure("Please, input higher range: ");
Console.WriteLine(SumOfNumbers(m, n));
