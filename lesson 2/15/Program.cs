// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int enter = Convert.ToInt32(Console.ReadLine());

if(enter>5)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");