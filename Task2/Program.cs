Console.WriteLine("Введите M...");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N...");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("M");
Console.Write("=");
Console.Write(M);
Console.Write("N");
Console.Write("=");
Console.Write(N);
Console.Write("--> ");
int sum = 0;
int numbers(int m)
{
    
    if (m == 1) 
    {
        return m;
    }
    else 
    {
        sum = m + numbers(m - 1);
        return sum;
    }
}
for(int i = M; i < N + 1; ++i)
{
    Console.Write(numbers(i));
    Console.Write(";");
    ++M;
}