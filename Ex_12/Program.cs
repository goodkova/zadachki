// 12. Удалить вторую цифру трёхзначного числа

Console.Clear();
int N = new Random().Next(100, 1000);
Console.WriteLine($"N = {N}");
int units = N % 10;
int hundreds = N / 100;
int result = hundreds * 10 + units;
Console.WriteLine($"Result = {result}");
