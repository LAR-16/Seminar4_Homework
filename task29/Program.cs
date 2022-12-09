Console.Clear();
Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < n; i ++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    Console.WriteLine();  
Console.WriteLine($"[{string.Join(", ", array)}]");