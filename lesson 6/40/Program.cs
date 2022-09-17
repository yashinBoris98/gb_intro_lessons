// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

bool canExist = true;
if(a>(b+c)) canExist=false;
if(b>(a+c)) canExist=false;
if(c>(b+a)) canExist=false;
Console.WriteLine(canExist);
