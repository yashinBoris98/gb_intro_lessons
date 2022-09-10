// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("a(");
int ax =Convert.ToInt32(Console.ReadLine());
Console.Write(",");int ay =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(")");

Console.WriteLine("b(");
int bx =Convert.ToInt32(Console.ReadLine());
int by =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(")");

Console.WriteLine(Math.Sqrt(
    Math.Pow((bx-ax),2)+Math.Pow((by-ay),2)
));