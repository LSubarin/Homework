// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите число, обозначающее день недели: ");
int num = Convert.ToInt32(Console.ReadLine()); 

// if(num == 6 || num == 7)
// {
//    System.Console.Write("Этот день выходной");
// }
// else
// {
//     System.Console.Write("Этот день рабочий");
// }

switch (num)
{
    case 1:
        System.Console.WriteLine("Понедельник - рабочий");
        break;
    case 2:
        System.Console.WriteLine("Вторник - рабочий");
        break;
    case 3:
        System.Console.WriteLine("Среда - рабочий");
        break;
    case 4:
        System.Console.WriteLine("Четверг - рабочий");
        break;
    case 5:
        System.Console.WriteLine("Пятница - рабочий");
        break;
    case 6:
        System.Console.WriteLine("Суббота - выходной");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье - выходной");
        break;
    default:
        System.Console.WriteLine("Такого дня недели нет");
        break;
}