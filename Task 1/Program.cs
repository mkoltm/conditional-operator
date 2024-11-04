class Program
{
    static void Main()
    {

        //1
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть ціле число: ");
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("Дорівнює нулю");
        }
        else if (num > 0)
        {
            Console.WriteLine("Число додатнє");
        }
        else
        {
            Console.WriteLine("Число від'ємне");
        }