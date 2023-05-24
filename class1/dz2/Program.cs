// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int n = 0;
int max = 0;

while (n < 3)
    {   Console.WriteLine($"Please, input  {n + 1} number");
        int newNum = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
            {max = newNum;};
        if (newNum > max)
            {max = newNum;}
        n++;
    }
Console.WriteLine($"max={max}");
