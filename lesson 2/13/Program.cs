// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

string? enter = Console.ReadLine();

if (enter!=null)
{
    if(enter.Length>=3)
        Console.WriteLine(enter[2]);
    else
        Console.WriteLine("третьей цифры нет");
}