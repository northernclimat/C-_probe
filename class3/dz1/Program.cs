// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//! Не интересно. Сформулируем так: Напишите программу, которая принимает на вход набор символов и проверяет, является ли он палиндромом

Console.WriteLine("Please, input your collection of symbols: ");
string str = Console.ReadLine();

if (IsPalindrome(str))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not a palindrome");
}

bool IsPalindrome(string n) {
        string trimmed = string.Concat(n.Where(c => !Char.IsWhiteSpace(c))); //* We won't calculate whitespaces in order to parce strings correctly(example "А роза упала на лапу Азора")
        return trimmed.ToLower().Reverse().SequenceEqual(trimmed);
    }
