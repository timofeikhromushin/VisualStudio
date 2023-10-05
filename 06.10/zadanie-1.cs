double k;
double sum = 0;
while (true)
{
    Console.WriteLine("Введите число посдедовательности, для остановки введите - 0");
    i = Convert.ToDouble(Console.ReadLine());
    if ( k == 0)
    {
        break;
    }
    sum += k;
    Console.WriteLine($"Сумма: {sum}");


}