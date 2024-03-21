// Напишите программу, которая на вход принимает трехзначное число, а на выходе
// выводит число без средней цифры (удаляет вторую цифру этого числа)







Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99 || number < -99 && number > -1000)
{
    int digit1 = number/100;
    int digit2 = number % 10;
    int result = digit1 * 10 + digit2;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректное число");
}