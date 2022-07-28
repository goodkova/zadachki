// 15 Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();
int N = new Random().Next(1, 3500);
// int N = 0;
int P1 = 7;
int P2 = 23;
Console.WriteLine($"{N}, {P1}, {P2}");
if (N != 0 && N % P1 == 0 && N % P2 == 0)
{
    Console.WriteLine($"the number {N} is a multiple of the number {P1} and {P2}");
}
else
{
    Console.WriteLine($"Result = not a multiple of the number {P1} and {P2} ");
}
