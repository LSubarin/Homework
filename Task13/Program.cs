// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// Математическое решение.
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int thdN = (num%1000)/100;

// if(thdN>0)
// {
//     System.Console.WriteLine(thdN);
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }

// Решение с помощью строк и массивов

// System.Console.WriteLine("Введите число: "); 
// string? number = Console.ReadLine(); // Считываем строковую переменную number (? означает что строка может быть пустой)

// if(number!.Length < 3)   // Если длина массива строки меньше 3

// {
//     System.Console.WriteLine("Число не содержит третьей цифры"); // Выводим это сообщение
// }
// else                                                // Иначе
// {
//     System.Console.WriteLine(number[2]);            // Выводим элемент массива с индексом 2 (0.1.2) - третью цифру
// }

// Работа с конвертацией
System.Console.WriteLine("Введите число: "); 
string? number = Console.ReadLine();
if(number!.Length > 2)
{
int thirdNum = Convert.ToInt32(Convert.ToString(number[2])); // Присваиваем переменной thirdNum значение элемента массива number [2]. При этом конвертируем его сначала в строку, потом в Int32
System.Console.WriteLine(thirdNum);
}
else
{
    System.Console.WriteLine("wrong number");
}




