// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число, а я определю четное оно или нет");
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); //int b = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Да, число - " + num + " четное");
}
else
{
    Console.WriteLine("Нет, число - " + num + " не четное");
}
