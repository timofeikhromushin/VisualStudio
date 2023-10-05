using System.Diagnostics;

Console.WriteLine("Количество дней - ");
int k = Convert.ToInt32(Console.ReadLine());
double distance = 10;
double summa = 10;

for (int i = 1; i < k; i++)
{
    distance *= 1.1;
    summa += distance;
}
Console.WriteLine($"Он пробежит - {summa}");
