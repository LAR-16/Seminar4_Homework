Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for( int i = 0; i < array.Length; i++)
    array[i] = new Random(). Next(-100, 101);

Console.WriteLine($"[{string.Join(", ", array)}]");

int K = new Random(). Next(-N, N+1);
Console.WriteLine(K);


int[] array2 = new int[N];
if (K > 0)
{
    for (int j = 0; j+K < N; j ++)
    {
                // j = j + K;
        array2[j + K] = array[j]; 
    }
    for (int j = N-K; j < N; j ++)
    {
                // j = j + K;
        array2[j-(N-K)] = array[j]; 
    }
}

if (K < 0)
{
    for (int j = 0; j-Math.Abs(K) < 0; j ++)
    {
        // i = i + (N-Math.Abs(K));
        array2[j + (N-Math.Abs(K))] = array[j];       
    }

    for(int j = Math.Abs(K); j < N; j++)
    {
        // i = i - Math.Abs(K);
        array2[j - Math.Abs(K)] = array[j];
    }
}

Console.WriteLine($"[{string.Join(", ", array2)}]");