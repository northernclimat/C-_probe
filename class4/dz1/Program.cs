// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//? Решение функцией

double PutNumToDegree()
{
    Console.WriteLine("Please, input  number and degree, e.g. 1 3:");
    double [] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    
    return Math.Pow(nums[0], nums[1]);
}

Console.WriteLine(PutNumToDegree());

