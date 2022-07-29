// 27. Определить количество цифр в числе


int num = new Random().Next(1, 10000000);
Console.WriteLine($"number = {num}");
int i = 0;
while (num > 0)
{
    num /= 10;
    i++;
}
Console.WriteLine("Number of digits of the entered number: {0}", i);
