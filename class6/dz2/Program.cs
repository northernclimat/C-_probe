// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//? прямые пересекаются тогда и только тогда, когда они не параллельны. У параллельных прямых в декартовой системе координат равны угловые коэффициенты. В точке пересечения прямых x1=x2, y1=y2

bool IfLinesAreParralelles(double k1, double k2)
{
    return k1 == k2;
}

void GetaPointOfCrossing()
{
    Console.WriteLine("Please, input k1, b1, k2, b2 via spaces, e.g. 1 2.2 3 4.5");
    double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    if (IfLinesAreParralelles(nums[0], nums[2]))
    {
        Console.WriteLine("Pointed Lines are parralleled or same");
    }
    else
    {
        double x = (nums[3] - nums[1])/(nums[0] - nums[2]);
        double y = nums[0] * x + nums[1];
        Console.WriteLine($"Coordinates of crossing point are [{x};{y}]");
    }

}

GetaPointOfCrossing();