// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordsA = new int[3];
System.Console.WriteLine("Введите координату x точки А:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки А:");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];
System.Console.WriteLine("Введите координату x точки B:");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B:");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки B:");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

int result1 = (int)Math.Pow(coordsB[0]-coordsA[0], 2);
int result2 = (int)Math.Pow(coordsB[1]-coordsA[1], 2);
int result3 = (int)Math.Pow(coordsB[2]-coordsA[2], 2);
double resultEnd = Math.Sqrt(result1+result2+result3);

System.Console.WriteLine(Math.Round(resultEnd,3));
