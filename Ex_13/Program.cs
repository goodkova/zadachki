// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.Clear();
// Random rnd = new Random();
// int N = 0;
// int P = 1;
// while (N < P)
// {
//     N = rnd.Next(1,10);
//     P = rnd.Next(1,10);
// }
// Console.WriteLine($"{N}, {P}");
// int remainder = N % P;
// if (remainder == 0)
// {
//     Console.WriteLine($"the number {N} is a multiple of the number {P}");
// }
// else
// {
//     Console.WriteLine($"Result = {remainder}");
// }
Console.Clear();
int N = new Random().Next(1, 20);
int P = new Random().Next(1, 20);
Console.WriteLine($"{N}, {P}");
if (N < P)
{
    N = N + P; P = N - P; N = N - P;
}
Console.WriteLine($"{N}, {P}");
int remainder = N % P;
if (remainder == 0)
{
    Console.WriteLine($"the number {N} is a multiple of the number {P}");
}
else
{
    Console.WriteLine($"Result = {remainder}");
}

