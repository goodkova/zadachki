// По двум заданным числам проверять является ли первое квадратом второго

int A = new Random().Next(1,10);
int B = new Random().Next(1,10);
if (A/B==B)
{
    Console.WriteLine($"{A} number square {B}");
}
else
{
    Console.WriteLine($"{A} not a square number {B}");
}