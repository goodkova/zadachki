// 28. Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Enter the number: ");

string str = Console.ReadLine();
bool flag = true;
int i = 0;
int summ = 0;

while (i < str.Length && flag)
{
    if (str[i] >= '0' && str[i] <= '9')
    {
        // summ += str[i] - '0';
        i++;
    }
    else
    {
        flag = false;
        break;
    }
}
if (flag)
{
    Console.WriteLine($"summ = {summ}");
}
else
{
    Console.WriteLine("Error: Incorrect input");
}
