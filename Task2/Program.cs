﻿// Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");        // выводим приглашение к вводу первого числа
int a = Convert.ToInt32(Console.ReadLine());     // конвертируем введенную строку в число и присваиваем значение переменной num1

Console.WriteLine("Введите второе число: ");        // выводим приглашение к вводу первого числа
int b = Convert.ToInt32(Console.ReadLine());     // конвертируем введенную строку в число и присваиваем значение переменной num2

if (a > b)                                    // Условие: Если num1 > num2
{
    Console.WriteLine("a=" + a+", b=" + b+" max -> " + a);                 // То выводим такой результат
}
else                                                // Иначе
{
    Console.WriteLine("a=" + a+", b=" + b+" max -> " + b);                 // выводим такой результат
}