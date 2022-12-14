// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Х у точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y у точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z у точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х у точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y у точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z у точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
double result2 = Math.Round(result,2);
Console.WriteLine($"Расстояние: {result2}");