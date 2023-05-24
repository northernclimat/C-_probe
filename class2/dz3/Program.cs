// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Please, input the number of the day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

//? Типовое и некрасивое решение


if (dayNumber > 0 && dayNumber < 6)
    {
        Console.WriteLine("No");
    }
else if (dayNumber > 5 && dayNumber < 8)
    {
        Console.WriteLine("Yes");
    }
else Console.WriteLine("No such number of the day");

//? Нравится чуть больше

int[] week = Enumerable.Range(1, 7).ToArray();

if (week[..5].Contains(dayNumber))
    {
        Console.WriteLine("No");
    }
else if (week[^2..].Contains(dayNumber))
    {
        Console.WriteLine("Yes");
    }
else Console.WriteLine("No such number of the day");

//! Ну и функция, вроде как изучали на лекции


string dayChecking(int day)
    {
         return day > 0 && day < 8 ? day > 0 && day < 6 ? "No" : "Yes" : "No such number of the day";
    }

Console.WriteLine(dayChecking(dayNumber));
