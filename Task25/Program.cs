// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int MyPow(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}
int[] array = new int[2];
System.Console.WriteLine("Введите первое число: ");
array[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
array[1] = Convert.ToInt32(Console.ReadLine());

int result = MyPow(array[0], array[1]);
System.Console.WriteLine(@"Число " + array[0] + " в степени " + array[1] + " равно " + result);

// int[] array = new [2];
// int arr = Array.ConvertAll(Console.ReadLine().Split(" "). int.Parse);
// for (int = 0; i < arr.Lenght; i++)
// {
//     System.Console.WriteLine(arr[i]+ " ");
// }
// System.Console.WriteLine(myPow(array[0], array[1]));

// int firstdNum = Convert.ToInt32(Convert.ToString(number[0]));



// int[] array = new int[2];
// System.Console.WriteLine("Введите первое число: ");
// int array[0] = Convert.ToInt32(Console.Readline());
// System.Console.WriteLine("Введите второе число: ");
// int array[1] = Convert.ToInt32(Console.ReadLine());

// int[] array = {5, 7};

// System.Console.WriteLine(@"Число " + array[0] + " в степени " + array[1] + " равно " + myPow(array[0], array[1]));
// System.Console.WriteLine(myPow(array[0], array[1]));



