// Напишите программу, которая на вход принимает
// два числа и выводит является ли первое число кратно второму.
// Если первое тчисло не кратно второму, то программа выводит остаток от деления.





Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;
if (result == 0)
{
Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число некратно второму\n остаток от деления = {result}");
}