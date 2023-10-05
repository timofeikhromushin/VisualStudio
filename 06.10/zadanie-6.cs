double i;
double summa = 0;
while (true)
{
    Console.WriteLine("Введите число посдедовательности, для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    if (summa == 0)
    {
        summa = i;
    }
    else { 
    summa *= i;
    }
    Console.WriteLine($"Произведение - {summa}");


}