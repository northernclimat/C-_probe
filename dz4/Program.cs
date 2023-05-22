// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Поменяю условие, чтобы было хоть немного интереснее. Все четные от 0 до Z, где Z принадлежит множеству целых чисел

Console.Write("Please, put a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 0)
    {
    for (int start = 0; start <= num; start += 2)  //0 - even number!!!
        {   string end = "";
            if (start + 2 > num)
                {end = "";}
            else
                {end = ", ";}
            Console.Write($"{start}{end}");
        }
    }
else
    {
    for (int start = 0; start >= num; start -= 2)  //0 - even number!!!
        {   string end = "";
            if (start - 2 < num)
                {end = "";}
            else
                {end = ", ";}
            Console.Write($"{start}{end}");
        }   
    }

