// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("How many pairs of dots would you provide?");
int pairQuantity = int.Parse(Console.ReadLine());

for (int i=0; i<pairQuantity; i++)
{
    Console.WriteLine("Please, input coordinates of the 1st point with whitespaces, eg 1 2 3");
    double[] firstPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    Console.WriteLine("Please, input coordinates of the 2nd point with whitespaces, eg 1 2 3");
    double[] secondPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    double distance = Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) + Math.Pow(secondPoint[1] - firstPoint[1], 2) + Math.Pow(secondPoint[2] - firstPoint[2], 2));
    Console.WriteLine($"The distance is {Math.Round(distance, 2)}");
}