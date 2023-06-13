// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//! так как требования вычислять корень числа нет - это не рекурсия

int GetANumberFromConsole()
{
    Console.WriteLine("Please, input your number:");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetaSumofDigits(int a)
{
    int num = a.ToString().Sum(e => int.Parse(e.ToString()));

    return a > 9 ? num : a;
}

Console.WriteLine(GetaSumofDigits(GetANumberFromConsole()));