// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int n = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

int result=1;
for (int i = 0; i < n2; i++)
{
    result*=n;
}
Console.WriteLine(result);

// Console.WriteLine(Math.Pow(n,n2));