Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int digit = 0;

if (num <= 10)
{
    digit = num;
    Console.Write(digit);
}
else
{
    while (num >= 10)
    {
        digit = num % 10;
        num = num / 10;
        Console.Write(digit + ", ");
    }
    Console.Write(num + " ");
}