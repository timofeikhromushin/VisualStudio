// №10

Console.WriteLine("Введите a :");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b :");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c :");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k :");
double k = Convert.ToDouble(Console.ReadLine());
if (k != 0)
{
    if (a % k == 0) Console.WriteLine("k делитель а");
    if (b % k == 0) Console.WriteLine("k делитель b");
    if (c % k == 0) Console.WriteLine("k делитель c");

}
else
{
    Console.WriteLine("k не может быть равен нулю");
}
