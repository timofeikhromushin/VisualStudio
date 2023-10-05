Console.WriteLine("Введите часы - ");
int k = int.Parse(Console.ReadLine());
int ameba = 1;
if (k < 3)
{
    Console.WriteLine("Отказано");
}
else { 
for (int i = 3;i <= k; i +=3)
{
    ameba *= 2;
}

Console.WriteLine($"Количество амёб - {ameba}");
}