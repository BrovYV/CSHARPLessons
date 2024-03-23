Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

int digit1 = 0;
int digit2 = 0;

if (num >= 10 && num <= 99)
{
    digit1 = num/10;
    digit2 = num%10;
    if (digit1 > digit2)
    {
        Console.Write($"(В числе {num} наибольшая цифра {digit1})");
    }
    else
    {
        Console.Write($"(В числе {num} наибольшая цифра {digit2})");
    }
}
else
{
    Console.Write("Введите правильное число");
}