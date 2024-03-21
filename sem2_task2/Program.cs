// Напишите программу, которая принимает на вход трехзначное число, 
// и возводит вторую цифру этого числа в степень равную третьей цифры
// 487 = 8^7
// 456 = 5^6




Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
double result = 1;

if (number < 1000 && number > 99 || number < -99 && number > -1000)
{
    int digit2 = number / 10 % 10;
    int digit3 = number % 10;
    
    //изменение знака третьей цифры если цифра изначально отрицательная
    if (digit3 < 0)
    {
        digit3 *= -1;   //digit3 = digit3 * -1
    }
//алгоритм возведения в степень
    while (count < digit3)
    {
        result = result * digit2;
        count++;
    }
    
    //вычисление результата для отрицательной степени
    if (digit2 < 0)
    {
        result = 1 / result;
    }
    
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректное число");
}