// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    System.Console.WriteLine("a = " + a + "," + "b = " + b + "-> да");
}
else
{
    System.Console.WriteLine("a = " + a + "," + "b = " + b + "-> нет");
}
