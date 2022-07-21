// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();
int N = new Random().Next(10, 100);
Console.WriteLine($"N = {N}");
int units = N % 10;
int dozens = N / 10;

if (units > dozens)
{
    Console.WriteLine($"Result = {units}");
}
else
{
    Console.WriteLine($"Result = {dozens}");
}
    