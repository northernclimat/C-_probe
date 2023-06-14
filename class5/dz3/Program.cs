// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//! Ничего не сказано о способе задания массива и его размере, поэтому я снова воспользуюсь генератором

double[] GetArray(int num, double min, double max)
{
    double[] newArray = Enumerable.Range(1, num).Select(s => new Random().NextDouble() * (max-min) + min).ToArray(); 
    return newArray;
}

double MinMaxDifference(double[] arr, double min, double max)
{   
    foreach (double el in arr)
    {
       if (el > max)
       {
        max = el;
       }
       else if (el < min)
       {
        min = el;
       }
    }
    
    return max-min;
}

Console.WriteLine("Please, input the lenght of your array:");
int lenght = int.Parse(Console.ReadLine());
//! введем границы массива
Console.WriteLine("Please, input min number of your array:");
double min = double.Parse(Console.ReadLine());
Console.WriteLine("Please, input max number of your array:");
double max = double.Parse(Console.ReadLine());
double [] arr = GetArray(lenght, min, max);
Console.WriteLine($"Массив: {string.Join(" ", arr)}, разница между мин и макс элементами : {MinMaxDifference(arr, min, max)}");