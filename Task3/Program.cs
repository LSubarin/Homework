//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

System.Console.WriteLine("Введите номер: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("Такого дня недели нет");
        break;
}

