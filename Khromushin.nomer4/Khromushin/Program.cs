//№4

Console.WriteLine("Введите числа");
Console.Write("x=");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y=");
double y = Convert.ToDouble(Console.ReadLine());
double polovsum = (x + y) / 2;
double ydvoinproiz = 2 * (x * y);
if (x == y)
    Console.WriteLine("Числа не подходят");
else
if (x<y)
{
    x = polovsum;
    y = ydvoinproiz;
}
else
{
    y = polovsum;
    x = ydvoinproiz;
}

Console.WriteLine($"x = {x}; y = {y}");