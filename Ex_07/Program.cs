// Показать числа от -N до N

Console.Clear();
int N = new Random().Next(-10,10);
if (N < 0)
{
    N = -N;
}
for (int i = -N; i <= N; i++)
{
    Console.Write($"{i}, ");
}


