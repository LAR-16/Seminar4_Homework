Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int z = Convert.ToInt32(Console.ReadLine());

int product = 1;
for(int i = 1; i <= z; i ++)
    product = product * a;

Console.WriteLine($"{a} в степени {z} равно {product}");