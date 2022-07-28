// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Clear();
int N = new Random().Next(1, 100);
int P = new Random().Next(1, 100);
Console.WriteLine($ "{N}, {P}");
int remainder = N % P;
if (remainder == 0)
{
    Console.WriteLine($"the number {N} is a multiple of the number {P}");
}
else
{
    Console.WriteLine($"Result = {remainder}");
}
