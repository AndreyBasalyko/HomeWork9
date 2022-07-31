Console.WriteLine("Введите число...");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N);
Console.Write("--> ");
int numbers(int m)
{
    if (m == 1) return N;
    else return numbers(m - 1) - 1;
}
for(int i = 1; i < N + 1; ++i)
{
Console.Write(numbers(i));
Console.Write(";");
}