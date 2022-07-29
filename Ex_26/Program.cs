// 26. Возведите число А в натуральную степень B используя цикл

int A = new Random().Next(1,5);
int B = new Random().Next(1,5);
Console.WriteLine($"{A}, {B}");
int result = 1;

for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine($"result = {result}");