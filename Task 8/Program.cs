Console.Write("a = ");
int number1_ = int.Parse(Console.ReadLine());
Console.Write("b = ");
int number2_ = int.Parse(Console.ReadLine());
Console.Write("c = ");
int number3_ = int.Parse(Console.ReadLine());

int maxSide = Max(number1_, number2_, number3_);
Console.WriteLine($"Найбільша сторона: {maxSide}");

static int Max(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}
