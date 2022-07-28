// По двум заданным числам проверять является ли первое квадратом второго

// int A = new Random().Next(-10,10);
// int B = new Random().Next(-10,10);
double A = Double.PositiveInfinity;
double B = Double.PositiveInfinity;
if (B * B == A)
{
    Console.WriteLine($"{A} is a square of {B}");
}
else
{
    Console.WriteLine($"{A} is NOT a square of {B}");
}