Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine((num1) + " " + "большее число");
    Console.WriteLine((num2) + " " + "меньшее число");
}
if (num1 < num2)
{
    Console.WriteLine((num2) + " " + "большее число");
    Console.WriteLine((num1) + " " + "меньшее число");
}
else
{
    if (num1 == num2)
    {
      Console.WriteLine("числа равны");  
    }
    
}