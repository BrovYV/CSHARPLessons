// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int digit1 = number/100;
    int digit2 = number%10;
    int sum = digit1 + digit2;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Некорректное число");
}