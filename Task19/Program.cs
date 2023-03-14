// Задача №19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number.Length != 5)
    {
    System.Console.WriteLine("Вы ввели не корректное число.");
    }
else if (number!.Length == 5)
{
    int firstdNum = Convert.ToInt32(Convert.ToString(number[0]));
    int lastdNum = Convert.ToInt32(Convert.ToString(number[4]));
    int secNum = Convert.ToInt32(Convert.ToString(number[1]));
    int frddNum = Convert.ToInt32(Convert.ToString(number[3]));

    if (firstdNum == lastdNum && secNum == frddNum)
    {
        System.Console.WriteLine("Число " + number + " является полиндромом");
    }
    else 
    {
        System.Console.WriteLine("Число " + number + " не является полиндромом");
    }

}



