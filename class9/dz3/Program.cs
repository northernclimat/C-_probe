// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

ulong InputaMeasure(string text)
{
    Console.WriteLine(text);
    return ulong.Parse(Console.ReadLine());
}


ulong GetAkkermanValue(ulong n, ulong m) //? ulong, хотя честно говоря особого смысла нет, и uint вполне хватит(все равно не получится вывести значения больше указанных)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return GetAkkermanValue(n - 1, 1);
    else
        return GetAkkermanValue(n - 1, GetAkkermanValue(n, m - 1));
}

ulong m = InputaMeasure("Please, input first number !! Don't fill in more than 5!!! ");
ulong n = InputaMeasure("Please, input second number !! Don't fill in more than 3!!! ");


Console.WriteLine(GetAkkermanValue(n, m));