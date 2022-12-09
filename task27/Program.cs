Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (n > 0)
{
    int a = n % 10;
    count = count + a;
    n /= 10;
}
Console.WriteLine($"Сумма цифр числа равна {count}");