// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Please, input last number of your range"); 
int lastNum = int.Parse(Console.ReadLine());
if (lastNum == 0)
{
    Console.WriteLine("Check your number, it's less equal to 0");
}
else
{
//* Простой цикл
for (int i=1; i<=lastNum;i++)
{if (i < lastNum)
    {Console.Write($"{Math.Pow(i, 3)}, ");}
 else
    {Console.Write($"{Math.Pow(i, 3)}\n");}
}

//* массив, вроде изучали

int[] numbers = Enumerable.Range(1, lastNum).ToArray();
int[] coubNumber = new int[numbers.Length];
for (int i=0; i < numbers.Length; i++)
{
    coubNumber[i] = (int)Math.Pow(numbers[i], 3);
}
foreach (int s in coubNumber) Console.Write(s + " ");
}
